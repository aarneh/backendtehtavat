using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pelijuttujentaustat
{

    [Route("api/players/{Id}/items")]
    public class ItemsController : ControllerBase
    {

        private readonly ItemsProcessor _processor;

        public ItemsController(ItemsProcessor processor)
        {
            _processor = processor;
        }
        
        [Route("{itemid}")]
        [HttpGet]
        public Task<Item> GetItem(Guid id, Guid itemid) {
            return _processor.GetItem(id, itemid);
        }
        
        [Route("")]
        [HttpGet]
        public Task<Item[]>GetItems(Guid id){
            return _processor.GetItems(id);
        }
        
        [Route("")]
        [HttpPost]
        [ExceptionFilter]
        public Task<Item>CreateItem(Guid id,[FromBody]NewItem item,[FromBody] DateTime creationdate){
            return _processor.CreateItem(id, item, creationdate);
        }

        [Route("")]
        [HttpPut]
        public Task<Item>ModifyItem(Guid id, [FromBody]ModifiedItem item, [FromBody]Guid itemid){
            return _processor.ModifyItem(id,item, itemid);
        }
        
        [Route("")]
        [HttpDelete]
        public Task<Item>DeleteItem(Guid id,[FromBody]Guid itemid){
            return _processor.DeleteItem(id, itemid);
        }
    }
}
