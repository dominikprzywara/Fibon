using System;
using System.Linq;
using System.Threading.Tasks;

namespace Fibon.Api.Repository
{
    public interface IRepository
    {
        void Insert(int number, int value);
        int? Get(int number);
    }
}
