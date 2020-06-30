using RepositoryProblem.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryProblem.Core
{
    public interface IUnitOfWork :IDisposable
    {
        IStudentRepository Students { get; }
        IProjectRepository Projects { get; }

        int Complete();

    }
}