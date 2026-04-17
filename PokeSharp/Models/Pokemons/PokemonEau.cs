using System;
using System.Collections.Generic;
using System.Text;
using Type = PokeSharp.Models.Attaques.Type;
using PokeSharp.Models.Attaques;

namespace PokeSharp.Models.Pokemons
{
    public class PokemonEau : Pokemon
    {
        public PokemonEau(string nomPokemon, int pvMax, int niveau, Type eau, List<Attaque> attaques) : base(nomPokemon, pvMax, niveau, eau, attaques)
        {
        }
        public override void Attaquer(Pokemon cible, Attaque attaque)
        {
            throw new NotImplementedException();
        }
    }
}
