using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndDotNetVSCode.Dtos.Students
{
    public class UpdateStudentDto : CreateStudentDto
    {
            public int Id {set; get;}
    }
}