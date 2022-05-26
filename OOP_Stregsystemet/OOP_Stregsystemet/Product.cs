using System;
namespace OOP_Stregsystemet
{
    public class Product
    {
        private int id;
        private string name;
        private decimal price;
        private bool active;
        private bool onCredit;

        public Product(int id, string name, decimal price, bool active, bool onCredit)
        {
            Id = id;
            Name = name;
            Price = price;
            Active = active;
            OnCredit = onCredit;
        }

        //Skal være unikt?
        public int Id   // property
        {
            get { return id; }   // get method
            set { id = value; }  // set method
        }

        public string Name   
        {
            get { return name; }   
            set {
                if (name == null)
                {
                    throw new ArgumentException($"Name cannot be null");
                }
                name = value; } 
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public bool OnCredit
        {
            get { return onCredit; }
            set { onCredit = value; }
        }


        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Id, Name, Price);
        }
    }
}
