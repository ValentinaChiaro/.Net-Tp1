﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.Shared
{
    public class SuperHero
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = String.Empty;

        public string LastName { get; set; } = string.Empty;
        public string HeroName { get; set; } = string.Empty;
        public Comic? Comic { get; set; }   //? makes it nullable
        public int ComicId { get; set; }

    }
}
