using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using myAPIApp.Models;

namespace myAPIApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemController : ControllerBase
    {

        private readonly TodoItemDbContext context;

        public  TodoItemController(TodoItemDbContext Context)
        {
            context = Context;
        }

        // Get: api/TodoItem
        [HttpGet]
        public async Task<IEnumerable<TodoItem>> GetTodoItems()
        {
            return await context.TodoItem.ToListAsync();
        }

        // Post: api/TodoItem
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoitem)
        {
            context.TodoItem.Add(todoitem);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTodoItems), new { id = todoitem.Id }, todoitem);
        }
    }
}