package br.unip.ads.main;

import br.unip.ads.model.Pessoa;
import java.util.List;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

public class ListarConteudoBaseDados {
    public static void main(String[] args) {
        
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("ProjetoPU");
        EntityManager entityManager = emf.createEntityManager();

        List<Pessoa> pessoas = entityManager.createNamedQuery("Pessoa.findAll").getResultList();

        for (Pessoa pessoa : pessoas){
            System.out.println(pessoa.getCodigo() + " - " + pessoa.getNome() + " - " + pessoa.getTipoPessoa().getDescricao());
        }
    }
}
