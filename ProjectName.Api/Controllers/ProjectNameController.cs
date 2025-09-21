using Microsoft.AspNetCore.Mvc;
using ProjectName.Service.Abstraction;

namespace ProjectName.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectNameController : ControllerBase
    {

        private readonly ILogger<ProjectNameController> _logger;
        private readonly IProjectNameService _projectNameService;

        public ProjectNameController(IProjectNameService projectNameService, ILogger<ProjectNameController> logger)
        {
            _projectNameService = projectNameService;
            _logger = logger;
        }

        public IProjectNameService ProjectNameService { get; }

        [HttpGet(Name = "GetProjectNames")]
        public IEnumerable<Model.ProjectName> Get()
        {
            return _projectNameService.GetAll();
        }

        [HttpPost(Name = "AddProjectNames")]
        public IActionResult Add([FromBody] Model.ProjectName projectName)
        {
            _projectNameService.Add(projectName);
            return Ok();
        }
    }
}
