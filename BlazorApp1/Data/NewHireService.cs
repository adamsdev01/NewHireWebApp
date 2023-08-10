using BlazorApp1.Data.Models;
using BlazorApp1.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BlazorApp1.Data
{
    public class NewHireService
    {
        private readonly GenericRepository<NewHire> _repository;

        public NewHireService(DeveloperRosterDBContext dbContext)
        {
            _repository = new GenericRepository<NewHire>(dbContext);
        }

        public IEnumerable<NewHire> GetAllNewHires()
        {
            return _repository.GetAll().Where(x => x.IsCurrent == "Y");
        }

        public NewHire GetNewHiretById(long Id)
        {
            return _repository.GetById(Id);
        }

        public IEnumerable<NewHire> FindNewHires(Expression<Func<NewHire, bool>> predicate)
        {
            return _repository.Find(predicate);
        }

        public void AddNewHire(NewHire newHire)
        {
            newHire.InsertedDate = DateTime.Now;
            newHire.IsCurrent = "Y";

            _repository.Add(newHire);
            _repository.SaveChanges();
        }

        public void UpdateNewHire(NewHire newHire)
        {
            _repository.Update(newHire);
            _repository.SaveChanges();
        }

        public void DeleteNewHire(long id)
        {
            var newHire = _repository.GetById(id);
            if (newHire != null)
            {
                _repository.Remove(newHire);
                _repository.SaveChanges();
            }
        }
    }
}
