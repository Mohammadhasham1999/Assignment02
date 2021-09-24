using System;

namespace Assignment02 
{
    public record ImmutableStudent
    {
        public int Id {get;init;}
        public string GivenName {get;init;}
        public string Surname {get; init;}
        public Status status {get;init;}
        public DateTime StartDate {get;init;}
        public DateTime EndDate {get;init;}
        public DateTime GraduationDate {get;init;}

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
