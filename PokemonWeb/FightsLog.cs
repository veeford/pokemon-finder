using System;
using System.Collections.Generic;

namespace PokemonWeb;

public partial class FightsLog
{
    public int FightId { get; set; }

    public DateTime FightDatetime { get; set; }

    public int WinnerId { get; set; }

    public int LoserId { get; set; }

    public int? RoundsCount { get; set; }
}
