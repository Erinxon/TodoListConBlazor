using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Data;

namespace TodoList.Services
{
    interface IServicesTodoList
    {
        Task<IEnumerable<Tareas>> GetAllTodoList();
        Task<Tareas> GetTareaById(int id);
        Task SaveTarea(Tareas tareas);
        Task EditTarea(Tareas tareas);
        Task DeleteTarea(Tareas tareas);
    }
}
