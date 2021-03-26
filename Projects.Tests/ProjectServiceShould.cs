using NUnit.Framework;
using Shouldly;

namespace Projects.Tests
{
    public class ProjectServiceShould
    {
        private IProjectService _projectService;

        [SetUp]
        public void Setup()
        {
            _projectService = new ProjectService();
        }

        [Test]
        public void GetEmptyListOfProjects()
        {
            var expected = System.Array.Empty<Project>();
            var actual = _projectService.GetProjects();
            
            actual.ShouldBe(expected);
        }
    }
}