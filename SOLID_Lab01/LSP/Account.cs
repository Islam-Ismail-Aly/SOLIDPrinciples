namespace SOLID_Lab01.LSP
{
    public class Account : BankAccountTransaction
    {
        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            if (Balance >= amount)
                Balance -= amount;
            else
                throw new InvalidOperationException("Insufficient balance.");
        }
    }
}
