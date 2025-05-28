using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commandos.Base;
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

            foreach (var  solder in listCommando)
            {
                solder.GetName("ffsgcxc");
                
                solder.Attack();
                Console.WriteLine(String.Join(",",solder.Tools));

                if (solder is ISwim swimmer)
                {
                    swimmer.Swiming();
                }
                else if (solder is ISkyJump jumping)
                {
                    jumping.jumping();
                }
            }
        }
    }
}
