namespace App
{
    public class Address
    {
        public Address(string line1, string line2, string city, string postcode)
        {
            Line1 = line1;
            Line2 = line2;
            City = city;
            Postcode = postcode;
        }

        public string Line1 { get; private set; }
        public string Line2 { get; private set; }
        public string City { get; private set; }
        public string Postcode { get; private set; }
    }
}