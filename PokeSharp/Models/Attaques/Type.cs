using System;
using System.Collections.Generic;
using System.Text;

namespace PokeSharp.Models.Attaques
{
    public class Type
    {
        private string nomType;
        private string faiblesse;
        private string resistance;

        public Type(string nomType, string faiblesse, string resistance)
        {
            this.nomType = nomType;
            this.faiblesse = faiblesse;
            this.resistance = resistance;
        }

        public double GetMultiplicateur(Type typeCible)
        {
            throw new NotImplementedException();
        }
    }
}
