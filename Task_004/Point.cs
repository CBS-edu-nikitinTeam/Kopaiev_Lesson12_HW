namespace Task_004
{
    class Point 
    {
        private int firstValue;
        private int secondValue;
        private string figureName;

        public int FirstValue
        {
            get 
            {
                return firstValue;
            }
        }

        public int SecondValue
        {
            get
            {
                return secondValue;
            }
        }

        public string RectangleName
        {
            get
            {
                return figureName;
            }
        }

        public Point(int firstValue, int secondValue, string figureName) 
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.figureName = figureName;
        }
    }
}
