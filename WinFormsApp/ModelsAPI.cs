namespace WinFormsApp
{
    public class UserModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class CategoryModel
    {
        public string IdName { get; set; }
        public string Name { get; set; }
    }

    public class NoteModel
    {
        public string IdName { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
    }
}
