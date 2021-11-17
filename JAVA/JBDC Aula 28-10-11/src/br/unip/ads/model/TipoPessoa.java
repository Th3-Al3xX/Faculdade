/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package br.unip.ads.model;

import java.io.Serializable;
import java.util.List;
import javax.persistence.Basic;
import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.OneToMany;
import javax.persistence.Table;
import javax.xml.bind.annotation.XmlRootElement;

@Entity
@Table(name = "tipo_pessoa")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "TipoPessoa.findAll", query = "SELECT t FROM TipoPessoa t"),
    @NamedQuery(name = "TipoPessoa.findByCodigoTipoPessoa", query = "SELECT t FROM TipoPessoa t WHERE t.codigo = :codigo"),
    @NamedQuery(name = "TipoPessoa.findByDescricaoTipoPessoa", query = "SELECT t FROM TipoPessoa t WHERE t.descricao = :descricao")})

public class TipoPessoa implements Serializable {
    private static final long serialVersionUID = 1L;
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Basic(optional = false)
    @Column(name = "id_tipo_pessoa")
    private Integer codigo;
    @Column(name = "desc_tipo_pessoa")
    private String descricao;
    @OneToMany(cascade = CascadeType.ALL, mappedBy = "tipoPessoa")
    private List<Pessoa> pessoas;

    public TipoPessoa() {
    }

    public Integer getCodigo() {
        return codigo;
    }

    public void setCodigo(Integer codigo) {
        this.codigo = codigo;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public List<Pessoa> getPessoas() {
        return pessoas;
    }

    public void setPessoas(List<Pessoa> pessoas) {
        this.pessoas = pessoas;
    }
}
