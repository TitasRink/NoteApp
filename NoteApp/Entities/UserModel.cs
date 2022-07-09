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
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Password { get; set; }
        public CategoryModel Categorie { get; set; }
        public List<NoteModel> Notes { get; set; }

        public UserModel(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}
