using System.Collections.Generic;

namespace WinFormsApp
{
    public class UserModelForm
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<CategoryModelForm> Categories { get; set; }
        public List<NoteModelForm> Notes { get; set; }

    }

    public class CategoryModelForm
    {
        public string Name { get; set; }
        public string UserNameId { get; set; }
        public int Id { get; set; }
        public List<NoteModelForm> Notes { get; set; }
    }

    public class NoteModelForm
    {
        public string IdName { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public byte[] ImgData { get; set; }
        public int? UserModelId { get; set; }
        public List<CategoryModelForm> Categories { get; set; }
    }
}
