using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GibddApp.Model;

namespace GibddApp.Model
{
    public partial class Licence
    {
        public byte[] image
        {
            get
            {
                byte[] filename = File.ReadAllBytes($@"..\..{Driver.DriverPhoto}");
                return filename;
            }
        }

        public string Color
        {
            get
            {
                switch (CategoryStatus.CategoryStatusId)
                {
                    case 1:
                        return "Green";
                    case 2:
                        return "";
                    case 3:
                        return "Red";
                    case 4:
                        return "Red";
                    default:
                        return "Black";
                }
            }
        }

        public string Category
        {
            get
            {
                string result = String.Empty;
                foreach(var x in LicenceCategory)
                {
                    if(result != String.Empty)
                    {
                        result += ", ";
                    }
                    result += x.Category.CategoryName;
                }
                return result;
            }
        }
    }
}
