using CleanArchitecture.Application.Models.Authors.Commands.UpdateAuthor;
using CleanArchitecture.Application.Models.Authors.CreateAuthor.Commands;
using CleanArchitecture.Application.Models.Authors.GetAllAuthors.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArchitecture.Presentation.Controllers
{
    [Route("api/[controller]")]
    public class AuthorsController : BaseController
    {

        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetAllAuthorsModel>>> Get()
        {
            return Ok(await Mediator.Send(new GetAllAuthorsQuery()));
        }

        // POST: api/<controller>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]CreateAuthorCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        // POST: api/<controller>
        [HttpPut("{id}")]
        public async Task<ActionResult> Update([FromRoute] int id, [FromBody] UpdateAuthorCommand command)
        {
            if (id != command.AuthorId)
            {
                return BadRequest();
            }

            return Ok(await Mediator.Send(command));
        }
    }
}
