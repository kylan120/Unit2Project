using System.ComponentModel.DataAnnotations;

namespace Unit2Project.Models
{
    public class Comic
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a Company Name.")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Please enter an issue number.")]
        public int IssueNo { get; set; }
        public Issue Issue { get; set; }
    }
}
