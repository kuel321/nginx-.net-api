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
}
