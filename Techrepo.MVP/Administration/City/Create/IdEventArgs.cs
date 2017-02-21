using System;

namespace Techrepo.MVP.Administration.CreateCityNamespace
{
    public class IdEventArgs : EventArgs
    {
        public IdEventArgs(int id)
        {
            this.Id = id;
        }

        public int Id { get; set; }
    }
}
