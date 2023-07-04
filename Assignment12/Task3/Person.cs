namespace Task3
{
    public class Person
    {
        public long ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }

        public Person() { }

        public Person(long id, string firstname, string lastname, int age) 
        {
            ID = id;
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
        }

        public override bool Equals(object? p2)
        {
            if(this.GetType() != p2.GetType()) return false;

            Person person2 = (Person)p2;

            if(ID == person2.ID) return true;

            return false;
        }
    }
}
