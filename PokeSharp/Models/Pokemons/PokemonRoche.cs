using System;
using System.Collections.Generic;
using System.Text;
using Type = PokeSharp.Models.Attaques.Type;
using PokeSharp.Models.Attaques;

namespace PokeSharp.Models.Pokemons
{
    public class PokemonRoche : Pokemon
    {
        public PokemonRoche(string nomPokemon, int pvMax, int niveau, Type roche, List<Attaque> attaques) : base(nomPokemon, pvMax, niveau, roche, attaques)
        {
        }
        public override void Attaquer(Pokemon cible, Attaque attaque)
        {
            throw new NotImplementedException();
        }
    }
}
