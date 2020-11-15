using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Model;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly Aluno _aluno;

        public HomeController(Aluno aluno)
        {
            _aluno = aluno;
        }

        public IActionResult Index()
        {
            _aluno.Id = 10;
            _aluno.Teste();
            return View();
        }
    }
}
