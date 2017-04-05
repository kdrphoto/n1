using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja1.figury
{
    class goniec : figura
    {
        public goniec(Pozycja pozycja, string kolor) : base(pozycja, kolor)
        { 
        }
            public virtual bool CzyMoznaPrzesunac(Pozycja nowaPozycja)
            
            {
            return CzySkos(nowaPozycja);
        
        }
    }

}
