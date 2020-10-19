using System;
using Microsoft.AspNetCore.Mvc;

namespace ASPCORE.Controllers

{
    [Route("admin")]
    public class AdminController : Controller
    {
        [HttpGet("principal/{nome?}")]
        public IActionResult Index(String nome){
            return Content("Olá " + nome);
        }
        [HttpGet("secundaria/{numero:int?}")]
        public IActionResult Testando(int numero){
            var nome = Request.Query["nome"];
            return Content("testando " + nome);
        }
        [HttpGet("View")]
        public IActionResult Visualizar(){
            ViewData["HelloWord"] = false;
            return View();
        }
    }
}