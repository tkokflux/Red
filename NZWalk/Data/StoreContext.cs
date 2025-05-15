using System;
using Microsoft.EntityFrameworkCore;
using NZWalk.Entities;

namespace NZWalk.Data;

public class StoreContext(DbContextOptions options) : DbContext(options)
{
    public required DbSet<Product> Products { get; set; }
}
