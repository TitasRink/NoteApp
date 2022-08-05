using System.ComponentModel.DataAnnotations.Schema;

namespace NoteApp.Repository.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public byte[] Byte { get; set; }
        [ForeignKey("NoteModel")]
        public int? NoteModelId{ get; set; }

        public Image(byte[] bytes, int noteModelid)
        {
            Byte = bytes;
            NoteModelId = noteModelid;
        }
        public Image()
        {

        }
    }
}
