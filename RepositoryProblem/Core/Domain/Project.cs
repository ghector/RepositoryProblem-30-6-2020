using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryProblem.Core.Domain
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }

        public Student Student { get; set; }
    }
}