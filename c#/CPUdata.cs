using System;
using System.Management;
using System.Threading;
using System.Windows.Forms;

namespace Perf_monitor
{
    
    public class CPUdata
    {
        public string CPUName;
        public int CPUClock;
        public int CPUVolt;
        public int CPUUtility;
        Thread cpuMonitor;
        public void CPUthread()
        {
            cpuMonitor = new Thread(new ThreadStart(CpuActivityThread));
            cpuMonitor.Start();

            Console.WriteLine(CPUClock);
            Console.WriteLine(CPUVolt);
            Console.WriteLine(CPUUtility);

        }


        public void CpuActivityThread()
        {
            try
            {   //find specific managment classes for the cpu (more can be added later)
                ManagementClass cpuDataClass = new ManagementClass("Win32_Processor");
                //ManagementClass cpuDataClassFreq = new ManagementClass("Win32_PerfFormattedData_PerfOS_Processor");
                ManagementClass cpuDataClassUtility = new ManagementClass("Win32_PerfFormattedData_PerfOS_Processor");

                // get basic info from the cpu
                ManagementObjectCollection cpuDataClassCollection = cpuDataClass.GetInstances();
                foreach (ManagementObject obj in cpuDataClassCollection)
                {
                    //CPU name
                    CPUName = Convert.ToString(obj["Name"]);
                    //CPU clock speed
                    CPUClock = Convert.ToInt32(obj["CurrentClockSpeed"]);
                    //CPU voltage
                    CPUVolt = Convert.ToInt32(obj["CurrentVoltage"]);
                }

                // get constant changing cpu data (utilization, etc.)
                while (true)
                {
                    //target main cpu instances
                    ManagementObjectCollection cpuDataClassUtilityCollection = cpuDataClassUtility.GetInstances();
                    //target specific cpu utility instances
                    foreach (ManagementObject obj in cpuDataClassUtilityCollection)
                    {
                        if (Convert.ToString(obj["Name"]) == "_Total")
                        {
                            //CPU utility
                            CPUUtility = Convert.ToInt32(obj["PercentProcessorTime"]);
                            Thread.Sleep(100);
                        }

                    };

                    //check cpu temp, utilization every 1 sec
                    Thread.Sleep(100);
                };
            }

            catch (ThreadAbortException tbe)
            {
                throw tbe;
            };
        }
    }
}
