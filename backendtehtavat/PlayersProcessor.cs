using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pelijuttujentaustat
{
    public class PlayersProcessor
    {
        private readonly IRepository _repository;

        public PlayersProcessor(IRepository repository)
        {
            _repository = repository;
        }
        public Task<Player> Get(Guid id){
            return _repository.Get(id);
        }

        public Task<Player[]> GetAll(){
            return _repository.GetAll();
        }

        public Task<Player> GetName(String name)
        {
            return _repository.GetName(name);
        }

        public Task<Player[]> GetWithScoreMoreThan(int minscore)
        {
            return _repository.GetWithScoreMoreThan(minscore);
        }

        public Task<Player[]> GetWithTag(Tag playertag)
        {
            return _repository.GetWithTag(playertag);
        }

        public Task<Player[]> GetWithItemProperty(int itemlevel)
        {
            return _repository.GetWithItemProperty(itemlevel);
        }

        public Task<Player[]> GetWithItemAmount(int itemamount)
        {
            return _repository.GetWithItemAmount(itemamount);
        }

        public Task<Player> UpdatePlayerName(Guid playerid, String name)
        {
            return _repository.UpdatePlayerName(playerid,name);
        }

        public Task<Player> IncrementScore(Guid playerid, int incscore)
        {
            return _repository.IncrementScore(playerid,incscore);
        }

        public Task<Player> AddItem(Guid playerid,Item item)
        {
            return _repository.AddItem(playerid,item);
        }

        public Task<Player> RemoveItemIncScore(Guid playerid,int score, Guid itemid)
        {
            return _repository.RemoveItemIncScore(playerid,score,itemid);
        }

        public Task<Player[]> GetPlayersSortedByScore()
        {
            return _repository.GetPlayersSortedByScore();
        }

        public Task<Player> GetMostCommonLevel()
        {
            return _repository.GetMostCommonLevel();
        }

        public Task<Player> Create(NewPlayer player){
            
            Player tempplayer = new Player();
            
            tempplayer.Name = player.Name;
            tempplayer.Id = Guid.NewGuid();
            tempplayer.Score = 0;
            tempplayer.Level = player.Level;
            tempplayer.IsBanned = false;
            tempplayer.CreationTime = DateTime.Now; 
            tempplayer.Items = new  List<Item>();
            
            return _repository.Create(tempplayer);
        }
        
        public Task<Player> Modify(Guid id, ModifiedPlayer player){
            
            return _repository.Modify(id, player);
        }

        public Task<Player> Delete(Guid id){
            _repository.Delete(id);
            return _repository.Get(id);
        }
    }
}