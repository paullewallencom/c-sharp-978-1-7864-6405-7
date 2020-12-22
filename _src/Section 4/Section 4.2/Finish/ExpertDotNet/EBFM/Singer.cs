namespace EBFM
{
    public class Singer
    {
        public Singer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; }
        public string LastName { get; }
    }
}