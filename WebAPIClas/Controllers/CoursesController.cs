﻿using Infrastructure.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAPIClas.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoursesController(ApiContext context) : ControllerBase
{
    private readonly ApiContext _context = context;

    [HttpGet]

    public async Task<IActionResult> GetAll()
    {
        var courses = await _context.course.ToListAsync();
        return Ok(courses);
    }

}
