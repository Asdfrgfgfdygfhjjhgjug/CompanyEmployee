namespace CompanyEmployee.Services.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CompanyRequestModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Founded")]
        public DateTime Founded { get; set; }

        [Required]
        public string Information { get; set; }
    }
}
