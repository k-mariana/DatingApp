﻿using DatingApp.API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace DatingApp.API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AppUser> Users { get; set; }
}
