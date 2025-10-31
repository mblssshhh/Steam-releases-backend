using System.ComponentModel.DataAnnotations;

namespace SteamReleasesApi.Models;

public class Game
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public DateTime ReleaseDate { get; set; }

    public List<string> Genres { get; set; } = [];

    public int Followers { get; set; }

    [Required]
    public string StoreUrl { get; set; } = string.Empty;

    public string PosterUrl { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public List<string> Platforms { get; set; } = [];

    public DateTime CollectedAt { get; set; } = DateTime.UtcNow;
}