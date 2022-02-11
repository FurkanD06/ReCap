using ReCap.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Abstract
{
    public interface IOfterService
    {
        void New(Ofter ofter);
        void Delete(Ofter ofter);
        void Update(Ofter ofter);
    }
}
