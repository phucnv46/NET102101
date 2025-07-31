using System;
using System.Collections.Generic;

namespace OnTapEFCore.Models;

public partial class Game
{
    public int GameId { get; set; }

    public string Title { get; set; } = null!;

    public string? Genre { get; set; }

    public int? ReleaseYear { get; set; }

    public string? Developer { get; set; }
}
