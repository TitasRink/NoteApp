using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;

namespace NoteApp.Repository.Entities
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string LoginName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LoginPassword { get; set; }
        public string Token { get; set; }
        public CategoryModel Categorie { get; set; }
        public List<NoteModel> Notes { get; set; }

        public  UserModel()
        {
        }
        public UserModel(string loginName, string loginPassword)
        {
            LoginName = loginName;
            LoginPassword = loginPassword;
        }
    }
}
