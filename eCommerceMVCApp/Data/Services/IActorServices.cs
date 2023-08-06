using eCommerceMVCApp.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eCommerceMVCApp.Data.Services
{
    public interface IActorServices
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor ActorGetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);

    }
}
