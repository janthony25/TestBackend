using System.ComponentModel.DataAnnotations;

namespace TestBackend.Models
{
    public class CustomerModel
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string CarModel { get; set; }
        [Required]
        public string CarMake { get; set; }
        [Required]
        public string CarRego { get; set; }

        public ICollection<IssueModel> Issue { get; set; }

    }
}
