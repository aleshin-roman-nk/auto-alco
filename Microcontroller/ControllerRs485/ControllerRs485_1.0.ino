#include <OneWire.h>
#include <DallasTemperature.h>
#include <ArduinoJson.h>

#define SERIAL_DIRECTION_CONTROL 6
#define TEMPERATURE_UO_PIN 5
#define TEMPERATURE_CUB_PIN 4
#define KLAPAN_PIN 9

OneWire oneWire_UO(TEMPERATURE_UO_PIN);
OneWire oneWire_CUB(TEMPERATURE_CUB_PIN);

DallasTemperature sensorsUO(&oneWire_UO);
DallasTemperature sensorsCUB(&oneWire_CUB);

DynamicJsonDocument doc(500);
DynamicJsonDocument receivedDoc(200);

//float automatic_max_temp = 75;
float auto_close_kl_temp;// температура и выше этой : которой клапан закрывается
float auto_open_kl_temp;// температура и ниже этой : клапан открывается

bool automatic = false;

/*
 * 0 - OK
 * 1 - attempting to change klapa state when the auto mode is on.
 * 
*/
#define error_ok 0
#define error_klapa_violation 1
int error_state = error_ok;

//#define klapan_close  0;// косяк: в условном операторе так не работает.
//#define klapan_open  1;

const int klapan_close = 0;
const int klapan_open = 1;

int klapan_state;

void setup(void) {

  pinMode(KLAPAN_PIN, OUTPUT);
  pinMode(SERIAL_DIRECTION_CONTROL, OUTPUT);

  Serial.begin(115200);

  klapan_state = klapan_open;

  doc["kl"] = klapan_state;
  doc["T_uo"] = 0;

  auto_close_kl_temp = 75.2;// температура и выше этой : которой клапан закрывается
  auto_open_kl_temp = 75;// температура и ниже этой : клапан открывается

  sensorsUO.begin();
  sensorsCUB.begin();
  sensorsUO.setResolution(11);
  sensorsCUB.setResolution(11);

  turnToRecieve();
}

void loop(void) {

  char receivedData[64] = "";

  // Парсим поступившие запросы, чтобы на выходе сформировать ответ
  if (Serial.available() > 0) {
    //String receivedString = Serial.readString();
    //deserializeJson(receivedDoc, receivedString);

    int amount = Serial.readBytesUntil(';', receivedData, 64 );
    receivedData[amount - 1] = '\0';
    deserializeJson(receivedDoc, receivedData);
    
    int cmd = receivedDoc["cmd"];

// set_max_temp_uo = 1
// set_auto_mode = 2
// set_klapan_state = 3 
    if(cmd == 1)
    {
      auto_close_kl_temp = receivedDoc["val"];
      error_state = error_ok;
    }
    else if(cmd == 2)
    {
      automatic = receivedDoc["val"];
      error_state = error_ok;
    }
    else if(cmd == 3)
    {
      if(automatic)
        error_state = error_klapa_violation;
      else
      {
        klapan_state = receivedDoc["val"];
        error_state = error_ok;
      }
    }
    else if(cmd = 4){
      auto_open_kl_temp = receivedDoc["val"];
      error_state = error_ok;
    }
  }
  else{
    error_state = error_ok;
  }

  // Чтение датчиков
  sensorsUO.requestTemperatures();
  sensorsCUB.requestTemperatures();

  float current_celCUB = sensorsCUB.getTempCByIndex(0);
  float current_celUO = sensorsUO.getTempCByIndex(0);

  if (automatic) {
    if (current_celUO >= auto_close_kl_temp/*&& klapan_state == klapan_open*/) {
      klapan_state = klapan_close;
      digitalWrite(KLAPAN_PIN, HIGH);
    }
    else if (current_celUO <= auto_open_kl_temp) {
      klapan_state = klapan_open;
      digitalWrite(KLAPAN_PIN, LOW);
    }
  }
  else
  {
    if(klapan_state == klapan_close)
    {
       digitalWrite(KLAPAN_PIN, HIGH);
    }
    else if(klapan_state == klapan_open)
    {
       digitalWrite(KLAPAN_PIN, LOW);
    }
  }

  // Подготовка пакета
  doc["kl"] = klapan_state;
  doc["auto"] = automatic;

  if (current_celUO != DEVICE_DISCONNECTED_C) {
    doc["T_uo"] = current_celUO;
  } else doc["T_uo"] = 0;

  if (current_celCUB != DEVICE_DISCONNECTED_C) {
    doc["T_cub"] = current_celCUB;
  } else doc["T_cub"] = 0;

  doc["maximum_temperature_acually"] = auto_close_kl_temp;
  doc["min_temperature_acually"] = auto_open_kl_temp;
  doc["error_code"] = error_state;
  // Отправка пакета
  turnToSender();
  String j;
  serializeJson(doc, j);
  Serial.print("<begin>");
  Serial.print(j);
  Serial.println("<end>");
  delay(200);

  turnToRecieve();
  delay(200);
}


void turnToRecieve() {
  digitalWrite(SERIAL_DIRECTION_CONTROL, LOW);
}

void turnToSender() {
  digitalWrite(SERIAL_DIRECTION_CONTROL, HIGH);
}
