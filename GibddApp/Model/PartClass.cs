using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GibddApp.Model
{
    public partial class Driver
    {

        public byte[] image
        {
            get
            {
                byte[] filename = File.ReadAllBytes($@"..\..{DriverPhoto}");
                return filename;
            }
        }
    }
}
