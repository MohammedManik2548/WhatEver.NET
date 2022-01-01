using Microsoft.AspNetCore.Mvc;

namespace WhatEver.Api.Controllers;

[Route("Api/[controller]")]
[ApiController]
public class MyController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Hello World";
    }
    
    [HttpGet("universe")]
    public string SayHello()
    {
        return "Hello Universe";
    }

    [HttpPost]
    public string SayHelloTo(Demo demo)
    {
        return $"Hello {demo.Name}";
    }

    [HttpPut]
    public string SayHelloPut(Demo demo)
    {
        return $"Hello {demo.Name}";
    }

    [HttpDelete("{id:int}")]
    public string SayHelloDel(int id)
    {
        return $"{id}";
    }
    

}

public class Demo
{
    public string Name { get; set; }
}
