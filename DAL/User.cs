using Common.Abstractions;
using Common.NetWorkers;

namespace DAL
{
    public class User
    {
        // basically means socket or tcp client
        public INetWorkWrapper _connectionWorker { get; private set; }

        public User(INetWorkWrapper connectionWorker)
        {
            _connectionWorker = connectionWorker;
        }
    }
}