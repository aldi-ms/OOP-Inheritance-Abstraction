namespace _04.CompanyHierarchy
{
    public abstract class Person : IPerson
    {
        private int id;
        private string 
            firstName,
            lastName;

        public Person(int id, string firstName, string lastName)
        {
            this.id = id;
            
            
        }

        public int ID
        {
            get { return this.id; }
            private set { }
        }

        public string FirstName
        {
            get { return this.firstName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }
    }
}
