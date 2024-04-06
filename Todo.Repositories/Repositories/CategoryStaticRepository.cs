using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todolist.Models;
using TodoList.Domain.Interface;

namespace Todo.Repositories.Repositories
{
    public class CategoryStaticRepository : ICategoryRepository
    {
        public Category Add(Category T)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Category Update(Category T)
        {
            throw new NotImplementedException();
        }
    }
}
