using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DataLayer;
using TaskManager.Entities;
using TaskStatus = TaskManager.Entities.TaskStatus;

namespace TaskManager.BusinessLayer.Services.Repository
{
    public class TaskRepository : ITaskRepository
    {

        /// <summary>
        /// Creating Referance variable of TaskDBContext
        /// Injecting in TaskRepository constructor
        /// </summary>
        //private readonly InterviewTrackerDbContext _interviewDb;
        private readonly TaskDBContext _taskDBContext;
      public TaskRepository(TaskDBContext taskDBContext )
        {
            _taskDBContext = taskDBContext;
        }
        /// <summary>
        /// Add New Interview in InMemoryDb
        /// </summary>
        /// <param name="Task"></param>
        /// <returns></returns>

       

        /// <summary>
        /// Edit or Update logic to update task in db
        /// </summary>
        /// <param name="interview"></param>
        /// <returns></returns>
        public async Task<TaskItem> UpdateInterview(TaskItem taskItem)
        {
            _taskDBContext.Entry(taskItem).State = EntityState.Modified;
            var rseult = await _taskDBContext.SaveChangesAsync();
            return taskItem;
        }
        

       
        /// <summary>
        /// InMemoryDb logic to retrieve all task present in db
        /// </summary>
        /// <returns></returns>
        public async Task<List<TaskItem>> GetAllTask()
        {
            //business logic goes here
            try
            {
                var taskitem = await _taskDBContext.taskItems.
               OrderByDescending(x => x.TaskGroup).ToListAsync();
                return taskitem;
               
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// InMemoryDb logic to retrieve all task group
        /// </summary>
        /// <returns></returns>
        public async Task<List<TaskGroup>> GetAllTaskGroup()
        {
            //business logic goes here
            try
            {
                var tasks = await _taskDBContext.taskGroups.
              OrderByDescending(x => x.FirstName).ToListAsync();
                return tasks;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }


       
        /// <summary>
        /// InMemoryDb logic to retrieve task dashoard
        /// </summary>
        /// <returns></returns>
        //public async Task<TaskDashboard> GetDashboard()
        //{
        //    //business logic goes here
        //    try
        //    {

        //        TaskDashboard dashboard = new TaskDashboard();


        //        return dashboard;
        //    }
        //    catch (Exception exception)
        //    {
        //        throw exception;
        //    }
        //}

      

        /// <summary>
        /// InMemoryDb logic to add new task into db
        /// </summary>
        /// <param name="newtask"></param>
        /// <returns></returns>
        public async Task<string> NewTask(TaskItem newtask)
        {
            //business logic goes here
            try
            {
                
                newtask.TaskEndDate = newtask.TaskStartDate.AddDays(5);
               await _taskDBContext.InsertOneAsync(newtask);
                return "New Task Added";
            }

            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// MongoDB logic to add new task group into db
        /// </summary>
        /// <param name="taskGroup"></param>
        /// <returns></returns>
        public async Task<string> NewTaskGroup(TaskGroup taskGroup)
        {
            //business logic goes here
            try
            {
               await _taskDBContext.InsertOneAsync(taskGroup);
               return "New Group Added";

            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        Task<long> ITaskRepository.EditTask(TaskItem task)
        {
            throw new NotImplementedException();
        }

        Task<TaskDashboard> ITaskRepository.GetDashboard()
        {
            throw new NotImplementedException();
        }
    }
}
