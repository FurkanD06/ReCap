using ReCap.Abstract;
using ReCap.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Concrete
{
    public class OfterManager : IOfterService
    {
        public void Delete(Ofter ofter)
        {
            Console.WriteLine("Campaign deleted : " + ofter.CampaignName);
        }

        public void New(Ofter ofter)
        {
            Console.WriteLine("New campaign : " + ofter.CampaignName);
        }

        public void Update(Ofter ofter)
        {
             Console.WriteLine("Campaign Updated : " + ofter.CampaignName);
        }
    }
}
