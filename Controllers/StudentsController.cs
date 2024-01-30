using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndDotNetVSCode.Dtos.Students;
using BackEndDotNetVSCode.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BackEndDotNetVSCode.Controllers
{
    public class StudentsController : ApiControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentsController(IStudentService studentService, ILogger<StudentsController> logger) : base(logger)
        {
            _studentService = studentService;
        }

        [HttpGet("GetAllStudents")]
        public ActionResult<List<StudentDto>> GetAll()
        {
            try
            {
                return Ok(_studentService.GetAll());
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpPost("CreateStudent")]
        public ActionResult CreateStudent([FromBody] CreateStudentDto input)
        {
            _studentService.CreateStudent(input);
            return Ok();
        }

        [HttpDelete("DeleteById")]
        public ActionResult DeleteSinhVienById(int id)
        {
            try
            {
                _studentService.DeleteById(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpPut("UpdateStudentById")]
        public ActionResult UpdateStudentById(UpdateStudentDto input)
        {
            try
            {
                _studentService.UpdateStudent(input);
                return Ok();
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }
    }
}