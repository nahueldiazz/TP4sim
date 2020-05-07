using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4Sim
{
    public class ControlIntervalo
    {


        public ControlIntervalo()
        {

        }

        public int intervalosEjercicio(double rnd)
        {
            if (rnd > 0 && rnd<0.29)
            {
                return 20;
            }
            else if (rnd > 0.30 && rnd < 0.54)
            {
                return 21;
            }else if (rnd > 0.55 && rnd < 0.74)
            {
                return 22;
            } else if (rnd > 0.75 && rnd < 0.89)
            {
                return 23;
            }else if (rnd > 0.90 && rnd < 0.94)
            {
                return 24;
            }
            else
            {
                return 25;
            }
           
        }
    }
}
