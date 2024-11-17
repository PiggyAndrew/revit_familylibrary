using System.ComponentModel.DataAnnotations;

namespace Revit.Shared.Entity.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}