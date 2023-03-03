using System.ComponentModel.DataAnnotations;

namespace HomeTask1
{
    public class Phone
    {
        public int PhoneId { get; set; }

        [Required, MaxLength(20)]
        public string BrandName { get; set; }

        [MaxLength(30)]
        public string PhoneModel { get; set; }
    }
}