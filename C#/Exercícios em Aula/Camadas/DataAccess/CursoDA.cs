using System;
using System.Collections;
using System.Data.OleDb;
using Util.Entidades;
using Util;
using System.Configuration;

namespace DataAccess
{
    public class CursoDA
    {
        public Curso _entity;

        public CursoDA() { }

        public CursoDA(Curso pEntity)
        { _entity = pEntity; }

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

                command.CommandText = String.Format("INSERT INTO CURSO (DESCRICAO, DTABERTURA) VALUES('{0}', #{1}#"
                    , _entity.Decricao, _entity.DtAbertura.ToString("dd-MM-yyyy"));

                command.ExecuteNonQuery();
            }
            catch (OleDbException)
            { throw; }
            finally
            { dataConnection.Dispose(); }
        }

        publicvoid Update()
        {
            string strConexao = ConfigurationManager.ConnectionStrings["Principal"].ToString();
            OleDbConnection dataConnection = new OleDbConnection();

            try
            {
                dataConnection.ConnectionString = strConexao;
                dataConnection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = dataConnection;

                command.CommandText = String.Format("UPDATE CURSO SET DESCRICAO = '{0}', DTNASCIMENTO = #{1}# WHERE CODIGO = {2}"
                    , _entity.Decricao, _entity.DtAbertura.ToString("dd-MM-yyyy"), _entity.Codigo);

                command.ExecuteNonQuery();
            }
            finally
            { dataConnection.Dispose(); }
        }

        public void Delete()
        {
            string strConexao = ConfigurationManager.ConnectionStrings["Principal"].ToString();
            OleDbConnection dataConnection = new OleDbConnection();

            try
            {
                dataConnection.ConnectionString = strConexao;
                dataConnection.Open();

                OleDbCommand command = new OleDbConnection();
                command.Connection = dataConnection;

                command.CommandText = String.Format("DELETE CURSO WHERE CODIGO = {0}"
                                                , _entity.Codigo);

                command.ExecuteNonQuery();
            }
            finally
            { dataConnection.Dispose(); }
        }

        public void GetEntity()
        {
            OleDbConnection dataConnection = new OleDbConnection();

            try
            {
                string srtConexao = ConfigurationManager.ConnectionStrings["Principal"].ToString();
                dataConnection.ConnectionString = srtConexao;
                dataConnection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = dataConnection;

                command.CommandText = String.Format("SELECT DESCRICAO, DTABERTURA FROM CURSO WHERE CODIGO = {0}", _entity.Codigo);

                OleDbDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    _entity.Decricao = dataReader.GetString(0);
                    _entity.DtAbertura = dataReader.GetDateTime(2);
                    _entity.Estado = Linha.Atualiza;
                }
                else
                {
                    _entity.Estado = Linha.Nova;
                }

                dataReader.Dispose();
            }
            finally
            { dataConnection.Dispose(); }
        }

        public ArrayList GetListAlunos()
        {
            ArrayList _lista = new ArrayList();

            OleDbConnection dataConnection = new OleDbConnection();

            try
            {
                string srtConexao = ConfigurationManager.ConnectionStrings["Principal"].ToString();
                dataConnection.ConnectionString = srtConexao;
                dataConnection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = dataConnection;

                command.CommandText = "SELECT CODIGO, DESCRICAO FROM CURSO";

                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Curso _entidade = new Curso();
                    _entidade.Codigo = dataReader.GetInt32(0);
                    _entidade.Decricao = dataReader.GetString(1);
                    _entidade.Estado = Linha.Atualiza;

                    _lista.Add(_entidade);
                }

                dataReader.Dispose();
            }
            finally
            { dataConnection.Dispose(); }

            return _lista;
        }
    }
}
