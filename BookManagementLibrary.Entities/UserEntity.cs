using System;

namespace BookManagementLibrary.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }
        public string password { get; set; }
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string CrateDate { get; set; }
        public int UserId { get; set; }
    }
}
