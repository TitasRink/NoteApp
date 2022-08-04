﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoteApp.Repository.Entities
{
    public class NoteModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public string Message { get; set; }

        public string ImgPath{ get; set; }
        public byte[] ImgUrl { get; set; }
        [ForeignKey("CategoryModel")]
        public int CategoryModelId { get; set; }

        [ForeignKey("UserModel")]
        public int? UserModelId { get; set; }
        public List<CategoryModel> Categories{ get; set; }

        public NoteModel(string name, string message)
        {
            Name = name;
            Message = message;
            Categories = new List<CategoryModel>();
        }

        public NoteModel(string name, string message, int userModelId)
        {
            Name = name;
            Message=message;
            UserModelId = userModelId;
            Categories = new List<CategoryModel>();
        }
        public NoteModel(string name)
        {
            Name = name;
        }
        public NoteModel()
        {

        }
    }
}
