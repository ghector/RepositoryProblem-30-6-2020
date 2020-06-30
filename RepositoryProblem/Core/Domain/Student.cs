using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryProblem.Core.Domain
{
    public class Student
    {
        public int StudentId { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public virtual ICollection<Project> Projects { get; set; }

    }
}