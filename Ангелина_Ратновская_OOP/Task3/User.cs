using System;

namespace Task3
{
   public class User
    {
       public User(string lastname, string name, string middlename)
        {
            Lastname = lastname;
            Name = name;
            Middlename = middlename;
        }

       public string Lastname { get; set; }

       public string Name { get; set; }

       public string Middlename { get; set; }

        // Приблизительное вычисление возраста из даты рождения.
       public  int Age => DateTime.Now.Subtract(Birthday).Days/365;
       public DateTime Birthday { get; set; }

        public override string ToString()
        {
            return $"{Lastname} {Name} {Middlename}, {Birthday.ToString("d")}, {Age} years old";
        }
    }
}
