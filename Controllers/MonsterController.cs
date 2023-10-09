using Microsoft.AspNetCore.Mvc;
using rpg_db.Models;

namespace rpg_db.Controllers;

[ApiController]
[Route("[controller]")]
public class MonsterController : ControllerBase
{
    private readonly ILogger<MonsterController> _logger;

    public MonsterController(ILogger<MonsterController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public Monster Get(int id)
    {
        var monster = new Monster();

        monster.Id = 1;
        monster.Name = "Basilisco";
        monster.Description = "Monstro tipo réptil de pedra";
        monster.Image = "https://www.dndbeyond.com/avatars/thumbnails/30761/974/1000/1000/638061102119934833.png";
        
        return monster;
    }
}
