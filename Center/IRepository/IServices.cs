using Center.Models;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;

namespace Center.IRepository
{
    public interface IServices<T> where T : class
    {
        public IEnumerable<T> All();

        public void Add(T Entity);
        public void Delete(int id);
        public T FindAsync(int id);
        public void UpdateAsync(T Entity);
        public MatrialsRecord Details(int id);
        public void RecordingOfMaterials(MatrialsRecord Entity);
        }
}
