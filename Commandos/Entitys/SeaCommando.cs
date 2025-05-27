using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commandos.Base;
using Commandos.Enums;

namespace Commandos.Entitys
{
    internal class SeaCommando : Commando , ISwim
    {
        public SeaCommando(string name, string codeName, Status status) 
            : base(name, codeName, status)
        {
        }

        public void Swiming()
        {
            Console.WriteLine("I'M swiming");
        }


        public override void Attack()
        {

            Console.WriteLine($" i'm sea commando and my name {Name} attack");
        }
    }
}
