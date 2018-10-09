using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pelijuttujentaustat
{
    /*public class InMemoryRepository: IRepository
    {
        public InMemoryRepository(){
            Player temp = new Player();
            temp.Name = "Markku";
            temp.Id = Guid.NewGuid();
            temp.Score = 0;
            temp.IsBanned = false;
            temp.CreationTime = DateTime.Now;
            temp.Items = new  List<Item>();
            Item sword = new Item();
            sword.ItemId = Guid.NewGuid();
            sword.ItemLevel = 1;
           // sword.ItemType = "sword";
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            sword.CreationDate = DateTime.Now.AddDays(-randomNumber);
            temp.Items.Add(sword);
            players.Add(temp);
            
        }
        
        List<Player> players = new List<Player>();
        public Task<Player> Get(Guid id)
        { 
            for(int i = 0; i < players.Count;i++){
                if(players[i].Id==id){
                    return Task.FromResult(players[i]);
                }
            }
            return Task.FromResult((Player)null);
        }

        public Task<Player[]> GetAll()
        {
            return Task.FromResult(players.ToArray());
        }

        public Task<Player>Create(Player player)
        {
            players.Add(player);
            return Task.FromResult(player);
        }

        public Task<Player>Modify(Guid id, ModifiedPlayer player)
        {
            for(int i = 0; i < players.Count;i++){
                if(players[i].Id==id){
                    players[i].Score = player.Score;
                    return Task.FromResult(players[i]);
                }
            }
            return Task.FromResult((Player)null);
        }

        public Task<Player>Delete(Guid id)
        {
            Player tempplayer = new Player();
            for(int i = 0; i< players.Count; i++){
                if(players[i].Id == id){
                    players.Remove(players[i]);
                    return Task.FromResult(players[i]);
                }
            }
            return null;
        }

        public Task<Item> GetItem(Guid id, Guid itemid) {
            for(int i = 0; i < players.Count; i++) {
                if(players[i].Id==id) {
                    for(int j = 0; j < players[i].Items.Count; j++) {
                        if(players[i].Items[j].ItemId == itemid) {
                            return Task.FromResult(players[i].Items[j]);
                        }
                    }
                }
            }
            return Task.FromResult((Item)null);
        }
        
        public Task<Item[]> GetItems(Guid id){

             for(int i = 0; i < players.Count;i++){
                if(players[i].Id==id){
                    return Task.FromResult(players[i].Items.ToArray());
                }
            }
            return null;
        }
        
        public Task<Item> CreateItem(Guid id, Item item, DateTime creationdate){
            for(int i = 0; i < players.Count;i++){
                if(players[i].Id==id){
                    if(players[i].Level>=item.ItemLevel){
                        if(players[i].Level < 3 && item.ItemType == 0) {
                            throw new LevelRequirementException("Too low level!");
                        }
                        players[i].Items.Add(item);
                        return Task.FromResult(item);
                    }
                    else{
                        throw new LevelRequirementException("Too low level!");
                    }
                }
            }
            return null;
        }
        
        public Task<Item> ModifyItem(Guid id, ModifiedItem item, Guid itemid){
            for(int i = 0; i < players.Count;i++){
                if(players[i].Id==id){
                    for(int j = 0; j < players[i].Items.Count; j++){
                        if(players[i].Items[j].ItemId == itemid){
                        players[i].Items[j].ItemLevel = item.ItemLevel;
                        return Task.FromResult(players[i].Items[j]);
                        }
                    }
                }
            }
            return null;
        }

        public Task<Item> DeleteItem(Guid id, Guid itemid){
            for(int i = 0; i < players.Count;i++){
                if(players[i].Id==id){
                    for(int j = 0; j < players[i].Items.Count; j++){
                        if(players[i].Items[j].ItemId == itemid){
                            players[i].Items.Remove(players[i].Items[j]);
                            return Task.FromResult(players[i].Items[j]);
                        }
                    }
                }
            }
            return null;
        }

        private List<Log> Log = new List<Log>();
        public Task AuditDeleteStarted()
        {
            Log.Add(new Log("A request to delete player started at " + DateTime.Now.ToString()));
            return Task.CompletedTask;
        }
 
        public Task AuditDeleteSuccess()
        {
            Log.Add(new Log("A request to delete player ended at " + DateTime.Now.ToString()));
            return Task.CompletedTask;
        }
    }*/
}