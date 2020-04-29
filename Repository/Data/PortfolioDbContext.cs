using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
  public  class PortfolioDbContext:DbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options) { }
        public DbSet<Caption> Captions { get; set; }
        public DbSet<CaptionIcon> CaptionIcons { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<EduExp> EduExps { get; set; }
        public DbSet<Info> Infos { get; set; }
        public DbSet<TeamIcon> TeamIcons { get; set; }
        public DbSet<MyPrice> MyPrices { get; set; }
        public DbSet<PersonPhoto> PersonPhotos{ get; set; }
        public DbSet<PortfolioIcon> PortfolioIcons { get; set; }
        public DbSet<PortfolioLevel> PortfolioLevels { get; set; }
        public DbSet<PortfolioPhoto>PortfolioPhotos { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SkillValue> SkillValues { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
