using ReCap.Abstract;
using ReCap.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Concrete
{
    public class OfterSalesManager : IOfterSalesService
    {
        public void Sales(Gamer gamer, Ofter ofter)
        {
            Console.WriteLine("Campaign has been sold");
        }
    }
}
