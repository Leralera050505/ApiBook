using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//В этом классе содержание набора свойств для БД
namespace BookStore.DataAccess.Entites
{
    public class BookEntity
    {
        // Определение переменных (БД)
        public Guid Id { get; set; } //Set для взаимодействия с полями из любой точки программы
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
