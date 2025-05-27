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

            Commando chaim = new Commando("chaim", 12122, Status.Standing);
            
                Console.WriteLine(chaim.Name);
        }
    }
}
