package br.unip.ads.dao;

import br.unip.ads.model.TipoPessoa;

public class TipoPessoaDAO extends DAOGeneric<TipoPessoa> implements CrudDAO<TipoPessoa> {

    @Override
    public TipoPessoa findByName(String name) throws DAOException {
        throw new UnsupportedOperationException("Not supported yet.");
    }
        
}
