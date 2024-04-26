namespace d // folder d
{
    public class Person
    {
        public string Name;
        public int Age;
        public double Weight;

        public Person()// this is the default constructor function
        { 
        }

        public Person(string Name, int Age, double Weight)// function overload
        {
            this.Name = Name;
            this.Age = Age;
            this.Weight = Weight;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
