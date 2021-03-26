using System.Collections.Generic;

namespace Projects
{
    public interface IProjectService
    {
        IEnumerable<Project> GetProjects();
    }
}