using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskSchedulingChallenge.Context;
using TaskSchedulingChallenge.Models;

namespace TaskSchedulingChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly OrganizadorContext _context;

        public TarefaController(OrganizadorContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var listarTarefaPorId = _context.Tarefas.Find(id);

            if (listarTarefaPorId == null)
                return NotFound();

            return Ok(listarTarefaPorId);
        }

        [HttpGet("ObterTodos")]
        public IActionResult ObterTodos()
        {
            var listarTodasTarefas = _context.Tarefas.ToList();

            return Ok(listarTodasTarefas);
        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult ObterPorTitulo(string titulo)
        {
            var listarTarefaPorTitulo = _context.Tarefas.Where(
                x => x.Titulo.ToString() == titulo.ToString());

            return Ok(listarTarefaPorTitulo);
        }

        [HttpGet("ObterPorData")]
        public IActionResult ObterPorData(DateTime data)
        {
            var listarTarefaPorData = _context.Tarefas.Where(
                x => x.Data.Date == data.Date);

            return Ok(listarTarefaPorData);
        }

        [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(EnumStatusTarefa status)
        {
            var listarTarefaPorStatus = _context.Tarefas.Where(
                x => x.Status == status);

            return Ok(listarTarefaPorStatus);
        }

        [HttpPost]
        public IActionResult Criar(Tarefa tarefa)
        {
            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(
                    new { Erro = "A data da tarefa não pode ser vazia" });

            _context.Add(tarefa);
            _context.SaveChanges();

            return CreatedAtAction(
                nameof(ObterPorId), new { id = tarefa.Id }, tarefa);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Tarefa tarefa)
        {
            var alterarTarefa = _context.Tarefas.Find(id);

            if (alterarTarefa == null)
                return NotFound();

            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(
                    new { Erro = "A data da tarefa não pode ser vazia" });

            alterarTarefa.Titulo = tarefa.Titulo;
            alterarTarefa.Descricao = tarefa.Descricao;
            alterarTarefa.Data = tarefa.Data;
            alterarTarefa.Status = tarefa.Status;

            _context.Tarefas.Update(alterarTarefa);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var removerTarefa = _context.Tarefas.Find(id);

            if (removerTarefa == null)
                return NotFound();

            _context.Tarefas.Remove(removerTarefa);
            _context.SaveChanges();

            return NoContent();
        }
    }
}