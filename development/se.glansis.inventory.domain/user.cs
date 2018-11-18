using System;

namespace se.glansis.inventory.domain
{
    public class User
    {
        private long _id;
        private string _code;
        private string _name;
        private string _description;
        private bool _isactive;
        private string _changedby;
        private DateTime _changed;
        private long _rowversion;
        private string _login;
        private int _password;

        public long Id { get => _id; set => _id = value; }
        public string Code { get => _code; set => _code = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public bool Isactive { get => _isactive; set => _isactive = value; }
        public string Changedby { get => _changedby; set => _changedby = value; }
        public DateTime Changed { get => _changed; set => _changed = value; }
        public long Rowversion { get => _rowversion; set => _rowversion = value; }
        public string Login { get => _login; set => _login = value; }
        public int Password { get => _password; set => _password = value; }
    }

    public User()
    { }

    public bool Insert(User user)
    {
      return true;
    }

    public bool Update(User user)
    {
      return true;
    }

    public bool Delete(User user)
    {
      return true;
    }

    public User FindById(int id)
    {
      return new User();
    }

    public User FindByCode(string code)
    {
      return new User();
    }


}
