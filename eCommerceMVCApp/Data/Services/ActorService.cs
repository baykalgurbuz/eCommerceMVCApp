using eCommerceMVCApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceMVCApp.Data.Services
{
    public class ActorService : IActorServices
    {
        private readonly AppDbContext _context;
        public ActorService(AppDbContext context)
        {
            _context = context;
        }
        public Actor ActorGetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Actor actor)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result =await _context.Actors.ToListAsync();
            return result;
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new System.NotImplementedException();
        }

      
    }
}
