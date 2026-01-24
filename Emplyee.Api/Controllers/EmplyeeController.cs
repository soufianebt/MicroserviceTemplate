using Emplyee.Service.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace Emplyee.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmplyeeController : ControllerBase
    {

        private readonly ILogger<EmplyeeController> _logger;
        private readonly IEmplyeeService _projectNameService;

        public EmplyeeController(IEmplyeeService projectNameService, ILogger<EmplyeeController> logger)
        {
            _projectNameService = projectNameService;
            _logger = logger;
        }

        public IEmplyeeService EmplyeeService { get; }

        [HttpGet(Name = "GetEmplyees")]
        public IEnumerable<Model.Emplyee> Get()
        {
            return _projectNameService.GetAll();
        }

        [HttpGet("employees")]
        public IActionResult GetEmployees([FromQuery] int page = 0, [FromQuery] int size = 10, [FromQuery] string? firstName = null, [FromQuery] string? lastName = null)
        {
            if (page < 0) page = 0;
            if (size <= 0) size = 10;

            var query = _projectNameService.Query();

            if (!string.IsNullOrWhiteSpace(firstName))
            {
                query = query.Where(e => !string.IsNullOrEmpty(e.firstName) && e.firstName.Contains(firstName));
            }

            if (!string.IsNullOrWhiteSpace(lastName))
            {
                query = query.Where(e => !string.IsNullOrEmpty(e.lastName) && e.lastName.Contains(lastName));
            }
            var total = query.Count();
            var items = query.Skip(page * size).Take(size).ToList();

            var result = new
            {
                Items = items,
                Total = total,
                Page = page,
                Size = size
            };

            return Ok(result);
        }
    }
}
