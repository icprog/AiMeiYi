﻿using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;

namespace ProjectMamagerBll . Bll
{
   public class MainBll
    {
        private readonly Dao.MainDao dal=null;
        public MainBll ( )
        {
            dal = new Dao . MainDao ( );
        }

        public DataTable getTableForMain ( )
        {
            return dal . getTableForMain ( );
        }

        public DataTable getTableForDetail ( string num )
        {
            return dal . getTableForDetail ( num );
        }

        public bool save ( DataTable table )
        {
            return dal . save ( table );
        }

        public DataTable tableOne ( string num )
        {
            return dal . tableOne ( num );
        }

        public DataTable tableTwo ( string num )
        {
            return dal . tableTwo ( num );
        }

        public DataTable tableTre ( string num )
        {
            return dal . tableTre ( num );
        }

    }
}
