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
        Active
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
        Ranger
    }

    public enum EducationLevel
    {
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
        Other
    }

    public class SignUpModel
    {
        [Required(ErrorMessage = "لطفاً نام و نام خانوادگی را وارد کنید")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "لطفاً نام پدر را وارد کنید")]
        public string? FatherName { get; set; }

        [Required(ErrorMessage = "لطفاً کد ملی ۱۰ رقمی خود را وارد کنید")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "کد ملی باید ۱۰ رقمی باشد")]
        public string? NationalID { get; set; }

        [Required(ErrorMessage = "لطفاً تعداد فرزندان را وارد کنید")]
        public int? NumberOfChildren { get; set; }

        [Required(ErrorMessage = "لطفاً تاریخ تولد را وارد کنید")]
        [DataType(DataType.Date, ErrorMessage = "فرمت تاریخ وارد شده صحیح نمی‌باشد")]
        public DateTime? BirthDate { get; set; }

        [Required(ErrorMessage = "لطفاً وضعیت تاهل را انتخاب کنید")]
        public MaritalStatus? MaritalStatus { get; set; }

        [Required(ErrorMessage = "لطفاً نوع بسیجی را انتخاب کنید")]
        public BasijStatus? BasijStatus { get; set; }

        [Required(ErrorMessage = "لطفاً سطح تحصیلات را انتخاب کنید")]
        public EducationLevel? EducationLevel { get; set; }

        [Required(ErrorMessage = "لطفاً آدرس محل سکونت خود را وارد کنید")]
        public string? HomeAddress { get; set; }

        [Required(ErrorMessage = "لطفاً شماره تلفن منزل را وارد کنید")]
        [RegularExpression(@"^\d+$", ErrorMessage = "شماره تلفن منزل باید فقط شامل اعداد باشد")]
        public string? HomePhoneNumber { get; set; }

        [Required(ErrorMessage = "لطفاً شماره موبایل خود را وارد کنید")]
        [RegularExpression(@"^09\d{9}$", ErrorMessage = "شماره موبایل باید با 09 شروع شود و ۱۱ رقم داشته باشد.")]
        public string? MobileNumber { get; set; }

        [Required(ErrorMessage = "لطفاً رشته تحصیلی خود را وارد کنید")]
        public string? FieldOfStudy { get; set; }

        [Required(ErrorMessage = "لطفاً محل صدور شناسنامه را وارد کنید")]
        public string? PlaceOfIssue { get; set; }

        [Required(ErrorMessage = "لطفاً محل تولد را وارد کنید")]
        public string? PlaceOfBirth { get; set; }

        [Required(ErrorMessage = "لطفاً وضعیت ایثارگری را انتخاب کنید")]
        public VeteranStatus? VeteranStatus { get; set; }

        [Required(ErrorMessage = "لطفاً مدت زمان کسری خدمت خود را وارد کنید")]
        public int? ServiceReductionDuration { get; set; }

        [Display(Name = "محل الصاق عکس")]
        public IFormFile? Photo { get; set; }
    }
}
