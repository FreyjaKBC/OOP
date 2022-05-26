using System;
using System.Text.RegularExpressions;

namespace OOP_Stregsystemet
{
    public class User : IComparable<User>
    {
        //skal være private og længere nede public?
        private int id;
        private string firstName;
        private string lastName;
        private string userName;
        private string email;
        private decimal balance;

        public User(string firstname,  string lastname, string username, string email, decimal balance)
        {
            FirstName = firstname;
            LastName = lastname;
            UserName = username;
            Email = email;
            Balance = balance;
        }

        //Tilføj noget med det skal være unikt og større end forrige?
        public int Id   // property
        {
            get { return id; }   // get method
            set { id = value; }  // set method
        }

        public string FirstName   
        {
            get { return firstName; }  
            set {
                if (firstName == null)
                {
                    throw new ArgumentException($"First name cannot be null");
                }
                firstName = value;
            }  
        }

        public string LastName
        {
            get { return lastName; }
            set {
                if (lastName == null)
                {
                    throw new ArgumentException($"Last name cannot be null");
                }
                lastName = value;
            }
        }

        //Check om regex er korrekte
        public string UserName
        {
            get { return userName; }
            set
            {
                Regex usernameRegex = new Regex(@"[0-9a-zA-Z_]+");

                if (!usernameRegex.IsMatch(UserName))
                {
                    throw new ArgumentException($"Invalid username: {UserName}");
                }

                userName = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                Regex emailRegex = new Regex(@"([0-9a-zA-Z_.-]+)@([\w][\w.-]+\.[\w]{2,})");

                if (!emailRegex.IsMatch(Email))
                {
                    throw new ArgumentException($"Invalid email: {Email}");
                }

                email = value;
            }
        }

        //Tilføj delegate saldo under 50 kr
        public decimal Balance   
        {
            get { return balance; }   
            set { balance = value; }  
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", FirstName, LastName, Email);
        }

        public override bool Equals(object other)
        {

            if (other is User)
            {
                return ((User)other).Id == Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public int CompareTo(User other)
        {
            return Id - other.Id;
        }
    }
}
