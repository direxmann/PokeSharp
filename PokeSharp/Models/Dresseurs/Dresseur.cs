using PokeSharp.Models.Pokemons;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeSharp.Models.Dresseurs
{
    public class Dresseur
    {
        private string nomDresseur;
        private Equipe equipe;
        private Pokemon pokemonActif;

        public Dresseur(string nomDresseur)
        {
            this.nomDresseur = nomDresseur;
            this.equipe = new Equipe(nomDresseur);
        }

        public void ChoisirPokemonActif(Pokemon pokemon)
        {
            throw new NotImplementedException();
        }
        public void ChangerPokemon(Pokemon pokemon)
        {
            throw new NotImplementedException();
        }
    }
}
