using MemcachedInspector.Services;
using MemcachedInspector.Services.BusinessServices;
using MemcachedInspector.Services.DataTransferObjects;
using MemcachedInspector.UI.Process.Events;
using MemcachedInspector.UI.Process.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemcachedInspector.UI.Process.ViewModels
{
    public class CacheOperationsViewModel
    {

        public event EventHandler<ConnectionEventArgs> ConnectionAvailable;

        public event EventHandler<ConnectionEventArgs> ConnectionAdded;

        public event EventHandler<ConnectionEventArgs> ConnectionRemoved;

        public event EventHandler<SessionEventArgs> SessionStarted;

        public event EventHandler<SessionEventArgs> SessionEnded;

        private Collection<Connection> Connections
        {
            get;
            set;
        } = new Collection<Connection>();

        private Collection<Session> Sessions
        {
            get;
            set;
        } = new Collection<Session>();

        private ICacheRegistrationService cacheRegistrationService = null;
        private ICacheAdministrationService cacheAdministrationService = null;
        private ICacheService cacheService = null;

        public void Initialize()
        {
            this.cacheRegistrationService = ServiceFactory.GetCacheRegistrationService();
            this.cacheAdministrationService = ServiceFactory.GetCacheAdministrationService();
            this.cacheService = ServiceFactory.GetCacheService();

            this.LoadConnections();
        }

        public void LoadConnections()
        {
            this.cacheRegistrationService.LoadConnections();

            this.BindConnections();
        }

        public void SaveConnections()
        {
            this.cacheRegistrationService.SaveConnections();
        }

        public void StartSession(Connection connection)
        {
            Session session = new Session(connection);

            this.OnSessionStarted(session);
        }

        public void EndSession(Session session)
        {
            this.OnSessionEnded(session);
        }

        public void Register(Connection connection)
        {
            ConnectionDto connectionDto = new ConnectionDto(
                connection.Name,
                connection.HostName,
                connection.Port);

            this.cacheRegistrationService.Register(connectionDto);
        }

        public void Unregister(Connection connection)
        {
            ConnectionDto connectionDto = new ConnectionDto(
                connection.Name,
                connection.HostName,
                connection.Port);

            this.cacheRegistrationService.Unregister(connectionDto);
        }

        private void BindConnections()
        {
            this.Connections.Clear();

            ConnectionsDto connectionContainer = this.cacheRegistrationService.GetConnections();

            foreach (ConnectionDto connectionDto in connectionContainer.Connections)
            {
                Connection connectionModel = new Connection(connectionDto);

                this.Connections.Add(connectionModel);

                this.OnConnectionAvailable(connectionModel);
            }
        }

        protected void OnConnectionAvailable(Connection connection)
        {
            ConnectionEventArgs e = new ConnectionEventArgs();

            e.Connection = connection;

            this.OnConnectionAvailable(e);
        }

        protected void OnConnectionAvailable(ConnectionEventArgs e)
        {
            this.ConnectionAvailable?.Invoke(this, e);
        }

        protected void OnConnectionAdded(Connection connection)
        {
            ConnectionEventArgs e = new ConnectionEventArgs();

            e.Connection = connection;

            this.OnConnectionAdded(e);
        }

        protected void OnConnectionAdded(ConnectionEventArgs e)
        {
            this.ConnectionAdded?.Invoke(this, e);
        }

        protected void OnConnectionRemoved(Connection connection)
        {
            ConnectionEventArgs e = new ConnectionEventArgs();

            e.Connection = connection;

            this.OnConnectionRemoved(e);
        }

        protected void OnConnectionRemoved(ConnectionEventArgs e)
        {
            this.ConnectionRemoved?.Invoke(this, e);
        }

        protected void OnSessionStarted(Session session)
        {
            SessionEventArgs e = new SessionEventArgs();

            e.Session = session;

            this.OnSessionStarted(e);
        }

        protected void OnSessionStarted(SessionEventArgs e)
        {
            this.SessionStarted?.Invoke(this, e);
        }

        protected void OnSessionEnded(Session session)
        {
            SessionEventArgs e = new SessionEventArgs();

            e.Session = session;

            this.OnSessionEnded(e);
        }

        protected void OnSessionEnded(SessionEventArgs e)
        {
            this.SessionEnded?.Invoke(this, e);
        }

    }
}
