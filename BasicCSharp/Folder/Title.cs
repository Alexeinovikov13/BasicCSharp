using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_001.Folder
{
    class Title
    {
        private string title;
        public string NameTitle
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        //public Title(string title)
        //{
        //    this.title = title;
        //}
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(title);
            Console.ResetColor();
        }
    }
}
