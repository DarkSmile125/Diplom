﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Diplom.Models
{
    public class Profiles 
    {
        [Key]
        public int ProfileID { get; set; }
        public string ProfileName { get; set; }
    }
}