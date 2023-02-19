// wrapping the class in this namespace means we can access it directly from any class using same namespace.

namespace CatWorx.BadgeMaker
{
    class Employee
    // properties declared in body of the class with their types
    {
        //Protection levels given default of private so can only be accessed in class itself
        // use public access modifier to use within the program
        // use of property access is part of OOP Encapsulation - have full control over whether something usable everywhere or not
        private string FirstName;
        private string LastName;
        private int Id;
        private string PhotoUrl;
        // methods also need types declared and can only used properties already declared above. Constructor method must be public
        // use PascalCase for public and camelCase for private
        public Employee (string firstName, string lastName, int id, string photoUrl)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            PhotoUrl = photoUrl;
        }
        public string GetFullName(){
            return FirstName + " " + LastName;
        }
        public int GetId(){
            return Id;
        }
        public string GetPhotoURL(){
            return PhotoUrl;
        }
    }
}