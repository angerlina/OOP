namespace Task3
{
   public class Employee : User
    {
        public Employee(string lastname, string name, string middlename) : base(lastname, name, middlename) { }
        public string Position { get; set; }
        public uint Experience { get; set; }

    }
}
