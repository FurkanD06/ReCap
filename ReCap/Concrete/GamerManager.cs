using ReCap.Abstract;
using ReCap.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Concrete
{
    public class GamerManager : IGamerService
    {
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Player deleted");
        }

        public void Save(Gamer gamer)
        {
            if (gamer.NationalityId == "10765310856" && gamer.FirstName == "Furkan" 
                && gamer.LastName == "Demir" && gamer.DateOfBirth == "2005.5.14")
            {
                Console.WriteLine("Player registered");
            }
            else
            {
                throw new Exception("Kayıt başarısız");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("The player has been updated");
        }
    }
}
