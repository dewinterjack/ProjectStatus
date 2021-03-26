using System.Collections.Generic;

namespace Projects.Commandline
{
    internal class ProjectService : IProjectService
    {
        public IEnumerable<Project> GetProjects()
        {
            return new List<Project>();
        }
    }
}