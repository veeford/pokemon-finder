using System.Globalization;
using System.Text.Json.Serialization;

namespace CustomPokemonControl
{
    public class Ability
    {
        int id;
        string name;
        string description;

        [JsonPropertyName("id")]
        public int Id { get { return id; } }
        [JsonPropertyName("name")]
        public string Name { get { return name; } }
        [JsonPropertyName("description")]
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
