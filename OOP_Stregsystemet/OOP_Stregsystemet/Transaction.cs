using System;
namespace OOP_Stregsystemet
{
    //Abstrakt klasse?
    abstract class Transaction
    {
        private int id;
        private string user;
        DateTime date;
        private decimal amount;


        public Transaction(int id, string user, DateTime date, decimal amount)
        {
            Id = id;
            User = user;
            Date = date;
            Amount = amount;
        }

        public int Id

        {
            get { return id; }
            set { id = value; }
        }

        public string User

        {
            get { return user; }
            set
            {
                if (user == null)
                {
                    throw new ArgumentException($"User cannot be null");
                }
                user = value;
            }
        }

        public DateTime Date

        {
            get { return date; }
            set { date = value; }
        }

        public decimal Amount

        {
            get { return amount; }
            set { amount = value; }
        }


        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Id, User, Amount, Date);
        }
    }
}
