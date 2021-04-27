using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Data
{
    public class Tareas
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "La tarea es requerida")]
        public string Tarea { get; set; }
        public bool Estado { get; set; }
    }
}
