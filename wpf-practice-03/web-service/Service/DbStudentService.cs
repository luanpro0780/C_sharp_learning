﻿using Common.Service;
using System;
using System.Collections.Generic;
using Common.Model;
using System.Linq;

namespace web_service.Service
{
    public class DbStudentService : IStudentService
    {
        private SIMContext _context;

        public DbStudentService()
        {

        }
        public Student Add(Student student)
        {
            throw new NotImplementedException();
        }

        public List<Class> GetAllClasses()
        {
            return new List<Class>
            {
                new Class { Name ="" }
            };
        }

        public void Remove(int studentId)
        {
            throw new NotImplementedException();
        }

        public List<Student> SearchStudent(StudentSearchCriteria criteria)
        {
            throw new NotImplementedException();
        }

        public Student Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}