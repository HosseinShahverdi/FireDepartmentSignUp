using System;
using System.ComponentModel.DataAnnotations;




namespace fDSignUp.Models
{

    public enum MaritalStatus
{
    [Display(Name = "مجرد")]
    Single,

    [Display(Name = "متاهل")]
    Married
}

public enum BasijStatus
{
    [Display(Name = "عادی")]
    Normal,

    [Display(Name = "فعال")]
    Active,

    [Display(Name = "ندارم")]
    None,
}
public enum VeteranStatus
{
    [Display(Name = "ندارم")]
    None,

    [Display(Name = "فرزند شهید")]
    Martyred,

    [Display(Name = "فرزند جانباز")]
    Stuntman,
    [Display(Name = "فرزند رزمنده")]
    Ranger,
}

public enum EducationLevel{
    [Display(Name = "دیپلم")]
    Diploma,
    [Display(Name = "کاردانی")]
    Associate,
    [Display(Name = "کارشناسی")]
    Bachelor,
    [Display(Name = "کارشناسی ارشد")]
    Master,
    [Display(Name = "دکترا")]
    Doctorate,
    [Display(Name = "دیگر")]
    Other,
}
    public class SignUpModel
    {
        [Required]
        public string? FullName { get; set; }

        [Required]
        public string? FatherName { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "کد ملی 10 رقمی می‌باشد")]
        public string? NationalID { get; set; }

        [Required]
        public int? NumberOfChildren { get; set; }

        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        [Required]
        public MaritalStatus? MaritalStatus { get; set; }

        [Required]
        public BasijStatus? BasijStatus { get; set; }

        public EducationLevel? EducationLevel { get; set; }

        public string? HomeAddress { get; set; }

        public string? HomePhoneNumber { get; set; }

        public string? MobileNumber { get; set; }

        public string? FieldOfStudy { get; set; }
        public string? PlaceOfIssue { get; set; }
        public string? PlaceOfBirth { get; set; }

        public VeteranStatus? VeteranStatus { get; set; }

        public int? ServiceReductionDuration { get; set; }

        [Display(Name = "محل الصاق عکس")]
        public IFormFile? Photo { get; set; }


    }
}
