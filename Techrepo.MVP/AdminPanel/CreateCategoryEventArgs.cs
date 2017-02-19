using System;

namespace Techrepo.MVP.AdminPanel
{
    public class CreateCategoryEventArgs : EventArgs
    {
        public CreateCategoryEventArgs(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
