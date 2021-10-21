using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GibddApp.Model
{
    public static class Context
    {
        public static GibddDBEntities _con = new GibddDBEntities();
    }
}
