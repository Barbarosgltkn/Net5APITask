using Business.Absctract;
using Business.Repositories;
using DataAccess.Entities;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TestService:ServiceRepository<Test>,ITestService
    {
        private readonly IRepository<Test> _repository;

        public TestService(IRepository<Test> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
