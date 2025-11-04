using AutoMapper;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Service.Service;
using IFSPStore.Service.Validators;
using Microsoft.Extensions.DependencyInjection;
using MySql.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IFSPStore.Test
{
    public class ServiceTest
    {
        private ServiceCollection services;
        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<IFSPStoreDbContext>();
            services.AddScoped<IBaseRepository<User>, IBaseRepository<User>>();
            services.AddScoped<IBaseService<User>, BaseService<User>>();
            services.AddSingleton(
                    new MapperConfiguration(config => config.CreateMap<User, User>(), null).CreateMapper()
                );
            return services.BuildServiceProvider();
        }
        [TestMethod]
        public void TestUserService()
        {
            var serviceProvider = ConfigureServices();
            var _userService = serviceProvider.GetService < IBaseService <User>> ();
            var user = new User
            {
                Name = "pegadinhas",
                Password = "123"
            };
            var result = _userService.Add<User, User, UserValidator>(user);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }
    }
}
