using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAspNetCore.ViewModels
{
    public class AddBookViewModel
    {
        public string Name { get; set; }
        public Guid? AuthorsId { get; set; }
        public string AuthorsName { get; set; }
        public Guid PublishingHouseId { get; set; }
        public Guid SubjectId { get; set; }
        public string ISBN { get; set; }
        public IFormFile Image { get; set; }
        public DateTime YearOfPublishing { get; set; }
    }
}
