using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WagenPark.Classes;

namespace WagenPark.App_Start
{
    public class Wagenpark_Initialiser
    {
        public void FillDatabase()
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
        }
    }
}