using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RepositoryProblem.Startup))]
namespace RepositoryProblem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
