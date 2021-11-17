using System;
using System.Configuration;
using System.Data.OleDb;
using Util;
using System.Collections;

namespace DataAccess
{
    public class AlunoDA
    {
        public Aluno _entity;

        public AlunoDA() { }

        public AlunoDA(Aluno pEntity)
        {
            _entity = pEntity;
        }


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
                command.CommandText = String.Format("INSERT INTO ALUNO (NOME, SEXO, DTNASCIMENTO) VALUES('{0}', {1}, #{2}#)"
                                                   , _entity.Nome, (int)_entity.Sexo, _entity.DataNascimento.ToString("dd-MM-yyyy"));

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
                command.CommandText = String.Format("UPDATE ALUNO SET NOME = '{0}', SEXO = {1}, DTNASCIMENTO = #{2}# WHERE CODIGO = {3}"
                                                   , _entity.Nome, (int)_entity.Sexo, _entity.DataNascimento.ToString("dd-MM-yyyy"), _entity.Codigo);

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
                command.CommandText = String.Format("DELETE ALUNO WHERE CODIGO = {0}"
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
                command.CommandText = String.Format("SELECT NOME, SEXO, DTNASCIMENTO FROM ALUNO WHERE CODIGO = {0}", _entity.Codigo);

                //Executa o comando.
                OleDbDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read()) // Preenche apenas se encontrar o registro.
                {
                    _entity.Nome = dataReader.GetString(0);
                    _entity.Sexo = (Genero)dataReader.GetInt32(1);
                    _entity.DataNascimento = dataReader.GetDateTime(2);
                    _entity.Estado = Linha.Atualiza;
                }
                else
                {
                    _entity.Estado = Linha.Nova;
                }

                dataReader.Dispose();
            }
            finally
            {
                dataConnection.Close();
                dataConnection.Dispose();
            }
        }

        public ArrayList GetListAlunos()
        {
            ArrayList _lista = new ArrayList();

            OleDbConnection dataConnection = new OleDbConnection();

            try
            {
                string strConexao = ConfigurationManager.ConnectionStrings["Principal"].ToString();
                dataConnection.ConnectionString = strConexao;
                dataConnection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = dataConnection;

                // Comando SQL de CONSULTA.
                command.CommandText = "SELECT CODIGO, NOME FROM ALUNO ";

                //Executa o comando.
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read()) // Preenche apenas se encontrar o registro.
                {
                    Aluno _entidade = new Aluno();
                    _entidade.Codigo = dataReader.GetInt32(0);
                    _entidade.Nome = dataReader.GetString(1);
                    _entidade.Estado = Linha.Atualiza;

                    _lista.Add(_entidade);
                }

                dataReader.Dispose();
            }
            finally
            {
                dataConnection.Close();
                dataConnection.Dispose();
            }

            return _lista;
        }
    }
}