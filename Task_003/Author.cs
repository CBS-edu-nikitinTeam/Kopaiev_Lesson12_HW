using System;

namespace Task_003
{
    class Author
    {
        private string authorValue;

        public string AuthorProperty
        {
            set
            {
                authorValue = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(authorValue);
        }
    }
}
