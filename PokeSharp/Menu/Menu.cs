using System;
using System.Collections.Generic;
using System.Text;

namespace PokeSharp.Menu
{
    public class Menu
    {
        private string titre;
        private int largeur;
        private int hauteur;

        public Menu(string titre, int largeur, int hauteur)
        {
            this.titre = titre;
            this.largeur = largeur;
            this.hauteur = hauteur;
        }

        public void AfficherMenuCombat()
        {
            throw new NotImplementedException();
        }
        public void AfficherMenuPrincipal()
        {
            throw new NotImplementedException();
        }
        public void AfficherAttaques()
        {
            throw new NotImplementedException();
        }
        public void DemanderChoix()
        {
            throw new NotImplementedException();
        }
    }
}
