using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Application.TaskServices;
using ToDoList.Infrastructure.Services;

namespace ToDoList.Infrastructure.Helper
{
    public static class IoC
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            #region Application Services
            //Task Services
            services.AddTransient<ICreateTask, CreateTask>();
            services.AddTransient<IDeleteTask, DeleteTask>();
            services.AddTransient<IRestoreTask, RestoreTask>();
            services.AddTransient<IRemoveTask, RemoveTask>();
            services.AddTransient<IGetTasks, GetTasks>();
            services.AddTransient<IEditTask, EditTask>();
            services.AddTransient<IChangeStateTask, ChangeStateTask>();
            #endregion

            services.AddDbContext<Context>();

            return services;
        }
    }
}
