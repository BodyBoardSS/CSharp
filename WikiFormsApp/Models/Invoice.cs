

using System;

namespace WikiAPI.Models
{
    public class Invoice
    {
        public int addId { get; set; }

        public MethodPayment methodPayment { get; set; }
        public Person person { get; set; }

        public string invEmployee { get; set; }
        public DateTime invDate { get; set; }
        public double invTotal { get; set; }
    }
}