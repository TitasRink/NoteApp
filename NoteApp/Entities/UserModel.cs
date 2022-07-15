using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NoteApp.Repository.Entities
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string LoginName { get; set; }
        public string Token { get; set; }
        public CategoryModel Categorie { get; set; }
        public List<NoteModel> Notes { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public  UserModel()
        {
        }

        public UserModel(string loginName, byte[] passwordHash, byte[] passwordSalt)
        {
            LoginName = loginName;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;

            Notes = new List<NoteModel>();
        }
    }
}
