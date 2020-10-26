using Microsoft.EntityFrameworkCore;
using System;

namespace Infra.Data
{
    public class GerenciadorDbContext : DbContext
    {
        public GerenciadorDbContext(DbContextOptions<GerenciadorDbContext> options) : base(options) { }
    }
}
