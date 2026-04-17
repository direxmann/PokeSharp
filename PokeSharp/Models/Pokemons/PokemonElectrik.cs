using System;
using System.Collections.Generic;
using System.Text;
using Type = PokeSharp.Models.Attaques.Type;
using PokeSharp.Models.Attaques;

namespace PokeSharp.Models.Pokemons
{
    public class PokemonElectrik : Pokemon
    {
        public PokemonElectrik(string nomPokemon, int pvMax, int niveau, Type electrik, List<Attaque> attaques) : base(nomPokemon, pvMax, niveau, electrik, attaques)
        {
        }
        public override void Attaquer(Pokemon cible, Attaque attaque)
        {
            throw new NotImplementedException();
        }
    }
}
