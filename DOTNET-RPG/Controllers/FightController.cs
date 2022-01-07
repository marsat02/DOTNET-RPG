﻿using System.Threading.Tasks;
using DOTNET_RPG.Dtos.Character;
using DOTNET_RPG.Dtos.Fight;
using DOTNET_RPG.Models;
using DOTNET_RPG.Services.FightService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DOTNET_RPG.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class FightController : ControllerBase
    {
        private readonly IFightService _fightService;

        public FightController(IFightService fightService)
        {
            _fightService = fightService;
        }
        
        [HttpPost("Weapon")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> WeaponAttack(WeaponAttackDto request)
        {
            return Ok(await _fightService.WeaponAttack(request));
        }
        
        [HttpPost("Skill")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> SkillAttack(SkillAttackDto request)
        {
            return Ok(await _fightService.SkillAttack(request));
        }
        
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<FightResultDto>>> FightAttack(FightRequestDto request)
        {
            return Ok(await _fightService.Fight(request));
        }
        
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<HighscoreDto>>> GetHighscore()
        {
            return Ok(await _fightService.GetHighscore());
        }
    }
}