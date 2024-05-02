namespace SOLID_Lab01.LSP
{
    public class SavingsAccount : BankAccountTransaction
    {
        public decimal InterestRate { get; set; } = 5.0m;
        public override void Withdraw(decimal amount)
        {
            //Impose a withdrawal fee
            amount += InterestRate;
            Balance = amount;
        }
    }
}
