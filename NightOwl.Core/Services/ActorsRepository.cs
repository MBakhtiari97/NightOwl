using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NightOwl.Core.Services.Interfaces;
using NightOwl.DataLayer.Context;
using NightOwl.DataLayer.Entities;

namespace NightOwl.Core.Services
{
    public class ActorsRepository : IActorsRepository
    {
        private NightOwlContext _context;

        public ActorsRepository(NightOwlContext context)
        {
            _context = context;
        }

        public void AddNewActor(Actors actorDetails)
        {
            _context.Actors
                .Add(actorDetails);

            _context.SaveChanges();
        }

        public void DeleteActor(Actors actorDetails)
        {
            _context.Actors
                .Remove(actorDetails);

            _context.SaveChanges();
        }

        public Actors GetActor(int actorId)
        {
            return _context.Actors
                .Find(actorId);
        }

        public Actors GetActorAsNoTracking(int actorId)
        {
            return _context.Actors
                .AsNoTracking()
                .SingleOrDefault(a => a.ActorId == actorId);
        }

        public string GetActorImage(string actorName)
        {
            return _context.Actors
                .Single(a => a.ActorName == actorName)
                .ActorImage;
        }

        public List<Actors> GetActorsByGender(string gender)
        {
            return _context.Actors
                .Where(a => a.ActorGender == gender)
                .Include(a => a.SelectedMovies)
                .ThenInclude(a => a.Items)
                .ToList();
        }

        public IEnumerable<Actors> GetAllActors()
        {
            return _context.Actors
                .ToList();
        }

        public void UpdateActor(Actors actorDetails)
        {
            _context.Actors
                .Update(actorDetails);

            _context.SaveChanges();
        }
    }
}
