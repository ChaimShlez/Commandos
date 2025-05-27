using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Commandos.Enums;

namespace Commandos.Entitys
{
    internal class Commando
    {
         public string Name { get; set; }
        string CodeName { get; set; }
        string [] Tools { get; }
        Status Status { get; set; }

        public Commando(string name, string codeName, Status status)
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

        public string GetName(string CommandoRank)
        {
            switch  (CommandoRank)
            {
                case "general":
                    return Name;
                   
                case "colonel":

                    return CodeName;
                default:
                    return "The information is classified and " +
                         "therefore cannot be accessed";
                    break;
            }
        }


    }
}
