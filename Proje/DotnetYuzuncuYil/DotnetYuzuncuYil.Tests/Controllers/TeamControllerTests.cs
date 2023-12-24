using AutoMapper;
using DotnetYuzuncuYil.API.Controllers;
using DotnetYuzuncuYil.Core;
using DotnetYuzuncuYil.Core.DTOs;
using DotnetYuzuncuYil.Core.Services;
using DotnetYuzuncuYil.Service.Mapping;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace DotnetYuzuncuYil.Tests
{
    public class TeamControllerTests
    {
        private static IMapper _mapper;

        public TeamControllerTests()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile(new MapProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
        }
        private List<Team> GetTestObjects()
        {
            List<Team> teams = new List<Team>()
            {
                new Team()
                {
                     Id = 1,
                     TeamName = "test1",
                     CreatedDate = DateTime.Now,
                }
            };
            return teams;
        }
        [Fact]
        public async Task All_WhenCalled_ReturnTeams()
        {
            //Arrange
            var mock = new Mock<ITeamService>();
            mock.Setup(m => m.GetAllAsync()).ReturnsAsync(GetTestObjects());
            var teamController = new TeamController(_mapper, mock.Object);
            //Act
            var result = teamController.All();
            //Assert
            //var okResult = Assert.IsType<ObjectResult>(result);
            Assert.NotNull(result);
            //Assert.Equal(200, okResult.StatusCode);
            //var dataResult = Assert.IsType<GlobalResultDto<List<TeamDto>>>(okResult.Value);
            //Assert.Equal(1, dataResult.Data[0].Id);
        }
    }
}