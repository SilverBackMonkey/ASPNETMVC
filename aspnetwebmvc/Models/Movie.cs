using System.ComponentModel.DataAnnotations;

namespace aspnetwebmvc.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }

        public string? Gender { get; set; }

        public decimal? Price { get; set; }

    }
}
