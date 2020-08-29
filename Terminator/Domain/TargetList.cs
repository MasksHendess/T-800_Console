using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminator.Domain
{
    class TargetList
    {
        private Target[] MostWantedList;

        public TargetList()
        {
            MostWantedList = new Target[] {
            new Target("Sarah","Conor", true, true),
            new Target("John","Conor",true, true),
            new Target("Kyle","Reese", true, true),
            new Target("T1000"," ", false, false)
            };
        }

        public Target[] GetTargets()
        {
            return MostWantedList;
        }

        public void ListTargets()
        {
            int i = 1;
            foreach (Target target in MostWantedList)
            {
                Console.WriteLine(i +". "+target.GetFirstName()+ " " +target.GetLastName() +
                "\t Human Target: " + target.GetIsHuman() + "\t Living Target: "+ target.GetTargetIsAlive());
                i++;
            }
        }

        public int SelectTarget(int currentTarget)
        {
            Console.WriteLine("Select Target:");
            currentTarget = Convert.ToInt32(Console.ReadLine());
            return currentTarget;
        }
    }
}
