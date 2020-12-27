using System;

namespace Task_003
{
    class Content
    {
        private string contentValue;

        public string ContentProperty
        {
            set
            {
                contentValue = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(contentValue);
        }
    }
}
