namespace RepositoryProblem.Migrations
{
    using RepositoryProblem.Core.Domain;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

    internal sealed class Configuration : DbMigrationsConfiguration<RepositoryProblem.Persistance.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RepositoryProblem.Persistance.ApplicationDbContext context)
        {
            Student s1 = new Student() { Name = "Hector", Score = 78, Age = 33 };
            Student s2 = new Student() { Name = "Marios", Score = 36, Age = 25 };
            Student s3 = new Student() { Name = "Petros", Score = 47, Age = 36 };
            Student s4 = new Student() { Name = "Mixalis", Score = 37, Age = 48 };
            Student s5 = new Student() { Name = "Iraklis", Score = 67, Age = 36 };
            Student s6 = new Student() { Name = "Fanis", Score = 56, Age = 46 };
            Student s7 = new Student() { Name = "Dimitris", Score = 37, Age = 26 };
            Student s8 = new Student() { Name = "Kostas", Score = 57, Age = 35 };
            Student s9 = new Student() { Name = "Giorgos", Score = 16, Age = 47 };
            Student s10 = new Student() { Name = "Alexis", Score = 36, Age = 58 };

            Project p1 = new Project() { Title = "C#" };
            Project p2 = new Project() { Title = "Java" };
            Project p3 = new Project() { Title = "Python" };
            Project p4 = new Project() { Title = "Scala" };
            Project p5 = new Project() { Title = "Javascript" };
            Project p6 = new Project() { Title = "F#" };
            Project p7 = new Project() { Title = "Go" };
            Project p8 = new Project() { Title = "C++" };
            Project p9 = new Project() { Title = "C" };
            Project p10 = new Project() { Title = "Kotlin" };
            Project p11 = new Project() { Title = "Swift" };
            Project p12 = new Project() { Title = "Laravel" };
            Project p13 = new Project() { Title = "Angular" };
            Project p14 = new Project() { Title = "Html" };
            Project p15 = new Project() { Title = "React" };
            Project p16 = new Project() { Title = "CSS" };
            Project p17 = new Project() { Title = "Bootstrap" };
            Project p18 = new Project() { Title = "Jquery" };
            Project p19 = new Project() { Title = "SQL" };
            Project p20 = new Project() { Title = "ASP.NET" };

            s1.Projects = new List<Project>() { p1, p2 };
            s2.Projects = new List<Project>() { p3, p4 };
            s3.Projects = new List<Project>() { p5 };
            s4.Projects = new List<Project>() { p6, p7 };
            s5.Projects = new List<Project>() { p8 };
            s6.Projects = new List<Project>() { p9 };
            s7.Projects = new List<Project>() { p10 };
            s8.Projects = new List<Project>() { p10, p11, p12, p13 };
            s9.Projects = new List<Project>() { p14, p15, p16, p17 };
            s10.Projects = new List<Project>() { p18, p19, p20 };

            context.Projects.AddOrUpdate(x => x.Title, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20);
            context.Students.AddOrUpdate(x => x.Name, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);

            context.SaveChanges();


        }
    }
}
