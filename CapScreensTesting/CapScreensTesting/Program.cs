using ScreenCap;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System;

namespace CapScreensTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var cap = new CaptureNow(null);
            cap.Start();
            Console.ReadLine();
        }
        
    }
}
