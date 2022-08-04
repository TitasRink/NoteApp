using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoteApp.Repository.Entities
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
     
        public List<NoteModel> Notes { get; set; }

        public CategoryModel(string name)
        {
            Name = name;
            Notes = new List<NoteModel>();
        }
    }
}
