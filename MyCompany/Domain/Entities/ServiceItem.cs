using System.ComponentModel.DataAnnotations;


namespace MyCompany.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Fill in the name of the service")]
        [Display(Name = "Name of the service")]
        public override string Title { get; set; }

        [Display(Name = "Brief description of the service")]
        public override string Subtitle { get; set; }

        [Display(Name = "Full description of the service")]
        public override string Text { get; set; }
    }
}
