using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Uninove.Web.Models;

namespace Uninove.Web.Controllers;

public class AlunoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Nome = "Juan Souza";
        ViewBag.Curso = "Analise e Desenvolvimento de Sistemas";
        ViewBag.Semestre = 1;

        return View();
    }
}