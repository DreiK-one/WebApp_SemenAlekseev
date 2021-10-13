using System.ComponentModel.DataAnnotations;


namespace MyCompany.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Page name (title)")]
        public override string Title { get; set; } = "Information page";

        [Display(Name = "Page Content")]
        public override string Text { get; set; } = "The content is filled in by the administrator";
    }
}
