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
        private readonly Notes notes;

        public Menu(Notes notes)
        {
            this.notes = notes;
        }

        public void DisplayMenu()
        {
            Console.WriteLine("What would you like to do?\n Add notes\n Search for notes\n Update notes");
           SwitchMenuChoice(input = Console.ReadLine());
        }

        private void SwitchMenuChoice(string input)
        {

            switch(input.ToLower()) 
            {
                case string when input.Contains("add"): notes.GettingNotesToAdd(); break;
                case string when input.Contains("search"): notes.SearchForNotes(); break;
                case string when input.Contains("update"): break;
                default: Console.WriteLine($"I do not understand {input}"); break;
            
            }

        }

    }
}
