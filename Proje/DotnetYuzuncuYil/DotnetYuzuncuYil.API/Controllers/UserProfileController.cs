using AutoMapper;
using DotnetYuzuncuYil.Core;
using DotnetYuzuncuYil.Core.DTOs;
using DotnetYuzuncuYil.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetYuzuncuYil.API.Controllers
{
    public class UserProfileController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IUserProfileService _userProfileService;
        public UserProfileController(IMapper mapper, IUserProfileService userProfileService)
        {
            _mapper = mapper;
            _userProfileService = userProfileService;
        }
        // api/Team/
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var userProfiles = await _userProfileService.GetAllAsync();
            var userProfilesDto = _mapper.Map<List<UserProfileDto>>(userProfiles.ToList());
            return CreateActionResult(GlobalResultDto<List<UserProfileDto>>.Success(200, userProfilesDto));
        }

        [HttpGet("{id}")]
        // Get api/user/3
        public async Task<IActionResult> GetById(int id)
        {
            var userProfile = await _userProfileService.GetById(id);
            var userProfileDto = _mapper.Map<UserProfileDto>(userProfile);
            return CreateActionResult(GlobalResultDto<UserProfileDto>.Success(200, userProfileDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(UserProfileDto userProfileDto)
        {
            var userProfile = await _userProfileService.AddAsync(_mapper.Map<UserProfile>(userProfileDto));
            var userProfileDtos = _mapper.Map<UserProfileDto>(userProfile);
            return CreateActionResult(GlobalResultDto<UserProfileDto>.Success(201, userProfileDtos));
        }

        [HttpPut]
        public async Task<IActionResult> Update(UserProfileDto userProfileDto)
        {
            await _userProfileService.UpdateAsync(_mapper.Map<UserProfile>(userProfileDto));
            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var userProfile = await _userProfileService.GetById(id);
            await _userProfileService.RemoveAsync(userProfile);

            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }
    }
}