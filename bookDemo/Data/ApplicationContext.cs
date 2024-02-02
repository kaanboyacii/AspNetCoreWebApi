using bookDemo.Models;

namespace bookDemo.Data
{
    public static class ApplicationContext
    {
        public static List<Book> Books { get; set; }
        static ApplicationContext()
        {
            Books= new List<Book>()
            {
                new Book() { Id=1, Title="Suç ve Ceza",Price=50},
                new Book() { Id=2, Title="Panama Savaşları",Price=50},
                new Book() { Id=3, Title="Yazılım Öğren",Price=50}
            };
        }
    }
}
