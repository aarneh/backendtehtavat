using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pelijuttujentaustat
{
     public interface IRepository
    {
        //Players
        Task<Player> Get(Guid id);
        Task<Player[]> GetAll();
        Task<Player> GetName(String name);
        Task<Player[]> GetWithScoreMoreThan(int minscore);
        Task<Player[]> GetWithItemAmount(int itemamount);
        Task<Player[]> GetWithTag(Tag playertag);
        Task<Player[]> GetWithItemProperty(int itemlevel);
        Task<Player> UpdatePlayerName(Guid playerid, String name);
        Task<Player> IncrementScore(Guid playerid, int incscore);
        Task<Player> AddItem(Guid playerid,Item item);
        Task<Player> RemoveItemIncScore(Guid playerid,int score, Guid itemid);
        Task<Player[]> GetPlayersSortedByScore();
        Task<Player> GetMostCommonLevel();
        Task<Player> Create(Player player);
        Task<Player> Modify(Guid id, ModifiedPlayer player);
        Task<Player> Delete(Guid id);
        //Items
        Task<Item> GetItem(Guid id, Guid itemid);
        Task<Item[]> GetItems(Guid id);
        Task<Item> CreateItem(Guid id, Item item, DateTime creationtime);
        Task<Item> ModifyItem(Guid id, ModifiedItem item, Guid itemid);
        Task<Item> DeleteItem(Guid id, Guid itemid);

    }
}