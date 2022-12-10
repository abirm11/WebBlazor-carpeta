using System.ComponentModel.DataAnnotations;

namespace WebBlazor.Models

{
    public class ToDoTask
    {
        public Guid TaskId { get; set;}

        //descripcion de la activida
        [Required(ErrorMessage ="Campo Task es Requerido" )]
        [StringLength(20)]

    
        public String Description { get; set;}
        public TaskState TaskState { get; set;}
        public DateTime DateCreated { get; set; } = DateTime.Now;

    }

    public enum TaskState
    
    {
        Activo,
        Inactico,
        Terminado
    }


}