package br.unip.ads.dao;

import br.unip.ads.model.Pessoa;

public class PessoaDAO extends DAOGeneric<Pessoa> implements CrudDAO<Pessoa> {

    public PessoaDAO() {
    }

    @Override
    public Pessoa findByName(String name) throws DAOException {
        String query = "SELECT p FROM Pessoa p WHERE p.nome = '" + name + "'";
        return this.executeObject(query);
    }


    public Pessoa findByCPF(String cpf) throws DAOException {
        String query = "SELECT p FROM Pessoa p WHERE p.cpf = '" + cpf + "'";
        return this.executeObject(query);
    }

}
