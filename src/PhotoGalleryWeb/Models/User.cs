using System;

namespace PhotoGalleryWeb.Models
{
    public class User : IEntityBase
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public bool IsLocked { get; set; }
        public DateTime DateCreated { get; set; }
        
        public virtual ICollection<UserRole> UserRoles { get; set; }
            = new List<UserRole>();
    }
}
