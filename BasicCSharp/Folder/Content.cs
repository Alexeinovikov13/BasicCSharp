using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_001.Folder
{
    class Content
    {
        private string content;
        public string NameContent
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }
        //public Content(string content)
        //{
        //    this.content = content;
        //}
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(content);
            Console.ResetColor();
        }
    }
}
