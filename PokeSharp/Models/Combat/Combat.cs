using System;
using System.Collections.Generic;
using System.Text;
using PokeSharp.Models.Dresseurs;

namespace PokeSharp.Models.Combat
{
    public class Combat
    {
        private Dresseur dresseur1;
        private Dresseur dresseur2;
        private int tourActuel;
        private bool estTermine;

        public Combat(Dresseur dresseur1, Dresseur dresseur2)
        {
            this.dresseur1 = dresseur1;
            this.dresseur2 = dresseur2;
            this.tourActuel = 1;
            this.estTermine = false;
        }
        public void Demarrer()
        {
            throw new NotImplementedException();
        }
        public void JouerTour()
        {
            throw new NotImplementedException();
        } public void DeterminerVainqueur()
        {
            throw new NotImplementedException();
        }
    }
}
