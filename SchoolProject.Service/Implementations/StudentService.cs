﻿using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProject.Service.Abstracts;

namespace SchoolProject.Service.Implementations
{
    public class StudentService : IStudentService
    {
        #region Fields
        private readonly IStudentRepository _studentRepository;
        #endregion

        #region Constructors
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }


        #endregion

        #region Handles Methods
        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _studentRepository.GetStudentsAsync();
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            var student = _studentRepository.GetTableNoTracking()
                .Include(s => s.Department)
                .Where(s => s.StudID == id)
                .FirstOrDefault();
            return student;
        }

        public async Task<Student> AddStudentAsync(Student student)
        {
            var studentResult = await _studentRepository.AddAsync(student);
            return studentResult;
        }
        public async Task<bool> EditStudentAsync(Student student)
        {
            await _studentRepository.UpdateAsync(student);
            return true;
        }

        public async Task<bool> IsNameExist(string name, int? id = null)
        {
            if (id is not null)
            {
                var studentResult = _studentRepository.GetTableNoTracking()
                .Where(s => s.Name == name & !s.StudID.Equals(id)).FirstOrDefault();
                if (studentResult == null)
                    return false;
                return true;
            }
            else
            {
                var studentResult = _studentRepository.GetTableNoTracking()
                .Where(s => s.Name == name).FirstOrDefault();
                if (studentResult == null)
                    return false;
                return true;
            }

        }

        public async Task<bool> DeleteStudentAsync(int id)
        {
            var student = await _studentRepository.GetByIdAsync(id);
            if (student == null)
                return false;

            using var transaction = _studentRepository.BeginTransaction();
            try
            {
                await _studentRepository.DeleteAsync(student);
                await transaction.CommitAsync();
                return true;
            }
            catch
            {
                await transaction.RollbackAsync();
                return false;
            }

        }

        #endregion
    }
}
