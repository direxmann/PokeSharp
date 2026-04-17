using PokeSharp.Models.Attaques;
using System;
using System.Collections.Generic;
using System.Text;
using Type = PokeSharp.Models.Attaques.Type;


namespace PokeSharp.Models.Pokemons
{
    public abstract class Pokemon
    {
        private string nomPokemon;
        private int pvMax;
        private int pvActuel;
        private int niveau;
        private Type type;
        private List<Attaque> attaques;

        public Pokemon(string nomPokemon, int pvMax, int niveau, Type type)
        {
            this.nomPokemon = nomPokemon;
            this.pvMax = pvMax;
            this.pvActuel = pvMax;
            this.niveau = niveau;
            this.type = type;
            this.attaques = new List<Attaque>();
        }

        public abstract void Attaquer(Pokemon cible, Attaque attaque);
        public bool EstKO()
        {
            throw new NotImplementedException();
        }
    }
}