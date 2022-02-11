using ReCap.Abstract;
using ReCap.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Concrete
{
    public class GameManager : IGameService
    {
        public void Sales(Gamer gamer)
        {
            Console.WriteLine("The game has been sold : " + gamer.FirstName);
        }
    }
}
