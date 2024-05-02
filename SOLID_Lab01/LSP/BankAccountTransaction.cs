namespace SOLID_Lab01.LSP
{
    public abstract class BankAccountTransaction
    {
        public decimal Balance { get; protected set; }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (Balance >= amount)
                Balance -= amount;
            else
                throw new InvalidOperationException("Insufficient balance.");
        }
    }
}
