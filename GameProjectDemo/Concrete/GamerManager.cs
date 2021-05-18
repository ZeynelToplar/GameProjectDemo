using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        
        public GamerManager()
        {
               
        }
        private IVerificationService verificationService;

        public GamerManager(IVerificationService verificationService)
        {
            this.verificationService = verificationService;
        }

        public void Add(Gamer gamer)
        {
            if (verificationService.CheckİfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + gamer.LastName + " adlı oyuncu eklendi.");
            }
            else
            {
                Console.WriteLine(" Bilgilerinizi tekrar kontrol ediniz.");
            }
                
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName + " adlı oyuncu silindi.");

        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName + " adlı oyuncunun bilgileri güncellendi.");

        }
    }
}
