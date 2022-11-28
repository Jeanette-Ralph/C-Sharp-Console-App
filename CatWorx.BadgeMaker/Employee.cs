
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
        public Employee(string firstName, string lastName, int id, string photoUrl)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            PhotoUrl = photoUrl;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public int GetId()
        {
            return Id;
        }
        public string GetPhotoUrl()
        {
            return PhotoUrl;
        }
    }
}
