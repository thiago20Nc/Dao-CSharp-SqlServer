using Dao_CSharp_SQLServer.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao_CSharp_SQLServer.Model.Dao
{
    internal interface IPessoaDaoInterface
    {
        void insert(Pessoa obj);
        void update(Pessoa obj);
        void deleteById(int id);
        void findById(int id);
        List<Pessoa> findAll();
    }
}
