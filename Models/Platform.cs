using System.ComponentModel.DataAnnotations;

namespace ExampleGraphQL.Models
{
    public class Platform
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string LicenseKey { get; set; }
    }
}
