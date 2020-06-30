using RepositoryProblem.Core.Domain;
using RepositoryProblem.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RepositoryProblem.Persistance.Repositories
{
    public class StudentRepository :Repository<Student> ,IStudentRepository
    {


        public StudentRepository(ApplicationDbContext context) : base(context)
        {

        }



       

        public IEnumerable<Student> GetTopStudents(int count)
        {
           return Context.Students.OrderByDescending(x => x.Score).Take(5);
        }
    }
}