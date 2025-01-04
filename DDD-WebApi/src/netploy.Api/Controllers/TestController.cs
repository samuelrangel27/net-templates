using Microsoft.AspNetCore.Mvc;
using netploy.Application.Handlers;

namespace netploy.api.Controllers;

public class TestController : BaseController
{
    public TestController(ILogger<TestController> logger)
        : base(logger)
    {

    }

    [HttpPost]
    public async Task<IActionResult> post(TestCommand command) => await ProcessCommandAsync(command);
}

