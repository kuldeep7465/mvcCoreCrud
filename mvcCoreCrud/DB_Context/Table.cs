﻿using System;
using System.Collections.Generic;

#nullable disable

namespace mvcCoreCrud.DB_Context
{
    public partial class Table
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
