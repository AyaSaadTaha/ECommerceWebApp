using ECommerceWebApp.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace ECommerceWebAppTestProject
{
    public class UnitTest1
    {
        Order_Statistics TestCase;
        Student Student_Statistics;
       

        [Fact]
        public void CalculatSubNumTest()
        {
            TestCase=new Order_Statistics();                          
            //Arrange
            var Number = 5;
            //Act
            var OrderNumber = TestCase.CalculatTwoNum(10, 5);
            //Assert
            Assert.Equal(Number, OrderNumber);
        }

        [Fact]
        public void CalculatAddNumTest()
        {
            TestCase = new Order_Statistics();
            //Arrange
            var Number = 100;
            //Act
            var OrderNumber = TestCase.CalculatTwoNum(1,99);
            //Assert
            Assert.Equal(Number, OrderNumber);
        }

        [Fact]
        public void GetStudentListTest_GPAGrather()
        {
            Student_Statistics = new Student();
            StudentFunctions  StudentFunctionsTest = new StudentFunctions ();
            //Arrange
            int Number = 4;
            //Act
            int StudenNumber =StudentFunctionsTest.GetStudentList2();
            //Assert
            Assert.Equal(Number, StudenNumber);
        }

      
    }
}