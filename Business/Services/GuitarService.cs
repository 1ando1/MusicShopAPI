using AutoMapper;
using Business.DTOs;
using Business.Interfaces;
using Data;
using Microsoft.EntityFrameworkCore;
using Music_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class GuitarService : IGuitarService
    {
        private readonly MusicShopDbContext context;
        private readonly IMapper mapper;

        public GuitarService(MusicShopDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IEnumerable<GuitarDTO> ShowAll()
        {
            return mapper.Map<IEnumerable<GuitarDTO>>(context.Guitars.Include(x => x.ExtraProduct).ToList());
        }

        public async void Add(GuitarDTO guitar)
        {
            context.Guitars.Add(mapper.Map<Guitar>(guitar));
            await context.SaveChangesAsync();
        }

        public async void Delete(int id)
        {
            var guitar = await context.Guitars.FindAsync(id);

            if (guitar == null) return;

            context.Guitars.Remove(guitar);
            await context.SaveChangesAsync();
        }

        public async void Edit(GuitarDTO guitar)
        {
            if (await context.Guitars.AsNoTracking().FirstOrDefaultAsync(g => g.Id == guitar.Id) == null) return;

            context.Guitars.Update(mapper.Map<Guitar>(guitar));
            await context.SaveChangesAsync();
        }
    }
}
