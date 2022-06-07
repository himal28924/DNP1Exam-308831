using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DataAccess;

namespace WebAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class XController : ControllerBase
{

    private DataRepository _dataRepository;

    public XController(DataRepository dataRepository)
    {
        _dataRepository = dataRepository;
    }
    
    
    /*  POsting anything */
    [HttpPost]
    public async Task<ActionResult<X>> AddTeam([FromBody]X x)
    {
        try
        { 
            Console.WriteLine(x.FirstName + "Is now in web Api");
            // Call to datarepository 
            
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    
    
    /*Getting item */
    
    [HttpGet]
    public async Task<ActionResult<ICollection<X>>> GetAllTeam()
    {
        try
        {
            // call on data repo
          //  ICollection<X> xyz = await _team.GetAllTeams();
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
        
    } 
    
    
    
    /* HTTP Post with appropriate route */
    
    [HttpPost]
    [Route("{teamName}")]
    public async Task<ActionResult> AddPlayer([FromBody]X xys,[FromRoute]string teamName)
    {
        try
        {
            Console.WriteLine($"In route {teamName}");
            //repo
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
        
    } 

    
}