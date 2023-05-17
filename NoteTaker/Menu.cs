using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaker
{
    internal class Menu
    {
        private string? input;


        public void DisplayMenu()
        {
            Console.WriteLine("What would you like to do?\n1 - Add notes\n2 - Search for notes\n3 - Update notes");
           SwitchMenuChoice(input = Console.ReadLine());
        }

        private void SwitchMenuChoice(string input)
        {

            switch(input.ToLower()) 
            {
                case string when input.Contains("add"): break;
                case string when input.Contains("search"): break;
                case string when input.Contains("update"): break;
                default: Console.WriteLine($"I do not understand {input}"); break;
            
            }

        }

    }
}
