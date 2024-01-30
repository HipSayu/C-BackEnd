using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndDotNetVSCode.Dtos.Students;

namespace BackEndDotNetVSCode.Services.Interfaces
{
    public interface IStudentService
    {
        void CreateStudent(CreateStudentDto input);
        List<StudentDto> GetAll();

        CreateStudentDto getById(int Id);

        void UpdateStudent (UpdateStudentDto input);

        void DeleteById (int Id);

    }
}