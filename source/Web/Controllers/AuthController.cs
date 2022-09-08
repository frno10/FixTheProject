using Architecture.Application;
using Architecture.Model;
using DotNetCore.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Architecture.Web;

[ApiController]
[Route("auths")]
public sealed class AuthController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService) => _authService = authService;

    [AllowAnonymous]
    [HttpPost]
    public IActionResult SignIn(SignInModel model) => _authService.SignInAsync(model).ApiResult();
}
