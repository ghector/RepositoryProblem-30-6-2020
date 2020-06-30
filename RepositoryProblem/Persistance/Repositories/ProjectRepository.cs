using RepositoryProblem.Core.Domain;
using RepositoryProblem.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RepositoryProblem.Persistance.Repositories
{
    public class ProjectRepository :Repository<Project>, IProjectRepository
    {

        public ProjectRepository(ApplicationDbContext context) :base (context)
        {

        }


      

        public IEnumerable<Project> GetByDescending()
        {
          return  Context.Projects.OrderByDescending(x => x.Title);
        }
    }
}