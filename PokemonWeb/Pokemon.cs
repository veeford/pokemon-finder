using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonWeb
{
    public class Pokemon
    {
        int id;
        string name;
        int hp;
        int attack;
        List<Ability> abilities;
        string? previewLink;
        string? fullLink;
        //Bitmap previewImage;
        //Bitmap fullImage;

        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public int HP { get { return hp; } }
        public int Attack { get { return attack;} }
        public List<Ability> Abilities { get { return abilities; } }
        public string? PreviewLink { get { return previewLink; } }
        public string? FullLink { get { return fullLink; } }
        //public Bitmap FullImage { get { return fullImage; } }
        //public Bitmap PreviewImage { get { return previewImage; } }

        public Pokemon(int id, string name, int hp, int attack, List<Ability> abilities, string previewLink, string fullLink)
        {
            this.id = id;
            this.name = name;
            this.hp = hp;
            this.attack = attack;
            this.abilities = abilities;
            this.previewLink = previewLink;
            this.fullLink = fullLink;
        }

        public override string ToString()
        {
            var result = $"Pokemon {id}\nName: {name}\nHP: {hp}\nAttack: {attack}\nAbilities:\n";
            foreach (var ability in abilities)
            {
                result += $"\tAbility {ability.Id}\n\tName: {ability.Name}\n\tDescription: {ability.Description}\n";
            }
            result += $"Preview link: {previewLink ?? "Not present"}\nFull link: {fullLink ?? "Not present"}\n";
            return result;
        }
    }
}
