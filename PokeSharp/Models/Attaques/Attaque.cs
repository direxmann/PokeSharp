using System;
using System.Collections.Generic;
using System.Text;

namespace PokeSharp.Models.Attaques
{
    public class Attaque
    {
        private string nomAttaque;
        private int puissance;
        private Type nomType;

        public Attaque(string nomAttaque, int puissance, Type nomType)
        {
            this.nomAttaque = nomAttaque;
            this.puissance = puissance;
            this.nomType = nomType;
        }

        public int CalculerDegats()
        {
            throw new NotImplementedException();
        }
    }
}
