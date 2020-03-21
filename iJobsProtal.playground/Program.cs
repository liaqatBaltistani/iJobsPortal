using System;
using iJobPortal.entities;
namespace iJobsProtal.playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            Console.WriteLine(user.DateOfBirth == null ?  "Date of Birth is NULL":"****");
            Console.WriteLine(user.Email == null ? "Date of Birth is NULL":"****");


            user.address[1].City.Location.Cordinates.Latitude;

            

        }
    }
}
