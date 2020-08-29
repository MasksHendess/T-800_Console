using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminator.Domain
{
    class T800 : Unit
    {
        public string RegistrationNumber { get; set; }


        public T800(string registrationNumber) : base(200, 50)
        {
            RegistrationNumber = registrationNumber;

        }
        public override void Warscream()
        {
            Console.WriteLine("Fuck You A$$Hole");
        }

        public override void PrintStatus()
        {
            if (IsAlive)
            {
                Console.WriteLine("Status Report\nSystem Function Normal");
                Console.WriteLine("Helth: " + GetHelth() + "\nAttack: " + GetUnitAttack());
            }
            else
            {
                Console.WriteLine("Status Update\nWARNING!\nUnit has been Terminated");
            }
        }
    }
}
