using Microsoft.AspNetCore.Authorization;
using DOTNET_RPG.Services.WeaponService;
using DOTNET_RPG.Dtos.Character;
using Microsoft.AspNetCore.Mvc;
using DOTNET_RPG.Dtos.Weapon;
using System.Threading.Tasks;
using DOTNET_RPG.Models;

namespace DOTNET_RPG.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeaponController : ControllerBase
    {
        private readonly IWeaponService _weaponService;

        public WeaponController(IWeaponService weaponService)
        {
            _weaponService = weaponService;
        }
        
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddWeapon(AddWeaponDto newWeapon)
        {
            return Ok(await _weaponService.AddWeapon(newWeapon));
        }
    }
}