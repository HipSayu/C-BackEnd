using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndDotNetVSCode.Dtos.Students;
using BackEndDotNetVSCode.Entity;
using BackEndDotNetVSCode.Services.Interfaces;
using Microsoft.AspNetCore.Components.Forms;

namespace BackEndDotNetVSCode.Services.Implements
{
    public class StudentService : IStudentService
    {   private static int _id = 0;
        private static List<Students> _students = new List<Students>();
        public void CreateStudent(CreateStudentDto input)
        {   
            _students.Add(new Students(){
                Id = _id++,
                Name = input.Name,
                MaSinhVien = input.MaSoSinhVien,
                BirthOfDate = input.DateOfBirth
            });
            
        }

        public void DeleteById(int Id)
        {
                
            var student = _students.SingleOrDefault(Student => Student.Id == Id);
            if (student==null)
            {
                throw new NotImplementedException($"Không tìm thấy sinh viên có id = {Id}");
            }
            _students.Remove(student);

        }

        public List<StudentDto> GetAll()
        {
            var results = new List<StudentDto>();
            foreach (var student in _students) {
                results.Add(new StudentDto{
                    Id = student.Id,
                    Name = student.Name,
                    MaSinhVien = student.MaSinhVien,
                    BirthOfDate = student.BirthOfDate
                });
            }
            
            return results;
        }

        public CreateStudentDto getById(int Id)
        {
            var student = _students.FirstOrDefault(student => student.Id == Id);
            if (student == null){
                throw new NotImplementedException($"Không tìm thấy sinh viên có id = {Id}");
            }
            var results = new CreateStudentDto(){
                Name = student.Name,
                MaSoSinhVien = student.MaSinhVien,
                DateOfBirth = student.BirthOfDate,

            };
            return results;
        }

        public void UpdateStudent(UpdateStudentDto input)
        {
            var student = _students.FirstOrDefault(student => student.Id == input.Id);
            if(student==null){

                throw new NotImplementedException($"Không tìm thấy sinh viên có id = {input.Id}");

            }
            else {
                student.Name = input.Name;
                student.MaSinhVien = input.MaSoSinhVien;
                student.BirthOfDate = input.DateOfBirth;
            }
        }
    }
}