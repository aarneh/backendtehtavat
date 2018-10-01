using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pelijuttujentaustat
{
    public class ItemsProcessor
    {
        private readonly IRepository _repository;

        public ItemsProcessor(IRepository repository)
        {
            _repository = repository;
        }

        public Task<Item> GetItem(Guid id, Guid itemid) {
            return _repository.GetItem(id, itemid);
        }

        public Task<Item[]> GetItems(Guid id){
            return _repository.GetItems(id);
        }
        
        public Task<Item> CreateItem(Guid id, NewItem item, DateTime creationdate){
            Item tempitem = new Item();
            Random random = new Random();
            int randomNumber = random.Next(1, 100);

            tempitem.ItemId = Guid.NewGuid();
            tempitem.ItemLevel = item.ItemLevel;
            tempitem.ItemType = item.ItemType;
            tempitem.CreationDate = item.CreationDate;
            
            return _repository.CreateItem(id, tempitem, creationdate);
        }
        public Task<Item> ModifyItem(Guid id, ModifiedItem item, Guid itemid){
            return _repository.ModifyItem(id, item, itemid);
        }

        public Task<Item> DeleteItem(Guid id, Guid itemid){
           // _repository.DeleteItem(id, itemid);
            return _repository.DeleteItem(id, itemid);
        }
    }
}