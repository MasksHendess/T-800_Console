using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminator.Domain
{
    class Target : Unit
    {
        private string FirstName { get; }
        private string LastName { get; }
        private bool IsHuman { get; }
        private bool TargetIsAlive { get; set; }

        public Target(string firstName, string lastName, bool isHuman, bool targetIsalive) : base(50, 10)
        {
            FirstName = firstName;
            LastName = lastName;
            IsHuman = isHuman;
            TargetIsAlive = targetIsalive;
        }

        public override void Warscream()
        {
            Console.WriteLine("Halp!");
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public bool GetIsHuman()
        {
            return IsHuman;
        }

        public bool GetTargetIsAlive()
        {
            return TargetIsAlive;
        }

        public bool TargetIsDead()
        {
            TargetIsAlive = false;
            return TargetIsAlive;
        }
    }
}
