using System.Collections.Generic;

namespace Projects
{
    internal class ProjectService : IProjectService
    {
        public IEnumerable<Project> GetProjects()
        {
            return new List<Project>();
        }
    }
}