using AutoMapper;
using Cohorts_Movie_Store.DataAccess.Context;
using Cohorts_Movie_Store.UnitTest.Application.TestSetup.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohorts_Movie_Store.UnitTest.Application.Operations.ActorOperations.Commands.CreateActorCommands
{
    public class CreateActorCommandTests
    {
        private readonly MovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public CreateActorCommandTests(CommonTestFixture testFixture)
        {
            _dbContext = testFixture.context;
            _mapper = testFixture.Mapper;
        }
    }
}
