using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DNTFrameworkCore.Application.Models;
using DNTFrameworkCore.Localization;
using DNTFrameworkCore.TestWebApp.Domain.Identity;

namespace DNTFrameworkCore.TestWebApp.Application.Academy.Models
{
    [LocalizationResource(Name = "SharedResource", Location = "DNTFrameworkCore.TestWebApp")]

    public class AcademyModel : MasterModel, IValidatableObject
    {

        [Required(ErrorMessage = "فید {0} مورد نیاز است")]
        [Display(Name = "نام آموزشگاه")]
        public string AcademyName { get; set; }

        [Required(ErrorMessage = "فید {0} مورد نیاز است")]
        [Display(Name = "تلفن آموزشگاه")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "فید {0} مورد نیاز است")]
        [Display(Name = "آدرس آموزشگاه")]
        public string Address { get; set; }


        [Required(ErrorMessage = "فید {0} مورد نیاز است")]
        [Display(Name = "توضیح  مختصر")]
        public string Description { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }



        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (AcademyName == "نام آموزشگاه")
            {
                yield return new ValidationResult("IValidatableObject Message", new[] { nameof(AcademyName) });
            }
        }
    }
}
