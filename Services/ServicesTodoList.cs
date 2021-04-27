using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Data;
using Microsoft.EntityFrameworkCore;

namespace TodoList.Services
{
    public class ServicesTodoList : IServicesTodoList
    {
        private readonly TodoListDbContext _context;

        public ServicesTodoList(TodoListDbContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Tareas>> GetAllTodoList()
        {
            return await _context.Tasks
                .ToListAsync();
        }

        public async Task<Tareas> GetTareaById(int id)
        {
            return await _context.Tasks
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task SaveTarea(Tareas tareas)
        {
            _context.Tasks.Add(tareas);
            await _context.SaveChangesAsync();
        }

        public async Task EditTarea(Tareas tareas)
        {
            _context.Entry(tareas).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTarea(Tareas tareas)
        {
            _context.Tasks.Remove(tareas);
            await _context.SaveChangesAsync();
        }

       
        
        

       
    }
}
