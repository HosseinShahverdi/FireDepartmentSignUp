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
    [Display(Name = "ندارم")]
    None,

    [Display(Name = "عادی")]
    Normal,

    [Display(Name = "فعال")]
    Active,

    
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

        [Required]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        [Required]
        public MaritalStatus? MaritalStatus { get; set; }

        [Required]
        public BasijStatus? BasijStatus { get; set; }

        [Required]
        public EducationLevel? EducationLevel { get; set; }

        [Required]
        public string? HomeAddress { get; set; }

        [Required]
        public string? HomePhoneNumber { get; set; }

        [Required]
        public string? MobileNumber { get; set; }

        [Required]
        public string? FieldOfStudy { get; set; }

        [Required]
        public string? PlaceOfIssue { get; set; }

        [Required]
        public string? PlaceOfBirth { get; set; }

        
        [Required]
        public VeteranStatus? VeteranStatus { get; set; }

        
        [Required]
        public int? ServiceReductionDuration { get; set; }

        [Display(Name = "محل الصاق عکس")]
        public IFormFile? Photo { get; set; }


    }
}
