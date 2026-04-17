using System;
using System.Collections.Generic;
using System.Text;
using Type = PokeSharp.Models.Attaques.Type;
using PokeSharp.Models.Attaques;

namespace PokeSharp.Models.Pokemons
{
    public class PokemonFeu : Pokemon
    {
        public PokemonFeu(string nomPokemon, int pvMax, int niveau, Type feu, List<Attaque> attaques) : base(nomPokemon, pvMax, niveau, feu, attaques)
        {
        }

        public override void Attaquer(Pokemon cible, Attaque attaque)
        {
            throw new NotImplementedException();
        }
    }
}
