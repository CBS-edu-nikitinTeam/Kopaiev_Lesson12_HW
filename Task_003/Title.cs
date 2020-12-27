using System;

namespace Task_003
{
    class Title
    {
        string titleValue;

        public string TitleProperty
        {
            set
            {
                titleValue = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(titleValue);
        }
    }
}
