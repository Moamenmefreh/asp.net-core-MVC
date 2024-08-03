using Center.Data;
using Center.IRepository;
using Center.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Center.Repository
{
    public class Services<T> : IRepository.IServices<T> where T : class
    {
        private readonly AppDbContext _context;
        public Services(AppDbContext _context)
        {
            this._context = _context;
        }

        public void Add(T Entity)
        {
            _context.Set<T>().Add(Entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> All()
        {
            IEnumerable<T> AllP = _context.Set<T>().ToList();
            return AllP;
        }
        public void Delete(int id)
        {
            var item = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
            
        }

        public MatrialsRecord Details(int id)
        {
            var item = _context.MatrialsRecord.Find(id);
            if(item != null)
            {
                return item;
            }
            else
            {
                return null;
            }
        }

        public T FindAsync(int id)
        {
          var item=_context.Set<T>().Find(id);
       
            return item;
        
        }

        public void RecordingOfMaterials(MatrialsRecord Entity)
        {
         
            _context.MatrialsRecord.Add(Entity);
            _context.SaveChanges();
           
        }

        public void UpdateAsync(T Entity)
        {
            _context.Set<T>().Update(Entity);
            _context.SaveChanges();
        }
     
    }
}
