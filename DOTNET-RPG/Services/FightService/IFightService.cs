﻿using System.Collections.Generic;
using System.Threading.Tasks;
using DOTNET_RPG.Dtos.Character;
using DOTNET_RPG.Dtos.Fight;
using DOTNET_RPG.Models;

namespace DOTNET_RPG.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
        Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);
        Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);
        Task<ServiceResponse<List<HighscoreDto>>> GetHighscore();
    }
}