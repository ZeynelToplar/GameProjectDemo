using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    class GameSaleManager : IGameSaleService
    {
        

        public void Sale(Gamer gamer, Game game, Campaigns campaign)
        {
            double newPrice = game.GamePrice - (game.GamePrice * (campaign.CampaignDiscount / 100));
            Console.WriteLine(game.GameName + " oyunu " + gamer.FirstName+ " " + gamer.LastName + " kişisine satıldı.");
            Console.WriteLine("Oyunun indirimli Fiyatı : " + newPrice + " TL");
            Console.WriteLine("Uygulanan İndirim fiyatı : " + game.GamePrice * (campaign.CampaignDiscount/100) + " TL");

        }
    }
}
