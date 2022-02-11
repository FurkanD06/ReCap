using ReCap.Concrete;
using ReCap.Entities;
using System;

namespace ReCap
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.NationalityId = "10765310856";
            gamer1.FirstName = "Furkan";
            gamer1.LastName = "Demir";
            gamer1.DateOfBirth = "2005.5.14";

            GamerManager gamerManager = new GamerManager();
            gamerManager.Save(gamer1);

            Game game1 = new Game();
            game1.GameName = "Minecraft";
            game1.UnitPrice = 80;

            Ofter ofter1 = new Ofter();
            ofter1.CampaignName = "%20 discount";

            GameManager gameManager = new GameManager();
            gameManager.Sales(gamer1);

            OfterManager ofterManager = new OfterManager();
            ofterManager.New(ofter1);
            
            
        }
    }
}
