using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminator
{
  abstract class Unit // Abstract gör så att man inte kan göra Unit objekt unless ärvning
  {
            private int Helth { get; set; }
            private int UnitAttack { get; set; }

            public Unit(int helth, int unitAttack)
            {
                Helth = helth;
                UnitAttack = unitAttack;
            }

            public int GetHelth()
            {
            return Helth;
            }

            public int GetUnitAttack()
            {
            return UnitAttack;
            }

            public void Attack(Unit victim)
            {
                victim.Defend(UnitAttack);
            }

            public void Defend(int damage)
            {
                Helth -= damage;
            }

            //public virtual void Warscream()
            //{
            //    Console.WriteLine(". . .");

            //}
            public abstract void Warscream();
            public bool IsAlive
            {
                get { return Helth > 0; } // if helth > 0 return true else return false
            }
            public virtual void PrintStatus()
            {
                if (IsAlive)
                {
                    Console.WriteLine("Unit is alive");
                    Console.WriteLine("Helth: " + Helth + "\nAttack: " + UnitAttack);
                }
                else
                {
                    Console.WriteLine("Target has been Terminated");
                }
            }
  }
}
