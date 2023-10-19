using Microsoft.AspNetCore.Mvc;
namespace CuentaRegresiva.Controllers;

public class HomeController : Controller{

    DateTime StartTime = DateTime.Now;
    DateTime EndTime = new DateTime(2023, 12, 31, 23, 59, 59);


    [HttpGet]
    [Route("")]
    public ViewResult Index(){
        ViewBag.inicioF = StartTime.ToString("MMM dd, yyyy");
        ViewBag.inicioH = StartTime.ToString("hh:mm tt");
        ViewBag.finF = EndTime.ToString("MMM dd, yyyy");
        ViewBag.finH = EndTime.ToString("hh:mm tt");
        ViewBag.restante = CuentaRegresiva(EndTime, StartTime);
        return View("Index");
    }

    public string CuentaRegresiva(DateTime fin, DateTime inicio){
        TimeSpan dif = fin - inicio;
        string restante = $"{dif.Days} Día(s), {dif.Hours} Hora(s), {dif.Minutes} Minuto(s)";
        Console.WriteLine(restante);
        return restante;
    }
}