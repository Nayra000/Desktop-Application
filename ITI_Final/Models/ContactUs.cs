﻿using System;
using System.Collections.Generic;

namespace ITI_Final.Models
{
    public partial class ContactUs
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
    }
}
