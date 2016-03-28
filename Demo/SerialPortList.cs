using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Demo
{
    public class SerialPortList
    {
        [DllImport("kernel32.dll")]
        static extern uint QueryDosDevice(string lpDeviceName, IntPtr lpTargetPath,
           uint ucchMax);

        [DllImport("kernel32.dll")]
        public static extern uint GetLastError();

        public const int ERROR_INSUFFICIENT_BUFFER = 122;

        public static string[] GetPortNames()
        {

            List<string> retval = null;
            int returnSize = 0;
            int maxSize = 100;
            string allDevices = null;
            IntPtr mem;

            while (returnSize == 0)
            {
                mem = Marshal.AllocHGlobal(maxSize);
                if (mem != IntPtr.Zero)
                {
                    try
                    {
                        returnSize = (int)QueryDosDevice(null, mem, (uint)maxSize);
                        if (returnSize != 0)
                        {
                            allDevices = Marshal.PtrToStringAnsi(mem, returnSize);
                            retval = new List<string>(allDevices.Split('\0'));
                            break;
                        }
                        else if (GetLastError() == ERROR_INSUFFICIENT_BUFFER)
                        {
                            maxSize *= 10;
                        }
                        else
                        {
                            Marshal.ThrowExceptionForHR((int)GetLastError());
                        }
                    }
                    finally
                    {
                        Marshal.FreeHGlobal(mem);
                    }
                }
                else
                {
                    throw new OutOfMemoryException();
                }
            }

            List<string> ports = retval.FindAll(name =>
            {
                if (name.Length > 3)
                {
                    if (name.Substring(0, 3).ToUpper() == "COM")
                    {
                        int n;
                        if (int.TryParse(name.Substring(3), out n))
                            return true;
                    }
                }
                return false;
            });
            return ports.ToArray();
        }
    }
}
