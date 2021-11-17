using System;
using DataAccess;
using Util;

namespace BussinessRules
{
    public class AlunoBR
    {
        public string Gravar(Aluno _entidade)
        {
            if (String.IsNullOrEmpty(_entidade.Nome))
                return "O campo NOME é obrigatório o preenchimento!";
            
            switch (_entidade.Estado)
            {
                case Linha.Nova:
                    new AlunoDA(_entidade).Insert();
                    break;
                case Linha.Atualiza:
                    new AlunoDA(_entidade).Update();
                    break;
                default:
                    return "Há problemas com os dados.";
            }

            return String.Empty;
        }

        public string Deletar()
        {
            throw new NotImplementedException();
        }

        public void Consulta(Aluno _entidade)
        {
             new AlunoDA(_entidade).GetEntity();
            
        }
    }
}
