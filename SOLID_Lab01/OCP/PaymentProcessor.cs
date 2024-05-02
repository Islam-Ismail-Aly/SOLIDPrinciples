using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Lab01.OCP
{
    public class PaymentProcessor
    {
        public void ProcessPayment(IPayment payment, double amount)
        {
            payment.Pay(amount);
        }
    }
}
