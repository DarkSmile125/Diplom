﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Diplom.Models
{
    public class ProfilesContext : DbContext
    {
        public DbSet<Profiles> Profiles { get; set; }
    }
}