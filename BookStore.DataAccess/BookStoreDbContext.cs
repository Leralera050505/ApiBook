using BookStore.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;//Нужно добавить пакет

namespace BookStore.DataAccess
{
    //Создаем класс Контекст для взаимодействия с БД
    public class BookStoreDbContext : DbContext
    {
        //Конструктор <Опции>  
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
            //Унаследование от базового конструктора
            : base(options)
        {

        }

        public DbSet<BookEntity> Books { get; set; }
        
        
    }
}
