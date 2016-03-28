using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading;

namespace Demo
{
    public class ServoController : IDisposable
    {
        private string portName;
        private Queue<ServoData> queue;
        private SerialPort port;
        private Thread sendingThread;

        public ServoController(string portName)
        {
            this.portName = portName;
            queue = new Queue<ServoData>();
        }

        public void Start()
        {

            if (port == null)
            {
                port = new SerialPort(portName, 9600);
            }
            port.Open();

            sendingThread = new Thread(SendData);
            sendingThread.Start();
        }

        public void Stop()
        {
            if (sendingThread != null)
            {
                sendingThread.Abort();
            }
            if (port != null)
            {
                port.Close();
            }
        }

        public void AddDataToQueue(ServoData data)
        {
            lock (queue)
            {
                queue.Enqueue(data);
            }
        }

        private void SendData()
        {
            ServoData data;
            byte[] binData = new byte[3];
            binData[0] = 0xAA;
            while (true)
            {
                if (queue.Count > 0)
                {
                    lock (queue)
                    {
                        data = queue.Dequeue();
                    }
                    binData[1] = (byte)data.Servo;
                    binData[2] = (byte)data.Value;
                    port.Write(binData, 0, 3);
                }
            }
        }

        public class ServoData
        {
            public char Servo;
            public int Value;
        }

        public void Dispose()
        {
            if (port != null)
            {
                port.Close();
                port.Dispose();
                port = null;
            }
        }
    }
}
