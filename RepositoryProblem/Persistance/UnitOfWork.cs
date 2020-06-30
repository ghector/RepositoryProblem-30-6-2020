using RepositoryProblem.Core;
using RepositoryProblem.Core.IRepositories;
using RepositoryProblem.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryProblem.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IStudentRepository Students { get; private set; }

        public IProjectRepository Projects { get; private set; }



        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Students = new StudentRepository(_context);
            Projects = new ProjectRepository(_context);


        }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}