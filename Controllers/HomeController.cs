﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNetMVC.Models;

namespace ExemploAspNetMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult SetimaAction() {
        return View();
    }

    public string TesteQueryString([FromQuery]string q, [FromQuery]string nome)
    {
        return $"Chegou aqui {q} e {nome}";
    }
    
    public string TesteForm([FromForm]string nome, [FromForm]string email)
    {
        return $"Nome: {nome}, Email: {email}";
    }

    public IActionResult Form ()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
