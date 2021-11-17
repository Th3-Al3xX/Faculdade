using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Collections;

namespace Dados
{
    public class MensagemDA
    {

        public ArrayList getMensagem()
        {
            string _strConexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Visual Studio 2008\Camadas\Camadas.mdb";

            OleDbConnection _conexao = new OleDbConnection();
            _conexao.ConnectionString = _strConexao;
            //            object obj;

            ArrayList _lista = new ArrayList();

            try
            {
                _conexao.Open();

                OleDbCommand _comando = new OleDbCommand();
                _comando.Connection = _conexao;

                _comando.CommandText = @"SELECT DESCRICAO FROM CURSO";


                //obj = _comando.ExecuteScalar();

                OleDbDataReader _reader = _comando.ExecuteReader();

                while (_reader.Read())
                {
                    _lista.Add(_reader.GetString(0));
                    //_lista.Add(_reader["DESCRICAO"]);
                }
            }
            finally
            {

                _conexao.Dispose();
            }

            //            return obj.ToString();
            return _lista;
        }
    }
}
