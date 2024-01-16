using OGServer.Models;
using OGServer.Services;
using Microsoft.AspNetCore.Mvc;

namespace OGServer.Controllers;

[ApiController]
[Route("[controller]")]
public class CitizenComplaintController : ControllerBase
{
    public CitizenComplaintController()
    {
    }

    [HttpPost]
    public IActionResult Create(CitizenComplaint complaint)
    {
        CitizenComplaintService.Add(complaint);
        return CreatedAtAction(nameof(Get), new { id = complaint.Id }, complaint);
    }

    [HttpGet]
    public ActionResult<List<CitizenComplaint>> GetAll()
    {
        return new List<CitizenComplaint>();
    }

    [HttpGet("{id}")]
    public ActionResult<CitizenComplaint> Get(int id)
    {
        return new CitizenComplaint();
    }
}