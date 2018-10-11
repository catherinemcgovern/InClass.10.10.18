using System.Collections;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;

namespace Buffteks
{
     class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                try
                {

                    //no matter what, delete and then create
                    db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    if(!db.Students.Any())
                    {
                        List<Student> students = new List<Student>()
                        {

                            
                            new Student()
                            {
                            FirstName = "Mara",
                            LastName = "Kinoff",
                            Rank = "Junior",

                              },
                            new Student()
                            {

                            FirstName = "Aaron", 
                            LastName = "Hebert",
                            Rank = "Senior",
                            },
                            new Student()
                            {

                            FirstName = "Cesareo", 
                            LastName = "Lona",
                            Rank = "Senior",
                              },
                            new Student()
                            {

                            FirstName = "Mason", 
                            LastName = "McCollum",
                            Rank = "Senior",
                              },
                            new Student()
                            {

                            FirstName = "Charles",
                            LastName = "Coufal",
                            Rank = "Junior",

                              },
                            new Student()
                            {

                            FirstName = "Gabriela",
                            LastName = "Valenzuela",
                            Rank = "Senior",
                              },
                            new Student()
                            {


                            FirstName = "Mekkala",
                            LastName = "Bourapa",
                            Rank = "Senior",
                              },
                            new Student()
                            {
                            FirstName = "Matthew",
                            LastName = "Webb",
                            Rank = "Junior",
                              },
                            new Student()
                            {
                            FirstName = "Michael",
                            LastName = "Matthews", 
                            Rank = "Senior",
                              },
                            new Student()
                            {
                            FirstName = "John",
                            LastName = "Cunningham",
                            Rank = "Sophomore",
                              },
                            new Student()
                            {

                            FirstName = "Amy",
                            LastName = "Saysouriyosack",
                            Rank = "Senior",
                            },
                            new Student()
                            {
                            FirstName = "Quan",
                            LastName = "Nguyen",
                            Rank = "Senior",
                              },
                            new Student()
                            {

                            FirstName = "Alexander",
                            LastName = "Roder",
                            Rank = "Senior",
                              },
                            new Student()
                            {

                            FirstName = "Claudia",
                            LastName = "Silva",
                            Rank = "Senior",

                              },
                            new Student()
                            {

                            FirstName = "Yi Fu",
                            LastName = "Ji",
                            Rank = "Junior",
                              },
                            new Student()
                            {

                            FirstName = "Phelps",
                            LastName = "Merrell", 
                            Rank = "Senior",
                            },
                            new Student()
                            {
                            FirstName = "Cory",
                            LastName = "Williams",
                            Rank = "Senior",
                              },
                            new Student()
                            {
                            FirstName = "Kayla",
                            LastName = "Washington",
                            Rank = "Senior",
                              },
                            new Student()
                            {

                            FirstName = "Laith",
                            LastName = "Alfaloujeh", 
                            Rank = "Junior",
                              },
                            new Student()
                            {

                            FirstName = "Alexander",
                            LastName = "McDonald",
                            Rank = "Sophomore",
                            },
                            new Student()
                            {

                            FirstName = "Michael",
                            LastName = "Hayes",
                            Rank = "Senior",
                              },
                            new Student()
                            {

                            FirstName = "Catherine",
                            LastName = "McGovern",
                            Rank = "Graduate",
                            },
                            new Student()
                            {

                            FirstName = "Todd",
                            LastName = "Kile",
                            Rank = "Sophomore",

                  },
                  
                  };

                      db.Students.AddRange(students);  
           

                     

                        db.SaveChanges();                                              

                    }
                    else
                    {
                        var students = db.Students.ToList();
                        foreach(Student s in students)
                        {
                            Console.WriteLine(s);
                        }

                    }
                    
                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }

                // putting menue stuff here
                Console.WriteLine("Welcome to the Bufteks Datatbase");

                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("Please select a menu option below:");
                Console.WriteLine("--------------------------------------------");

                 Console.WriteLine(
                "Commands: l (list), e (exit)");

                                Console.WriteLine("--------------------------------------------");

            {
                Console.Write("> ");
                var command = Console.ReadLine();
                switch (command)
                {
                    case "l":
                        Commands.ListAll();
                        break;
                        
                    case "e":
                        return;
                    default: 
                        Console.WriteLine("Unknown command.");
                        break;
                }

            }



                //end of menu stuff
            }
        }
    }
}