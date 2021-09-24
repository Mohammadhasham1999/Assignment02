using System;
using Xunit;
using Assignment02;

namespace Assignment02.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Given_studentObject_returns_equal_properties_via_to_string_method()
        {
            Student student = new Student 
            {
                Id = 1,
                GivenName = "Hashim",
                Surname = "Baig",
                StartDate = new DateTime(2019,5,20),
                EndDate = new DateTime(2022,8,30),
                GraduationDate = new DateTime(2022,8,30)
            };

            var expected = "Id: " + "1" + " GivenName: " + "Hashim" + " Surname: " + "Baig"  
                                  + " Status: " + "Active" + " StartDate: " + "20/05/2019 00.00.00" + " EndDate: " 
                                  + "30/08/2022 00.00.00" + " GraduationDate: " + "30/08/2022 00.00.00";

            Assert.Equal(expected,student.ToString());

        }


        [Fact]

        public void Given_record_object_compares_with_another_returns_bool()
        {
            ImmutableStudent ImmutableStudent = new ImmutableStudent 
            {
                Id = 4,
                GivenName = "TestName",
                Surname = "TestSurname",
                StartDate = new DateTime(2000,5,8),
                EndDate = new DateTime(2022,4,1),
                GraduationDate = new DateTime(2022,4,1)
            }; 

            var expected = "Id: 4 " + "GivenName: " + "TestName " + "Surname: " + "TestSurname " 
                                    + "Status: " + "Active " + "StartDate: " + "08/05/2000 00.00.00 " 
                                    + "EndDate: " + "01/04/2022 00.00.00 " + "GraduationDate: " + "01/04/2022 00.00.00"; 

            // Assert.Equal(expected,ImmutableStudent.ToString());
            // Assert.True(ImmutableStudent.ToString().Equals(expected));
        } 
    }
}
