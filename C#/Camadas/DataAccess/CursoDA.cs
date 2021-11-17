using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Util.Entidades;
using System.Configuration;
using System.Data.OleDb;
using Util;

namespace DataAccess
{
    public class CursoDA : IBase
    {
        public Curso _entity;
        public CursoDA(Curso pEntity)
        {
            this._entity = pEntity;
        }

        #region IBase Members

        public void Insert()
        {
            string strConexao = ConfigurationManager.ConnectionStrings["Principal"].ToString();
            OleDbConnection dataConnection = new OleDbConnection();

            try
            {
                dataConnection.ConnectionString = strConexao;
                dataConnection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = dataConnection;

                // Comando SQL de INSERT.
                command.CommandText = String.Format("INSERT INTO CURSO (DESCRICAO, DTABERTURA) VALUES('{0}', #{1}#)"
                                                   , _entity.Decricao,  _entity.DtAbertura.ToString("dd-MM-yyyy"));

                //Executa o comando.
                command.ExecuteNonQuery();
            }
            catch (OleDbException)
            {
                throw;
            }
            finally
            {
                dataConnection.Close();
                dataConnection.Dispose();
            }
        }

        public void Update()
        {
            string strConexao = ConfigurationManager.ConnectionStrings["Principal"].ToString();
            OleDbConnection dataConnection = new OleDbConnection();

            try
            {
                dataConnection.ConnectionString = strConexao;
                dataConnection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = dataConnection;

                // Comando SQL de UPDATE.
                command.CommandText = String.Format("UPDATE CURSO SET DESCRICAO = '{0}', DTABERTURA = #{1}# WHERE CODIGO = {2}"
                                                   , _entity.Decricao, _entity.DtAbertura.ToString("dd-MM-yyyy"), _entity.Codigo);

                //Executa o comando.
                command.ExecuteNonQuery();
            }
            finally
            {
                dataConnection.Close();
                dataConnection.Dispose();
            }
     
        }

        public void Delete()
        {
            string strConexao = ConfigurationManager.ConnectionStrings["Principal"].ToString();
            OleDbConnection dataConnection = new OleDbConnection();

            try
            {
                dataConnection.ConnectionString = strConexao;
                dataConnection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = dataConnection;

                // Comando SQL de DELETE.
                command.CommandText = String.Format("DELETE CURSO WHERE CODIGO = {0}"
                                                   , _entity.Codigo);

                //Executa o comando.
                command.ExecuteNonQuery();
            }
            finally
            {
                dataConnection.Close();
                dataConnection.Dispose();
            }
        }

        public void GetEntity()
        {
            OleDbConnection dataConnection = new OleDbConnection();

            try
            {
                string strConexao = ConfigurationManager.ConnectionStrings["Principal"].ToString();
                dataConnection.ConnectionString = strConexao;
                dataConnection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = dataConnection;

                // Comando SQL de CONSULTA.
                command.CommandText = String.Format("SELECT DESCRICAO, DTABERTURA FROM CURSO WHERE CODIGO = {0}", _entity.Codigo);

                //Executa o comando.
                OleDbDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read()) // Preenche apenas se encontrar o registro.
                {
                    _entity.Decricao = dataReader.GetString(0);
                    _entity.DtAbertura = dataReader.GetDateTime(1);
                    _entity.Estado = Linha.Atualiza;
                }
                else
                {
                    _entity.Estado = Linha.Nova;
                }
            }
            finally
            {
                dataConnection.Close();
                dataConnection.Dispose();
            }
        }

        #endregion
    }
}
