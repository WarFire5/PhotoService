using System;
using System.IO;
using PhotoService.DAL.Dtos;
namespace PhotoService.DAL;


public class Program
{
   static void Main(string[] args)
    {
        Console.WriteLine(Environment.GetEnvironmentVariable("PhotoService"));
        Context context = new Context();
        context.Users.Add(new UsersDto() { Name = "Мария Иванова" });
    }
}