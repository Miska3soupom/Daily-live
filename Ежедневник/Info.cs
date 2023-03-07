using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ежедневник
{
    internal class Info
    {
        public DateTime Date;
        public string Mantxt;
        public string Sextxt;

        public Info(DateTime date, string maintxt, string sectxt)
        {
            Date = date;
            Mantxt = maintxt;
            Sextxt = sectxt;
        }
        public Info() { }
    }
}
