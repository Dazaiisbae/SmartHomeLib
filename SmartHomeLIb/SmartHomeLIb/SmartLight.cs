using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeLibrary
{
    public class SmartLight : SmartDevice
    {
        public SmartLight(string deviceId, string name) : base(deviceId, name)
        {
        }

        public override string GetStatus()
        {
            return $"Light '{Name}' ";
        }
        ///public void SetBrightness(int value);

    }
}
