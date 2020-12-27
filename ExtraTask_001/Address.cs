namespace ExtraTask_001
{
    class Address
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;

        public int Index { get => index; set => index = value; }
        public string Country { get => country; set => country = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public int House { get => house; set => house = value; }
        public int Apartment { get => apartment; set => apartment = value; }
    }
}
