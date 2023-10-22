using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mis_421_assignment_3.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DisplayName("IMDB Hyperlink")]
        public string IMDBHyperlink { get; set; }
        public string Genre { get; set; }

        [DisplayName("Year of Release")]
        public int YearOfRelease { get; set; }
        [DataType(DataType.Upload)]
        [DisplayName("Poster or Media")]
        public byte[]? Poster { get; set; }

    }
}
