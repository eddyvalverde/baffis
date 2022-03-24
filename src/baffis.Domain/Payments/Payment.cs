using baffis.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baffis.Payments
{
    public class Payment
    {
        public int IdPayment { get; set; }
        public Order order { get; set; }
        public decimal Cost { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
