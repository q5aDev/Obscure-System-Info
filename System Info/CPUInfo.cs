using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor.Collections;
using OpenHardwareMonitor.Hardware;

namespace System_Info
{
    class CPUInfo
    {
        private DateTime now;
        protected readonly ListSet<ISensor> active = new ListSet<ISensor>();
        public event SensorEventHandler SensorAdded;
        public event SensorEventHandler SensorRemoved;

        protected virtual void ActivateSensor(ISensor sensor)
        {
            if (active.Add(sensor))
                if (SensorAdded != null)
                    SensorAdded(sensor);
        }
        string temperature;
        public Computer thisComputer;
        public void first()
        {
            thisComputer = new Computer() { CPUEnabled = true };

            thisComputer.Open();
        }
        public string GetCpuTemp()
        {

            String temp = "";

            foreach (var hardwareItem in thisComputer.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.CPU)
                {
                    hardwareItem.Update();
                    foreach (IHardware subHardware in hardwareItem.SubHardware)
                        subHardware.Update();

                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {

                            temp = sensor.Value.Value.ToString();

                        }
                    }
                }
            }

            return temp;

        }
    }
}
