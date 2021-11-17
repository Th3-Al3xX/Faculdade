
import br.unip.ads.util.DigitoConferidor;


public class Pessoa {
    private static long nextID = 1;
    private final Long numeroCertidao;
    private String nome;
    private String registroGeral;
    private String cadastroPessoaFisica;
    private String dataNascimento;
    private String[] telefones;

    public Pessoa() {
        numeroCertidao=nextID++;
    }

    public static long getNextID() {
        return nextID;
    }
        
    public Long getNumeroCertidao() {
        return numeroCertidao;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getRegistroGeral() {
        return registroGeral;
    }

    public void setRegistroGeral(String registroGeral) {
        if (DigitoConferidor.isRegistroGeral(registroGeral)){
            this.registroGeral = "RG: " + registroGeral;
        }else{
            this.registroGeral = "RG Inválido!";
        }
    }

    public String getCadastroPessoaFisica() {
        return cadastroPessoaFisica;
    }

    public void setCadastroPessoaFisica(String cadastroPessoaFisica) {
        if (DigitoConferidor.isCadastroPessoaFisica(cadastroPessoaFisica)){
            this.cadastroPessoaFisica = "CPF: " + cadastroPessoaFisica;
        }else{
            this.cadastroPessoaFisica = "CPF Inválido!"; 
        }
        
    }

    public String getDataNascimento() {
        return dataNascimento;
    }

    public void setDataNascimento(String dataNascimento) {
        this.dataNascimento = dataNascimento;
    }

    public String[] getTelefones() {
        return telefones;
    }

    public void setTelefones(String[] telefones) {
        this.telefones = telefones;
    }
    
}
