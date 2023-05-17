using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaker
{
    internal class Notes
    {
        private List<string?> notes = new();

        private string? noteToAdd = null;
        private string? titleToAdd = null;
        private string? combinedToAdd = null;

        private string? searchVariable = null;

        public void GettingNotesToAdd()
        {
            Console.WriteLine("Please enter a title: ");
            titleToAdd = Console.ReadLine();
            Console.WriteLine("Please enter your notes: ");
            noteToAdd = Console.ReadLine();
            AddingNoteToList();
        }

       public void SearchForNotes()
        {
            Console.WriteLine("Enter the title of the notes you wish you view: ");
            searchVariable = Console.ReadLine();

            foreach(string note in notes) 
            {
                if (note.Contains(searchVariable))
                {
                    Console.WriteLine(note); break;
                }
            }

        }


        private void AddingNoteToList()
        {
            combinedToAdd = $"{titleToAdd}- {noteToAdd}";
            notes.Add(combinedToAdd);
        }


    }
}
