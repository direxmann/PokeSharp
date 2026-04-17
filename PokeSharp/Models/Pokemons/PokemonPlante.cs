using System;
using System.Collections.Generic;
using System.Text;
using Type = PokeSharp.Models.Attaques.Type;
using PokeSharp.Models.Attaques;

namespace PokeSharp.Models.Pokemons
{
    public class PokemonPlante : Pokemon
    {
        public PokemonPlante(string nomPokemon, int pvMax, int niveau, Type plante, <Attaque> attaques) : base(nomPokemon, pvMax, niveau, plante, attaques)
        {
        }
        public override void Attaquer(Pokemon cible, Attaque attaque)
        {
            throw new NotImplementedException();
        }
    }
}
