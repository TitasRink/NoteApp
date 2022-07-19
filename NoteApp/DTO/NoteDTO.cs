namespace NoteApp.Repository.DTO
{
    public class NoteDTO
    {
        public string IdName { get; set; }
        public string Name { get; set; }    
        public string Message { get; set; }
        public string OldName { get; set; }
        public byte[] ImgUrl { get; set; }
    }
}
