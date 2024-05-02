using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Lab01.OCP
{
    public class BankTransferPaymentMethod : IPayment
    {
        public void Pay(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
