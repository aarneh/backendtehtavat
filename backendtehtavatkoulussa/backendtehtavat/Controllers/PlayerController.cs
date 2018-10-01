using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pelijuttujentaustat
{

    [Route("api/players")]
    public class PlayerController : ControllerBase
    {
        private readonly PlayersProcessor _processor;

        public PlayerController(PlayersProcessor processor)
        {
            _processor = processor;
        }

        // GET api/<controller>/5
        [Route("{id}")]
        [HttpGet]
        public Task<Player> Get(Guid id)
        {
            return _processor.Get(id);
        }

        [HttpGet]
        public Task<Player[]> GetAll()
        {
            return _processor.GetAll();
        }

        
        [Route("name/{name}")]
        [HttpGet]
        public Task<Player> GetName(String name)
        {
            return _processor.GetName(name);
        }

        [Route("minscore/{minscore}")]
        [HttpGet]
        public Task<Player[]> GetWithScoreMoreThan(int minscore)
        {
            return _processor.GetWithScoreMoreThan(minscore);
        }

        [Route("tag/{playertag}")]
        [HttpGet]
        public Task<Player[]> GetWithTag(Tag playertag)
        {
            return _processor.GetWithTag(playertag);
        }

        [Route("itemproperty/{itemlevel}")]
        [HttpGet]
        public Task<Player[]> GetWithItemProperty(int itemlevel)
        {
            return _processor.GetWithItemProperty(itemlevel);
        }

        [Route("itemamount/{itemamount}")]
        [HttpGet]
        public Task<Player[]> GetWithItemAmount(int itemamount)
        {
            return _processor.GetWithItemAmount(itemamount);
        }

        [Route("updateplayername/{playerid}/{name}")]
        [HttpPut]
        public Task<Player> UpdatePlayerName(Guid playerid, String name)
        {
            return _processor.UpdatePlayerName(playerid,name);
        }

        [Route("incrementscore/{playerid}/{incscore}")]
        [HttpPut]
        public Task<Player> IncrementScore(Guid playerid, int incscore)
        {
            return _processor.IncrementScore(playerid,incscore);
        }

        [Route("additem/{playerid}")]
        [HttpPost]
        public Task<Player> AddItem(Guid playerid,[FromBody] Item item)
        {
            return _processor.AddItem(playerid,item);
        }
        
        [Route("{playerid}/{score}/{itemid}")]
        [HttpDelete]
        public Task<Player> RemoveItemIncScore(Guid playerid,int score, Guid itemid)
        {
            return _processor.RemoveItemIncScore(playerid,score,itemid);
        }

        [Route("getbyscore")]
        [HttpGet]
        public Task<Player[]> GetPlayersSortedByScore()
        {
            return _processor.GetPlayersSortedByScore();
        }

        [Route("getmostcommonlevel")]
        [HttpGet]
        public Task<int?> GetMostCommonLevel()
        {
            return _processor.GetMostCommonLevel();
        }

        [Route("")]
        [HttpPost]
        public Task<Player> Create([FromBody]NewPlayer player)
        {
           // Console.WriteLine(player.Name);
            return _processor.Create(player);
        }
        
        [Route("{id}")]
        [HttpPut]
        public Task<Player> Modify(Guid id,[FromBody]ModifiedPlayer player)
        {
            return _processor.Modify(id, player);
        }
        
        
        [Route("{id}")]
        [HttpDelete]
        public Task<Player> Delete(Guid id)
        {
            return _processor.Delete(id);
        }
        
    }
}
