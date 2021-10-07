using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFinlanTechnical.Models;
using TFinlanTechnical.Repository;

namespace TFinlanTechnical.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IRepository _repository;

        public ToDoController(IRepository repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToDo>>> ToDoList()
        {
            return await _repository.SelectAll<ToDo>();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ToDo>> GetToDo(long id)
        {
            var model = await _repository.SelectById<ToDo>(id);

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateToDo(long id, ToDo model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            await _repository.UpdateAsync<ToDo>(model);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<ToDo>> InsertToDo([FromBody] ToDo model)
        {
            await _repository.CreateAsync<ToDo>(model);
            return CreatedAtAction("GetMember", new { id = model.Id }, model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ToDo>> DeleteToDo(long id)
        {
            var model = await _repository.SelectById<ToDo>(id);

            if (model == null)
            {
                return NotFound();
            }

            await _repository.DeleteAsync<ToDo>(model);

            return model;
        }
    }
}
