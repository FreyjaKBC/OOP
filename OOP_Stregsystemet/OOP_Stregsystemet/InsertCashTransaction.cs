using System;
namespace OOP_Stregsystemet
{
    public class InsertCashTransaction : Transaction
    {

        public InsertCashTransaction(int id, string user, DateTime date, decimal amount)
            : base(id, user, date, amount)
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override void Execute()
        {
            User.Balance += Amount;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
