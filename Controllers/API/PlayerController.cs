using SoccerTeam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SoccerTeam.Controllers.API
{
    public class PlayerController : ApiController
    {
        private datacontext DbPlayer = new datacontext();

        public IHttpActionResult Get()
        {
            try
            {
                List<Player> players = DbPlayer.Players.ToList();
                return Ok(new { players });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public async Task<IHttpActionResult> Get(int id)
        {
            try
            {
                Player players = await DbPlayer.Players.FindAsync(id);
                return Ok(players);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public async Task<IHttpActionResult> Post([FromBody] Player player )
        {
            try
            {
                DbPlayer.Players.Add(player);
                await DbPlayer.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public async Task<IHttpActionResult> Put([FromBody] Player player,int id)
        {
            try
            {
                Player playerToUpdate = await DbPlayer.Players.FindAsync(id);
                playerToUpdate.Fname = player.Fname;
                playerToUpdate.Lname = player.Lname;
                playerToUpdate.position = player.position;
                playerToUpdate.age = player.age;
                await DbPlayer.SaveChangesAsync();
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                Player playerToRemove = await DbPlayer.Players.FindAsync(id);
                DbPlayer.Players.Remove(playerToRemove);
                await DbPlayer.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }




    }
}
