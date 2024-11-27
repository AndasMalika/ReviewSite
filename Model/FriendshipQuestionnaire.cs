using System.ComponentModel.DataAnnotations;

namespace ReviewSite.Model
{
    public class FriendshipQuestionnaire
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [MaxLength(100)]
        public string Instagram { get; set; }

        [MaxLength(100)]
        public string Telegram { get; set; }

        [MaxLength(100)]
        public string Discord { get; set; }

        [Phone]
        public string Phone { get; set; }

        [MaxLength(1000)]
        public string DescribeYourself { get; set; }

        [MaxLength(1000)]
        public string FirstImpression { get; set; }
    }
}
