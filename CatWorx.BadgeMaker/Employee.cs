
// "namespace" allows access to any class that uses CatWorx.BadgeMaker
namespace CatWorx.BadgeMaker
{
    class Employee
    {

        public string FirstName;
        public string LastName;
        public int Id;
        public string PhotoUrl;

        // constructor method
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
