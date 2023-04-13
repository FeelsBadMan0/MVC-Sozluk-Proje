using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrate
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        [StringLength(50)]
        public string AdminUserName { get; set; }
        [StringLength(50)]
        public string AdminPassword { get; set; }
        [StringLength(1)]
        public string AdminRole { get; set; }
    }
}
