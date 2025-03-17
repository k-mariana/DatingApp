using DatingApp.API.Data;
using DatingApp.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController: ControllerBase
{
    private readonly DataContext context;

    public UsersController(DataContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await context.Users.ToListAsync();

        return users;
    }

    [HttpPost]
    public async Task<ActionResult<IEnumerable<AppUser>>> CreateUser(string username)
    {
        var user = new AppUser
        {
            Id = Guid.NewGuid(),
            UserName = username
        };

        await context.Users.AddAsync(user);
        await context.SaveChangesAsync();

        var users = await context.Users.ToListAsync();

        return users;
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<AppUser>> GetUser(Guid id)
    {
        var user = await context.Users.FindAsync(id);

        if (user == null)
        { 
            return NotFound(); 
        }

        return user;
    }
}
