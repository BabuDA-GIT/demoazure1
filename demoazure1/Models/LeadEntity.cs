using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace demoazure1.Models
{
    public class LeadEntity
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date")]
        [Required]
        
        public DateTime LeadDate { get; set; }

        [DisplayName("Lead Source")]
        [Required]
        [StringLength(50)]
        public string LeadSource { get; set; }
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
       
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
        ErrorMessage = "Entered phone format is not valid.")]
        public string mobile { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

    }
}
