﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCenter.Model;
using TestCenter.Services;

namespace TestCenter.FakeServices
{
    public class FakeTestsService : TestsService
    {
        public IEnumerable<Test> GetAllTests()
        {
            var randomIdGenerator = new Random();

            return new List<Test>
            {
                new Test { Id = randomIdGenerator.Next(1000, 9999), CourseId = 1, Name = "Test 01 Name", Detail = "Test 11 Detail" },
                new Test { Id = randomIdGenerator.Next(1000, 9999), CourseId = 2, Name = "Test 02 Name", Detail = "Test 12 Detail" },
                new Test { Id = randomIdGenerator.Next(1000, 9999), CourseId = 2, Name = "Test 03 Name", Detail = "Test 13 Detail" }
            };
        }
    }
}
