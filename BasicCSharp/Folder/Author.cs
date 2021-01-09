using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_001.Folder
{
    class Author
    {
        private string author;
        public string NameAuthor
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        //public Author(string author)
        //{
        //    this.author = author;
        //}
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(author);
            Console.ResetColor();
        }
    }
}
