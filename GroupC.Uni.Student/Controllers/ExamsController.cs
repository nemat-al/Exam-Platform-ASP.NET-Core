﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using GroupC.Uni.Core.Entities;
using GroupC.Uni.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
namespace GroupC.Uni.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        private readonly ITestCenterService _TestCenterService;
        private readonly ICourseService _CourseService;
        private readonly IGenerateExamService _GenerateExamService;
        private readonly IExamService _ExamService;
        private readonly IQuestionService _questionService;
        private readonly UserManager<ApplicationUser> _userManager;

        //private readonly IHttpContextAccessor _httpContextAccessor;
        public ExamsController(ITestCenterService ITestCenterService,
        ICourseService ICourseService, IGenerateExamService IGenerateExamService, IExamService IExamService,
        IQuestionService questionService, UserManager<ApplicationUser> userManager)
        {
            _TestCenterService = ITestCenterService;
            _CourseService = ICourseService;
            _GenerateExamService = IGenerateExamService;
            _ExamService = IExamService;
            _questionService = questionService;
            _userManager = userManager;

            //_httpContextAccessor = httpContextAccessor;
        }

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<Exam>> GetExams()
        {
            //var user = await _userManager.GetUserAsync(HttpContext.User);


            var ExamList = await _ExamService.ListAllAsyncWithExams();
            return ExamList;
        }
        // GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<Exam> Get(Guid id)
        {
            var q= await _ExamService.GetExamAsyncwithQuestions(id);
            return q;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

