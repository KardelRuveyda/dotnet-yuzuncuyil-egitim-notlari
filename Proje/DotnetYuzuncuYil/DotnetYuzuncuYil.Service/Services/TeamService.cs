using DotnetYuzuncuYil.Core;
using DotnetYuzuncuYil.Core.Repositories;
using DotnetYuzuncuYil.Core.Services;
using DotnetYuzuncuYil.Core.UnitOfWorks;
using DotnetYuzuncuYil.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Service.Services
{
    public class TeamService : Service<Team>, ITeamService
    {
        public TeamService(IGenericRepository<Team> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
