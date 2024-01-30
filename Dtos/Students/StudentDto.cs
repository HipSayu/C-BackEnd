using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndDotNetVSCode.Dtos.Students
{
    public class StudentDto
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public DateTime BirthOfDate {get; set;}
        public string MaSinhVien {get; set;}
    }
}