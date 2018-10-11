using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;

namespace Buffteks
{
    public static class Commands
    {
        public static void ListAll()
        {
            using (var db = new AppDbContext())              //#A
            {
                        Console.WriteLine();

                 Console.WriteLine($"BUFFTEKS DATABASE CONTENT:");

    
                        Console.WriteLine();

                         Console.WriteLine("Students");
                        
                         Console.WriteLine("--------------------------------------------------------------------");

                  var students = db.Students.ToList();
                        foreach(Student s in students)
                        {
                           Console.WriteLine($"Buffteks Members: {s.FirstName} {s.LastName}, {s.PhoneNumber}, {s.Email}");
                        }
                        Console.WriteLine();                        
                        Console.WriteLine();


                
            }
        }
    }
}