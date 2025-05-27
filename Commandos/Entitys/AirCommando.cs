using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commandos.Base;
using Commandos.Enums;

namespace Commandos.Entitys
{
    internal class AirCommando : Commando, ISkyJump
    {
        public AirCommando(string name, string codeName, Status status) 
            : base(name, codeName, status)
        {
        }

        public void jumping()
        {
            Console.WriteLine("I'M jumping");
        }

        public override void Attack()
        {

            Console.WriteLine($" i'm air commando and my name {Name} attack");
        }
    }
}
