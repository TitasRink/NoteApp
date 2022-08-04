using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Repository.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public byte[] Byte { get; set; }
        [ForeignKey("NoteModel")]
        public int? NoteModelId{ get; set; }

        //public Image(byte[] @byte, int noteModelid)
        //{
        //    NoteModelId = noteModelid;
        //    Byte = @byte;
        //}
    }
}
