using System;

namespace BasicCSharp
{
    class Address
    {
        public string Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }

    }
    class Rectangle
    {
        private double side1, side2, area, perimeter;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double Area
        {
            get
            {
                return side1 * side2;
            }
        }
        public double Perimeter
        {
            get
            {
                return (side1 + side2)*2;
            }
        }
        public double AreaCalculator()
        {
            return side1*side2;
        }
        public double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }
    }
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(content);
            Console.ResetColor();
        }
    }
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
    class Book
    {

        Content content = new Content();
        Author author = new Author();
        Title title = new Title();
        //void InitializeBook()
        //{
        //    Content content = new Content();
        //    Author author = new Author();
        //    Title title = new Title();
        //}
        public Book(string title)
        {
            this.title.NameTitle = title;
        }
        public string Author
        {
            set
            {
                this.author.NameAuthor = value;
            }
        }
        public string Content
        {
            set
            {
                this.content.NameContent = value;
            }
        }
        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.content.Show();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book=new Book("Совершенный код");
            book.Author = "C. Макконелл";
            book.Content = new string('.', 50);
            book.Show();
            //Title title = new Title();
            //title.NameTitle = "Совершенный код";
            //title.Show();
        }
    }
}
