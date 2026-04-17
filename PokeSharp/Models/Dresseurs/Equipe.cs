using PokeSharp.Models.Pokemons;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeSharp.Models.Dresseurs
{
    public class Equipe
    {
        private string nomDresseur;
        private List<Pokemon> pokemons;
        private int tailleMax = 6;

        public Equipe(string nomDresseur)
        {
            this.nomDresseur = nomDresseur;
            this.pokemons = new List<Pokemon>();
        }

        public void AjouterPokemon(Pokemon pokemon)
        {
            throw new NotImplementedException();
        }
        public void RetirerPokemon(Pokemon pokemon)
        {
            throw new NotImplementedException();
        }
        public void AfficherEquipe()
        {
            throw new NotImplementedException();
        }
    }
}
