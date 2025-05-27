using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Entitys
{
    internal class Weapon
    {
        public string Name;
        public string CreatorName;

        public int amountBulas;

        public Weapon(string name, string creatorName, int amountBulas)
        {
            Name = name;
            CreatorName = creatorName;
            this.amountBulas = amountBulas;
        }


        public void Shoot()
        {
            amountBulas--;
            Console.WriteLine("shoot");

        }
    }
}
