using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndDotNetVSCode.Dtos.Students
{
    public class CreateStudentDto
    {
        public string Name { get; set; }
        public string MaSoSinhVien { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}