using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRUD
{
    public class SQLiteHelper
    {
        private readonly SQLiteAsyncConnection db;

        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Person>().Wait();
        }

        public Task<List<Person>> GetItemsAsync()
        {
            return db.Table<Person>().ToListAsync();
        }

        public Task<Person> GetItemAsync(int id)
        {
            return db.Table<Person>().Where(i => i.PersonID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Person person)
        {
            if (person.PersonID != 0)
            {
                return db.UpdateAsync(person);
            }
            else
            {
                return db.InsertAsync(person);
            }
        }

        public Task<int> DeleteItemAsync(Person person)
        {
            return db.DeleteAsync(person);
        }
    }

   
}
