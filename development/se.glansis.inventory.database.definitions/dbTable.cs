using System;
using System.Collections.Generic;
using se.glansis.inventory.database;

namespace se.glansis.inventory.database.definitions
{
    public class DbTable
    {
        private string _tableName;
 
        private Dictionary<string, string> _columnDefinitions = new Dictionary<string, string>();
        private Dictionary<string, object> _columnData = new Dictionary<string, object>();
        private long _id;
        private string _code;
        private string _name;
        private string _description;
        private bool _isactive;
        private string _changedby;
        private DateTime _changed;
        private long _rowversion;
 
        public string TableName { get => _tableName; set => _tableName = value; }
        public long Id { get => _id; set => _id = value; }
        public string Code { get => _code; set => _code = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public bool Isactive { get => _isactive; set => _isactive = value; }
        public string Changedby { get => _changedby; set => _changedby = value; }
        public DateTime Changed { get => _changed; set => _changed = value; }
        public long Rowversion { get => _rowversion; set => _rowversion = value; }
 

    }

    public DbTable()
    {
    }

    public bool Insert()
    {
      return true;
    }

    public bool Update()
    {
      return true;
    }

    public bool Delete()
    {
      return true;
    }

    public Dictionary<string, object> FindById(int id)
    {
      return _columnData ;
    }

    public Dictionary<string, object> FindByCode(string code)
    {
      return _columnData;
    }


}
