
using System;
using System.ComponentModel.DataAnnotations;

namespace ImageGalleryApi.Models
{
   public class ToDoList
{
     public int TaskID { get; set; }
    public string TaskName { get; set; }  = string.Empty;
    public string Description { get; set; }  = string.Empty;
    public DateTime? DueDate { get; set; }
    public bool IsCompleted { get; set; }
}

}