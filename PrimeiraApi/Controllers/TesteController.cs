using Microsoft.AspNetCore.Mvc;

namespace PrimeiraApi.Controllers
{
    [ApiController]
    [Route("api/demo")]
    public class TesteController : Controller
    {
        [HttpGet]
        [ProducesResponseType(typeof(Produto), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(new Produto { Id = 1, Nome = "Arroz", Preco = 23, Quantidade = 1 });
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(Produto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            return Ok(new Produto { Id = 1, Nome = "Arroz", Preco = 23, Quantidade = 1 });

        }

        [HttpPost]
        [ProducesResponseType(typeof(Produto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Post([FromBody] Produto produto)
        {
            if (produto == null)
            {
                return BadRequest("Produto não pode ser nulo");
            }

            // Simular a adição do produto
            //return CreatedAtAction(nameof(Get), new { id = produto.Id }, produto);
            return CreatedAtAction("Get", new { id = produto.Id }, produto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Put(int id, Produto produto)
        {
            if (produto == null || produto.Id != id)
            {
                return BadRequest("Produto inválido");
            }

            // Simular a atualização do produto
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id)
        {
            // Simular a exclusão do produto
            return NoContent();
        }
    }
}
