#include <OneWire.h>
#include <ArduinoJson.h>

// OneWire DS18S20, DS18B20, DS1822 Temperature Example
//
// http://www.pjrc.com/teensy/td_libs_OneWire.html
//
// The DallasTemperature library can do all this work for you!
// https://github.com/milesburton/Arduino-Temperature-Control-Library

OneWire  ds(10);  // on pin 10 (a 4.7K resistor is necessary)

float automatic_max_temp = 75;
bool automatic = false;

DynamicJsonDocument doc(500);
DynamicJsonDocument receivedDoc(200);

#define klapan_off  0;
#define klapan_on  1;

int klapan_state;

void setup(void) {

pinMode(9, OUTPUT);
  
  Serial.begin(115200);

  klapan_state = klapan_off;

  doc["kl"] = klapan_state;
  doc["T_uo"] = 0;
}

void loop(void) {

// Обрабатывает поступившие запросы, чтобы на выходе сформировать ответ
  if(Serial.available() > 0){
    String receivedString = Serial.readString();
    deserializeJson(receivedDoc, receivedString);
    klapan_state = receivedDoc["klapan"];
    automatic_max_temp = receivedDoc["max_temp"];
  }

/////////////////////////////////////
  byte i;
  byte present = 0;
  byte type_s;
  byte data[12];
  byte addr[8];
  float current_cel;

  if (!ds.search(addr)) {
    ds.reset_search();
    delay(250);
    //Serial.println("ds.reset_search() is not valid!");
    return;
  }
  
  if (OneWire::crc8(addr, 7) != addr[7]) {
      //Serial.println("CRC is not valid!");
      return;
  }
 
  // the first ROM byte indicates which chip
  switch (addr[0]) {
    case 0x10:
      //Serial.println("  Chip = DS18S20");  // or old DS1820
      type_s = 1;
      break;
    case 0x28:
     // Serial.println("  Chip = DS18B20");
      type_s = 0;
      break;
    case 0x22:
     // Serial.println("  Chip = DS1822");
      type_s = 0;
      break;
    default:
    //  Serial.println("Device is not a DS18x20 family device.");
      return;
  } 

  ds.reset();
  ds.select(addr);
  ds.write(0x44, 1);        // start conversion, with parasite power on at the end
  
  delay(2000);     // maybe 750ms is enough, maybe not
  // we might do a ds.depower() here, but the reset will take care of it.
  
  present = ds.reset();
  ds.select(addr);    
  ds.write(0xBE);         // Read Scratchpad

  for ( i = 0; i < 9; i++) {           // we need 9 bytes
    data[i] = ds.read();
  }

  // Convert the data to actual temperature
  // because the result is a 16 bit signed integer, it should
  // be stored to an "int16_t" type, which is always 16 bits
  // even when compiled on a 32 bit processor.
  int16_t raw = (data[1] << 8) | data[0];
  if (type_s) {
    raw = raw << 3; // 9 bit resolution default
    if (data[7] == 0x10) {
      // "count remain" gives full 12 bit resolution
      raw = (raw & 0xFFF0) + 12 - data[6];
    }
  } else {
    byte cfg = (data[4] & 0x60);
    // at lower res, the low bits are undefined, so let's zero them
    if (cfg == 0x00) raw = raw & ~7;  // 9 bit resolution, 93.75 ms
    else if (cfg == 0x20) raw = raw & ~3; // 10 bit res, 187.5 ms
    else if (cfg == 0x40) raw = raw & ~1; // 11 bit res, 375 ms
    //// default is 12 bit resolution, 750 ms conversion time
  }

  //return (float)raw / 16.0;
  current_cel = (float)raw / 16.0;
/////////////////////////////////////

// Добавить отключение автоматики.

if(current_cel >= automatic_max_temp){
  klapan_state = klapan_off;
  digitalWrite(9, HIGH);
}
else if(current_cel < automatic_max_temp){
   klapan_state = klapan_on;
   digitalWrite(9, LOW);
}

  doc["kl"] = klapan_state;
  doc["T_uo"] = current_cel;
  //doc["mta"] = automatic_max_temp;
  doc["maximum_temperature_acually"] = automatic_max_temp;
  //doc["T_uo"] = readTemepature();
  //serializeJson(doc, Serial);
  String j;
  serializeJson(doc, j);
  Serial.print("<begin>");
  Serial.print(j);
  Serial.print("<end>");
}


// better it returns false if an error has occured. and the value we get from returned parameter by reference.
float readTemepature(){
  

}
