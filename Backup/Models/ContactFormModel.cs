using System.ComponentModel.DataAnnotations;

namespace SITEK.Models
{
    public class ContactFormModel
    {
        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "name1")]
        public string FromName { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "email2")]
        [EmailAddress(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "ContactEmailFormat")]
        public string FromEmail { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "ContactMessageVal")]
        public string Message { get; set; }
    }
}