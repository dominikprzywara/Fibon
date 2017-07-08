using System.Collections.Generic;

namespace Fibon.Api.Repository
{
    public class RepositoryInMemory : IRepository
    {
        private readonly Dictionary<int, int> _storage = new Dictionary<int, int>();

        public void Insert(int number, int value)
        {
            _storage.Add(number, value);
        }

        public int? Get(int number)
        {
            int value;
            if (_storage.TryGetValue(number, out value))
            {
                return value;
            }

            return null;
        }


    }
}
