using API.Repository;
using Business;
using Business.Absctract;
using DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class TestController : ControllerRepository<ITestService, Test>       
    {
        private readonly ITestService _service;
        public TestController(ITestService service) : base(service)
        {
            _service = service;
        }        
    }
}
