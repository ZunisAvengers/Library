﻿using System;

namespace LibraryAspNetCore.ViewModels
{
    public class BookInLibrariesIdViewModel
    {
        public Guid LibraryId { get; set; }
        public int TotalQuantity { get; set; }
        public int CurrentQuantity { get; set; }
    }
}