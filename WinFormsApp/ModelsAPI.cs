namespace WinFormsApp
{
    public class UserModelForm
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class CategoryModelForm
    {
        public string Name { get; set; }
        public string UserNameId { get; set; }
    }

    public class NoteModelForm
    {
        public string IdName { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
    }
}
