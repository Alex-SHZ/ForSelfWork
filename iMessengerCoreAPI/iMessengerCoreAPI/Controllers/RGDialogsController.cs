using iMessengerCoreAPI.Data;
using iMessengerCoreAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace iMessengerCoreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RGDialogsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public RGDialogsController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<List<Guid>> GetGuid([FromQuery]List<Guid> clientIds)
        {
            List<Guid> result = await
                _db.RGDialogsClients
                  .Where(x => clientIds.Contains(x.IDClient))
                   .GroupBy(x => x.IDRGDialog)
                    .Where(x => x.Count() == clientIds.Count)
                    .Select(g => g.Key)
                    .ToListAsync();

            return result;
        }
    }
}
