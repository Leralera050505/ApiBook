using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStrore.Core.Models
{
    public class Book
    {
        //Создание константы (переменная, мравная 250)
        public const int MAX_TITLE_LENGTH = 250;

        private Book(Guid id, string title, string description, decimal price) //Конструктор приватный
        {
            //Присвоение переменных
            Id = id;
            Title = title;
            Description = description;
            Price = price;
        }



        // Определение переменных (БД)
        public Guid Id { get;  }
        public string Title { get; } = string.Empty;
        public string Description { get; } = string.Empty;
        public decimal Price { get; }


        //Возваращать данные ()
        public static (Book Book, string Error) Create(Guid id, string title, string description, decimal price)
        {
            //Создаем ошибку, если не пройдет валидация
            var error = string.Empty;

            //Валидация (Если больше заголовок чем максимально допустимая длина или пустой = вывод ошибки)
            if (string.IsNullOrEmpty(title) || title.Length > MAX_TITLE_LENGTH)
            {
                error = "Название пустое или больше количества допустимого значения (250 символов)";
            }


            //Создаеи книгу (запись)
            var book = new Book(id, title, description, price);
           
            //Возваращаем всю книгу 
            return (book, error);
        }
    }
}
