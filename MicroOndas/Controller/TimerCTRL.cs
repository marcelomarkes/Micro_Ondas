using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class TimerCTRL
    {
       int tempo = 0;
       int minuto = 0;
       int segundo = 0;

        public void ReceberTempo(Object ObjTempo)
        {
            tempo = Convert.ToInt32(ObjTempo);

            if(tempo >= 60)
            {
                minuto = tempo / 60;
                segundo = tempo % 60;
            }
            else
            {
                minuto = 0;
                segundo = tempo;
            }
        }


    }
}
