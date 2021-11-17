package br.unip.ads.main;

import br.unip.ads.model.Pessoa;
import br.unip.ads.model.TipoPessoa;
import java.util.List;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

public class InserirBase {
    public static void main(String[] args) {
        EntityManagerFactory emf =Persistence.createEntityManagerFactory("ProjetoPU");
        EntityManager entityManager = emf.createEntityManager();
        
        List<TipoPessoa> tPessoas = entityManager.
                createNamedQuery("TipoPessoa.findByCodigoTipoPessoa").
                setParameter("codigo",3).getResultList();

        
        TipoPessoa tipoPessoa = tPessoas.get(0);
        System.out.println(tipoPessoa.getDescricao());
        Pessoa pessoa = new Pessoa();
        pessoa.setNome("Alex de Souza");
        pessoa.setTipoPessoa(tipoPessoa);
        entityManager.getTransaction().begin();
        entityManager.persist(pessoa);
        entityManager.getTransaction().commit();
        
        List<Pessoa> ps = entityManager.createNamedQuery("Pessoa.findByNomePessoa").setParameter("nome","Alex de Souza").getResultList();
        
        if (!ps.isEmpty()){
            System.out.println(ps.get(0).getCodigo()+ " - " + ps.get(0).getNome() + " - " + ps.get(0).getTipoPessoa().getDescricao());
        }
    }
}
