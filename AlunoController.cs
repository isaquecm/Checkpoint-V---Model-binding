using Microsoft.AspNetCore.Mvc;

public class AlunoController : Controller
{
    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(Aluno aluno)
    {
        if (!ModelState.IsValid)
        {
            return View(aluno);
        }

        return View("Confirmacao", aluno);
    }
}