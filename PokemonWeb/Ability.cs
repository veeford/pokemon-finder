﻿using System.Globalization;

namespace PokemonWeb
{
    public class Ability
    {
        int id;
        string name;
        string description;

        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public string Description { get { return description; } }

        public Ability(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

        public override string ToString()
        {
            return $"Ability {id}\nName: {name}\nDescription: {description}";
        }
    }
}
