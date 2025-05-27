using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commandos.Enums;

namespace Commandos.Entitys
{
    internal class Commando
    {
        public string Name;
        public long CodeName;
        public string [] Tools;
        public Status Status;

        public Commando(string name, long codeName, Status status)
        {
            Name = name;
            CodeName = codeName;
            Status = status;
            Tools = new string[] { " Hammer", " chisel", " rope", "bag", "water bottle" };
        }


        public void Walk()
        {
            Status = Status.walking;
            Console.WriteLine($"the {Name} wlking");
        }
        public void Hide()
        {
            Status = Status.hiding;
            Console.WriteLine($"the {Name} hiding");
        }
        public void Attack()
        {
            
            Console.WriteLine($"the {CodeName} attack");
        }


    }
}
