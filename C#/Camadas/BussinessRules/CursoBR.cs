using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Util.Entidades;
using Util;
using DataAccess;

namespace BussinessRules
{
    public class CursoBR
    {
        public string Gravar(Curso _entidade)
        {
            if (String.IsNullOrEmpty(_entidade.Decricao))
                return "O campo DESCRIÇÃO é obrigatório o preenchimento!";

            switch (_entidade.Estado)
            {
                case Linha.Nova:
                    new CursoDA(_entidade).Insert();
                    break;
                case Linha.Atualiza:
                    new CursoDA(_entidade).Update();
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

        public void Consulta(Curso _entidade)
        {
            new CursoDA(_entidade).GetEntity();

        }


    }
}
