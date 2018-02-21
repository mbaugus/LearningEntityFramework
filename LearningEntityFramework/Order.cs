using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEntityFramework
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderDescription { get; set; }
        public virtual Customer customer { get; set; }
    }
}
