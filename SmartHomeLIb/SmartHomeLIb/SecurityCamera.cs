using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeLibrary
{
    public class SecurityCamera : SmartDevice
    {
        public SecurityCamera(string deviceId, string name) : base(deviceId, name)
        {
        }

        public override string GetStatus()
        {
            return $"Camera '{Name}' ";
        }
    }
}
