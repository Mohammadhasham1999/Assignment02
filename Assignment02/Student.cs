using System;


namespace Assignment02 
{
    public class Student
    {
        public int Id {get;init;}
        public string GivenName {get;set;}
        public string Surname {get; set;}
        public Status status {get;}
        public DateTime StartDate {get;set;}
        public DateTime EndDate {get;set;}
        public DateTime GraduationDate {get;set;}



        public Status GetStatus() 
        {
            var currentDate = DateTime.Now;

            if(currentDate == StartDate) 
            {
                return Status.New;
            }

            else if(currentDate > StartDate && currentDate < EndDate) 
            {
                return Status.Active;
            }

            else if(currentDate > EndDate) 
            {
                return Status.Graduated;
            }

            else 
            {
                return Status.Dropout;
            }


        }


        public override string ToString()
        {
            return "Id: " + Id + " GivenName: " + GivenName + " Surname: " + Surname + " Status: " + GetStatus() +
            " StartDate: " + StartDate + " EndDate: " + EndDate + " GraduationDate: " + GraduationDate;
        }



    }

}
