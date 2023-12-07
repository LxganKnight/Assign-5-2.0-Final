using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace Assign_5_2._0.Models
{
    public class MusicGenreViewModel
    {
        public List<Music>? Musics { get; set; }
        public SelectList? Genres { get; set; }
        public SelectList? Performers { get; set; }
        public string? MusicGenre { get; set; }
        public string? MusicPerformers { get; set; }
    }
}
