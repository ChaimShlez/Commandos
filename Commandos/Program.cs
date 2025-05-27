using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commandos.Entitys;
using Commandos.Enums;

namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Commando> listCommando = new List<Commando>
                {
                    new AirCommando("chaim","06453",Status.Standing),
                    new SeaCommando("ptachia","r323w4",Status.Standing),
                    new Commando("zalosh","ce4555",Status.Standing)
                };

            foreach (var item in listCommando)
            {
                
              
                item.Attack();
            }
        }
    }
}
