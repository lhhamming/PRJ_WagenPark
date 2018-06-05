using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WagenPark.Classes;
using WagenPark.Models;

namespace WagenPark.App_Start
{
    public class Wagenpark_Initialiser
    {
        public class wagenParkInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<WagenParkContext>
        {
            protected override void Seed(WagenParkContext context)
        {
            var auto = new List<Auto>
            {
                new Auto
                {
                    Kenteken = "GB420D",
                    Merk = "Saab",
                    Type = "95"
                }
            };
                auto.ForEach(a => context.Autoes.Add(a));
                context.SaveChanges();

                var dealer = new List<Dealer>
           {
               new Dealer
               {
                   dealerNr = "34",
                   naam = "Vroegop"
               },
               new Dealer
               {
                   dealerNr = "73",
                   naam = "Bosmans"
               }
           };

                var onderhoud = new List<Onderhoud>
                {
                    new Onderhoud
                    {
                        Onderhoudsdatum = "100316",
                        Kosten = "345",
                        AutoKenteken = "GB420D",
                        werkplaats_werkplaatsnr = "2"
                    }
                };

                var werkplaats = new List<Werkplaats>
                {
                    new Werkplaats
                    {
                        werkplaatsnr = "1",
                        naam = "Quick"
                    }
                };
        }

        }
    }
}