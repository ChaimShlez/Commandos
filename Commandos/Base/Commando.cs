using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Commandos.Enums;

namespace Commandos.Entitys
{
    internal  class Commando
    {
         public string Name { get; set; }
       public string CodeName { get; set; }
        public string [] Tools { get; }
      public  Status Status { get; set; }

        public Commando(string name, string codeName, Status status)
        {
            Name = name;
            CodeName = codeName;
            Status = status;
            Tools = new string[]{ " Hammer", " chisel", " rope", "bag", "water tank" };
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


        public virtual void Attack()
        {

            Console.WriteLine($" i'm solder and my name {Name} attack");
        }


    }
}
