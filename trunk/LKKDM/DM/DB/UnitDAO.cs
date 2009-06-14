using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM.DB
{
    public class UnitDAO
    {
        private UnitDAO()
        {
        
        }

        private static UnitDAO _MyInstance = null;

        public static UnitDAO GetInstance()
        {
            if (_MyInstance==null)
            {
                _MyInstance = new UnitDAO();
            }

            return _MyInstance;
        }

        //public bool AddUnit()
        //{

        //}
    }
}
