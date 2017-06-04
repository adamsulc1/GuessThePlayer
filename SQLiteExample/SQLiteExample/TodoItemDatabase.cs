using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLiteExample
{
  public  class TodoItemDatabase
    {
        private SQLiteAsyncConnection database;

        public TodoItemDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<TodoItem>().Wait();
        }


        public Task<List<TodoItem>> GetItemsAsync()
        {
            return database.Table<TodoItem>().ToListAsync();
        }

        public Task<List<TodoItem>> GetItemsNotDoneAsync(int level)
        {
            return database.QueryAsync<TodoItem>("SELECT * FROM [TodoItem] WHERE Level =" + level);
        }
        public Task<List<TodoItem>> GetItemsNotDoneAsync2()
        {
            return database.QueryAsync<TodoItem>("SELECT * FROM [TodoItem]");
        }
        public Task<List<TodoItem>> GetItemsNotDoneAsync3(int level_player)
        {
            return database.QueryAsync<TodoItem>("SELECT * FROM [TodoItem] WHERE Level <" + level_player);
        }

        public Task<TodoItem> GetItemAsync(int id)
        {
            return database.Table<TodoItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(TodoItem item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(TodoItem item)
        {
            return database.DeleteAsync(item);
        }
        public Task<List<TodoItem>> Truncate()
        {
            return database.QueryAsync<TodoItem>("DELETE FROM [TodoItem]");
        }
    }
}
