using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminator.Domain
{
    class Menu
    {
        TargetList MostWantedList = new TargetList();
        T800 Arnold = new T800("12345");
        private Target[] Target;
        private string CurrentTarget = "No Target"; 
        private int TargetIndex = 0;

        public Menu()
        {
            Target = MostWantedList.GetTargets(); // We now have MostWantedList in the Menu
        }

        public void TerminatorMenu()
        {
            Console.WriteLine("==Skynet T800 Manual Action Overide Protocol 1.0==");
            Console.WriteLine("\n1. Select Target\n2. Terminate Target\n3. Status\n4. Exit");
            Console.WriteLine("\nCurrent Target: "+ CurrentTarget);
            Console.Write("\nSelect Action:");
            string choise = Console.ReadLine();
            switch (choise)
            {
             case "1": 
                MostWantedList.ListTargets(); // Lists all Available Targets in the MostWantedList
                TargetIndex =  MostWantedList.SelectTarget(TargetIndex);// lets the user select a Target to make current target
                if(Target[TargetIndex-1].GetIsHuman() == true && Target[TargetIndex -1].GetTargetIsAlive() == true)
                {                                           // checks if the target is a Human and if the Target is Alive, no point in killing a dead guy
                 CurrentTarget = Target[TargetIndex-1].GetFirstName() +" "+ Target[TargetIndex-1].GetLastName(); 
                                                         // Sets the CurrentTarget to the Selected Target 
                                                        // it selects TargetIndex - 1 because Arrays start from 0 ( 1 would be 2, 2 would be 3 etc)
                 SetTargetSubroutine(); // this is just fluff
                }
                else if(Target[TargetIndex-1].GetIsHuman() == false) // Checks if Target is Human, no killing fellow Terminators!
                {
                 Console.WriteLine("--ERROR--\nUser Has Selected a Non Human Target\nTermination Target must be Human");
                 }
                 else if (Target[TargetIndex - 1].GetTargetIsAlive() == false) // Checks if Target is alive, Can't kill dead people!
                 {
                   Console.WriteLine("--ERROR--\nSelected Target has already been Eliminated");
                 }
             break;
             case "2": // Terminate Target
                    TerminateTargetSubroutine(); // Terminates the Target, marking it as dead when compleate
             break;
             case "3":
                Arnold.PrintStatus(); // Checks the Terminators Status and writes them to the screen
             break;
             case "4":
                Environment.Exit(0); // bye!
             break;
             default:
               Console.WriteLine("--Unkown Action--"); // Select Better noob! :p
             break;
            }
            Console.ReadLine();
            Console.Clear();
        }

        private void SetTargetSubroutine() // just some flavour fluff 
        {
            Console.WriteLine("Initilizing Termination Protocols");
            Console.ReadLine();
            Console.WriteLine("New Target acquired");
            Console.WriteLine("Target is " + CurrentTarget);
          //  System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=BlrjHLnNzAo"); if it bleeds we can kill it 
        }
        private void TerminateTargetSubroutine()
        {
            if(CurrentTarget == "No Target") // Nothing Happens if the user hasn't specified a Target yet
            {
            Console.WriteLine("--ERROR--\nUser has not selected a Target");
            }
            else { // but if a target is selected the Terminator Engages the Target
            Console.WriteLine("Initialize Combat Subroutines");// fluff
            Console.ReadLine();                         
            Console.WriteLine("Target: " + CurrentTarget + "\nEngaging");
            Console.ReadLine();
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=bgLfOrVJJMg"); //Ill be back T1
            Console.ReadLine();
            Console.Clear();// All right we made the Terminator go after the Target now what?
            Console.WriteLine("Attacking Target"); 
            Console.ReadLine();
            Arnold.Attack(Target[TargetIndex-1]);// Arnold is attacking the target
            Target[TargetIndex-1].PrintStatus();// since targets hp is super low it dies here
            Console.ReadLine();
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Hhm7aWp8gvc"); // Hast La Vista Baby T2
            CurrentTarget = "No Target";// Target has been eliminated 
            Target[TargetIndex - 1].TargetIsDead(); // And the Target is marked as dead
            }
        }
    }
}
