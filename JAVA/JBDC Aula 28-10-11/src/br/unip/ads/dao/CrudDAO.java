package br.unip.ads.dao;

import java.io.Serializable;
import java.util.List;

interface CrudDAO<T> {

    void save(T entity) throws DAOException;
    void update(T entity) throws DAOException;
    void remove(T entity) throws DAOException;
    List<T> findAll() throws DAOException;
    T findByName(String name) throws DAOException;
}
