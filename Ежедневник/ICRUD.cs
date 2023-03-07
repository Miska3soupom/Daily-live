using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ежедневник
{
    internal interface ICRUD
    {
        void Create();
        List<Info> Read();
        void Update();
        void Delete();
    }
}
