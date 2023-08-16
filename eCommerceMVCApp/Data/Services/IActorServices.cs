using eCommerceMVCApp.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eCommerceMVCApp.Data.Services
{
    public interface IActorServices
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> ActorGetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateASync(int id, Actor newActor);
        Task DeleteAsync(int id);

    }
}
