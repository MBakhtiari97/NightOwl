using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NightOwl.DataLayer.Entities;

namespace NightOwl.Core.Services.Interfaces
{
    public interface IActorsRepository
    {
        List<Actors> GetActorsByGender(string gender);
        string GetActorImage(string actorName);
        IEnumerable<Actors> GetAllActors();
        Actors GetActor(int actorId);
        Actors GetActorAsNoTracking(int actorId);
        void AddNewActor(Actors actorDetails);
        void UpdateActor(Actors actorDetails);
        void DeleteActor(Actors actorDetails);
    }
}
