using Microsoft.AspNetCore.Mvc;
using CadastroAlunos.Models;
using System.Collections.Generic;

namespace CadastroAlunos.Controllers
{
    public class AlunoController : Controller
    {
            public IActionResult Index()
        {
            return View(Aluno.Alunos);
        }

        [HttpPost]
        public IActionResult Cadastro(Aluno aluno)
        {
            Aluno.Alunos.Add(aluno);
            return RedirectToAction("Index");
        }

        public IActionResult ListagemCadastros()
        {
            return View(Aluno.Alunos);
        }
    }
}
