using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ImageGalleryApi.Data; // Replace with your actual namespace
using ImageGalleryApi.Models; // Add this line to include the Image class
using System.Collections.Generic;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class ImageGalleryController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ImageGalleryController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Image>>> GetImages()
    {
        var images = await _context.ImageGallery.ToListAsync();
        return Ok(images);
    }

   [HttpGet("tasks")]
public async Task<ActionResult<IEnumerable<ToDoList>>> GetTasks()
{
    var tasks = await _context.ToDoList.ToListAsync();
    return Ok(tasks);
}
   [HttpPost("createTask")]
    public async Task<IActionResult> CreateTask([FromBody] ToDoList taskDto)
    {
        if (taskDto == null)
        {
            return BadRequest("Invalid input");
        }

        var task = new ToDoList
        {
            TaskName = taskDto.TaskName,
            Description = taskDto.Description,
            DueDate = taskDto.DueDate,
            IsCompleted = taskDto.IsCompleted
        };

        _context.ToDoList.Add(task);
        await _context.SaveChangesAsync();

        return Ok(new { TaskID = task.TaskID, TaskName = task.TaskName });
    }
}
