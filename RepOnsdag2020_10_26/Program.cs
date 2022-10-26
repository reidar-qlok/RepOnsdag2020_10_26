using System;

namespace RepOnsdag2020_10_26
{
    public class Student
    {
        private string Name1;
        private string setterName;
        public void setName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Namnet får inte vara null eller tomt");
            }
            else
            {
                this.Name1 = name;
            }
        }
        public string getName()
        {
            return Name1;
        }
        public string Name2 
        { 
            get
            {
                return this.setterName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Namnet får inte vara null eller tomt");
                }
                else
                {
                    this.setterName = value;
                }
            }
        }
        public string Name3 { get; set; }
        //private string _City;
        //public string City { get { return _City; } set { _City = value; } }
        public string City { get;  set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            //stud.Name = "Albert";
            stud.setName("Albert");
            string newName = stud.getName();
            stud.Name2 = "Reidar";
            stud.Name3 = "Matilda";
            stud.City = "London";
        }
    }
}
