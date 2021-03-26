using System.Collections.Generic;

namespace Projects.Commandline
{
    internal interface IProjectService
    {
        IEnumerable<Project> GetProjects();
    }
}