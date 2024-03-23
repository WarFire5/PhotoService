// using Microsoft.EntityFrameworkCore;
// using PhotoService.DAL.DTO;
// using PhotoService.DAL.IRepositories;
//
// namespace PhotoService.DAL.Repositories;
//
// public class ServiceRepository :IServiceRepository
// {
//     readonly Context context = SingletoneStorage.GetStorage().Сontext;
//
//     public ServiceRepository()
//     {
//         Context context = SingletoneStorage.GetStorage().Сontext;
//     }
//     
//     public List<ServicesDto> GetAllServices() //Role Id==1(Менеджер)
//     {
//         var services = context.Services
//             .Include(s => s.Executor.Role.Id==1)
//             .ToList();
//         Console.WriteLine(services);
//         return services;
//         
//     }
//
//     public List<ServicesDto> GetServiceById()
//     {
//         var service = context.Services.Include(s => s.Id).ToList();
//         return service;
//     }
//
//     public ServicesDto AddService( ServicesDto service)
//     {
//         context.Services.Add(service);
//         context.SaveChanges();
//         return service;
//     }
// }