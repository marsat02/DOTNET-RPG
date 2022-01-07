using DOTNET_RPG.Services.CharacterService;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using DOTNET_RPG.Dtos.Character;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DOTNET_RPG.Models;

namespace DOTNET_RPG.Controllers
{
    [Authorize(Roles = "Player")]
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }
        
        [HttpPost]
        public  async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddCharacter(AddCharacterDto newCharacter)
        {
            return Ok(await _characterService.AddCharacters(newCharacter));
        }
        
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> UpdateCharacter(UpdatedCharacterDto updatedCharacter)
        {
            var response = await _characterService.UpdateCharacters(updatedCharacter);
            if (response.Data == null)
                return NotFound(response);
            
            return Ok(response);
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> Delete(int id)
        {
            var response = await _characterService.DeleteCharacters(id);
            if (response.Data == null)
                return NotFound(response);
            
            return Ok(response);
        }
        
        [HttpPost("Skill")]
        public  async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill)
        {
            return Ok(await _characterService.AddCharacterSkill(newCharacterSkill));
        }
    }
}
