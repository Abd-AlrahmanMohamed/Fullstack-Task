namespace CQRSWebApi.Controllers.AuthController
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public UserController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("add-user")]

        public async Task<IActionResult> RegisterAsync(Registering registering)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);



            var result = await _authenticationService.RegisterAsync(registering);

             if (!result.IsAuthenticated)
                  return BadRequest(result.Message);

               return Ok(result);
        }
        [HttpPost("addrole")]
        public async Task<IActionResult> AddToRoleAsync( AddRole addRole)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authenticationService.AddToRoleAsync(addRole);

            if (!string.IsNullOrEmpty(result))
                return BadRequest(result);

            return Ok(addRole);
        }

        [HttpPost("login")]
        public async Task<IActionResult> SignUpAsync( SigningUp signingUp)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authenticationService.SignUpAsync(signingUp);

            if (!result.IsAuthenticated)
                return BadRequest(result.Message);

            return Ok(result);
        }
    }
}
