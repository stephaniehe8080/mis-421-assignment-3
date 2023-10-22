using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mis_421_assignment_3.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        [DisplayName("IMDB Hyperlink")]
        public string IMDBHyperlink { get; set; }

        [DataType(DataType.Upload)]
        [DisplayName("Photo of the Actor")]
        public byte[]? Photo { get; set; }
    }
}
