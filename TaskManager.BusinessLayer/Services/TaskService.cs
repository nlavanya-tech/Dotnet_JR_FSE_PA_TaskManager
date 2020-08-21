using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskManager.BusinessLayer.Interface;
using TaskManager.BusinessLayer.Services.Repository;
using TaskManager.DataLayer;
using TaskManager.Entities;
using TaskStatus = TaskManager.Entities.TaskStatus;

namespace TaskManager.BusinessLayer.Services
{
    public class TaskService : ITaskService
    {
        /// <summary>
        /// reference of type ITaskRepository
        /// </summary>
        private readonly ITaskRepository _taskRepository;
       
        /// <summary>
        /// Injecting object of type TaskRepository to access it's methods
        /// </summary>
        /// <param name="taskRepository"></param>
        public TaskService(ITaskRepository taskRepository)
        {

            _taskRepository = taskRepository;
        }

        /// <summary>
        /// call repository method to update task
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public async Task<long> EditTask(TaskItem task)
        {
            //business logic goes here
            throw new NotImplementedException();
            
        }


        /// <summary>
        /// Call method to retrieve all task present in db
        /// </summary>
        /// <returns></returns>
        public async Task<List<TaskItem>> GetAllTask()
        {
            //business logic goes here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Call repository method to retrieve all task group
        /// </summary>
        /// <returns></returns>
        public async Task<List<TaskGroup>> GetAllTaskGroup()
        {
            //business logic goes here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Call method to retrieve task dashoard
        /// </summary>
        /// <returns></returns>
        public async Task<TaskDashboard> GetDashboard()
        {
            //business logic goes here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Call repository method to add new task into db
        /// </summary>
        /// <param name="newtask"></param>
        /// <returns></returns>
        public async Task<string> NewTask(TaskItem newtask)
        {
            //business logic goes here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Call repository method to add new task group into db
        /// </summary>
        /// <param name="taskGroup"></param>
        /// <returns></returns>
        public async Task<string> NewTaskGroup(TaskGroup taskGroup)
        {
            //business logic goes here
            throw new NotImplementedException();
        }
    }
}
