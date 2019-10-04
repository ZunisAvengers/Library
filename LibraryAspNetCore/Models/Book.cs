using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAspNetCore.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
        public Guid AuthorId { get; set; }
        public PublishingHouse PublishingHouse { get; set; }
        public Guid PublishingHouseId { get; set; }
        public DateTime YearOfPublishing { get; set; }
        public Subject Subject { get; set; }
        public Guid SubjectId { get; set; }
        public string ISBN { get; set; }
        public string ImagePath { get; set; }
        public string ImageType { get; set; }
        public List<BookInLibrary> BookInLibrares { get; set; }
        public Book()
        {
            BookInLibrares = new List<BookInLibrary>();
        }
    }
}
