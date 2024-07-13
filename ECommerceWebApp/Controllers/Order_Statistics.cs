using ECommerceWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace ECommerceWebApp.Controllers
{
    public class Order_Statistics
    {

        public double CalculatTwoNum(int x=0, int y=0)
        {
            int z;
            if (x > y)
            {
                z = x - y;
            }
            else
            {
                z = x + y;
            }
            return z;
        }

    }
    public class StudentFunctions : Controller
    {

        List<Student> StudentList = new List<Student>
        {
            new Student{ Name="AYa",GPA=4.0},
            new Student{ Name="Mohamed",GPA=3.8},
            new Student{ Name="Mostafa",GPA=3.5},
            new Student{ Name="Ahemed",GPA=3.6},
            new Student{ Name="Eman",GPA=3.0},
            new Student{ Name="Wardany",GPA=2.0},
            new Student{ Name="shiref",GPA=1.0},
            new Student{ Name="Salwa",GPA=3.9},
        };

        public IActionResult GetStudentList()
        {
            List<Student> FilterdStudentList = StudentList.Where(x => x.GPA > 3.5).OrderByDescending(x => x.GPA).ToList();

            return View(FilterdStudentList);
        }

        public int GetStudentList2()
        {
            var FilterdStudentList = StudentList.Where(x => x.GPA > 3.5).OrderByDescending(x => x.GPA).ToList().Count;

            return FilterdStudentList;
        }

    }

    public class Student
    {
        [Required]
        public string Name { get; set; }
        [Range(0.0,4.0)]
        public double GPA { get; set; }
    }

}
