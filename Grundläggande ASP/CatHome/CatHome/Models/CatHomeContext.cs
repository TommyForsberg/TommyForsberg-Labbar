using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AutoMapper;
using System.Linq;

namespace CatHome.Models.Entities
{
    public partial class CatHomeContext : DbContext
    {


        public CatHomeContext(DbContextOptions<CatHomeContext> options) : base(options)
        {

        }
        internal void AddCatToDB(CreateCatVM model)
        {
            var newCat = Mapper.Map<Cat>(model);
            Cat.Add(newCat);
            SaveChanges();
        }

        internal CatsIndexVM[] GetAllCats()
        {
            return Cat
                .Select(cat => new CatsIndexVM
                {
                    Name = cat.Name,
                    IsAggressive = cat.Anger > 7
                }).ToArray();
        }

    }
}