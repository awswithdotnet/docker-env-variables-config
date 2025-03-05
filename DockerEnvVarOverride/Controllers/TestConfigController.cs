using Microsoft.AspNetCore.Mvc;

namespace DockerEnvVarOverride.Controllers;

[ApiController]
[Route("[controller]")]
public class TestConfigController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public TestConfigController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet]
    public string Get()
    {
        return "Configuration is from " + _configuration["TestConfigValue"];
    }
}