using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao_CSharp_SQLServer.Model.Dao
{
    internal class DaoFactory
    {
        public static PessoaDao createPessoaDao()
        {
            return new PessoaDao();
        }
    }
}
