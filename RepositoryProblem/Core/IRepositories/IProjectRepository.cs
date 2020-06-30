using RepositoryProblem.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryProblem.Core.IRepositories
{
    public interface IProjectRepository :IRepository<Project>
    {
        IEnumerable<Project> GetByDescending();
    }
}