using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using TestArduinoCOM.BL;
using System.Windows.Forms;

namespace TestArduinoCOM
{
    class COM_ARDUINO
    {
        static Action<string> _f;

        public static void start(string com, Action<string> update_func)
        {
            _f = update_func;

            m_serial_port = new SerialPort(com);
            m_serial_port.BaudRate = 9600;
            m_serial_port.Parity = Parity.None;
            m_serial_port.StopBits = StopBits.One;
            m_serial_port.DataBits = 8;
            m_serial_port.Handshake = Handshake.None;
			

            m_serial_port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            m_serial_port.Open();
        }

		public static List<string> GetAllCOM()
		{
            return SerialPort.GetPortNames().ToList();
        }

        public static void stop()
        {
            if (m_serial_port == null) return;
            m_serial_port.Close();
            m_serial_port.Dispose();
            m_serial_port = null;
        }

        static StringBuilder sp_output = new StringBuilder();

        static string appendPart(string p)
		{
            sp_output.Append(p);

            var tmp = sp_output.ToString();

			if (tmp.StartsWith("<begin>") && tmp.EndsWith("<end>"))
			{
                tmp = tmp.Replace("<end>", "");
                tmp = tmp.Replace("<begin>", "");
                sp_output.Clear();
                return tmp;
            }

            return null;
        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            //Action _a = () =>
            //{
            //    lock (locker)
            //    {
            //        SerialPort sp = (SerialPort)sender;

            //        // always will end with <end>

            //        var str = sp.ReadLine();// если из МК отправляем последний пакет методом println, то чтение так, плюс убрать симол новой строки: 111*

            //        //var res = appendPart(sp.ReadExisting());
            //        //var res = appendPart(str);
            //        var res = str.Trim().Replace("<end>", "").Replace("<begin>", "");// 111*

            //        LogGer.WriteLine(res);

            //        if (!string.IsNullOrEmpty(res))
            //            _f(res);
            //    };
            //};

            //Task.Run(_a);

            //==========================
            SerialPort sp = (SerialPort)sender;

            // always will end with <end>

            var str = sp.ReadLine();// если из МК отправляем последний пакет методом println, то чтение так, плюс убрать симол новой строки: 111*

            //var res = appendPart(sp.ReadExisting());
            //var res = appendPart(str);
            var res = str.Trim().Replace("<end>", "").Replace("<begin>", "");// 111*

            LogGer.WriteLine(res);

            if (!string.IsNullOrEmpty(res))
                _f(res);
        }

        static SerialPort m_serial_port = null;

		private static void sendData(string str)
		{
            //Action _a = () =>
            //{
            //    lock (locker)
            //    {
            //        m_serial_port.Write(str);
            //    };
            //};

            //Task.Run(_a);

            m_serial_port.Write(str);
        }

        public static void SetMaxTemperatureUO(decimal vLow, decimal cHi)
		{
            var snd = new SendData { cmd = CmdCode.set_max_temp_uo, val = cHi };
            sendData(snd.SerializeData() + ";");

            var snd1 = new SendData { cmd = CmdCode.set_min_temp_uo, val = vLow };
            sendData(snd1.SerializeData() + ";");
        }

        public static void SetAutoMode(bool v)
        {
            var snd = new SendData { cmd = CmdCode.set_auto_mode, val = v };
            sendData(snd.SerializeData() + ";");
        }

        public static void OpenKlapan()
        {
            var snd = new SendData { cmd = CmdCode.set_klapan_state, val = klapan_state.open };
            sendData(snd.SerializeData() + ";");
        }

        //static object locker = new object();

        public static void CloseKlapan()
        {
            var snd = new SendData { cmd = CmdCode.set_klapan_state, val = klapan_state.close };
            sendData(snd.SerializeData() + ";");
        }

        public static void SetDuration(int d)
		{
            var snd = new SendData { cmd = CmdCode.set_duration, val = d };
            sendData(snd.SerializeData() + ";");
        }
    }
}
