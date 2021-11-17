
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Locale;
import java.util.TimeZone;
import javax.swing.JOptionPane;

/**
 * 
 * @author Alex
 * Classe Pessoa Testes.
 */

public class TestePessoa {

    public static void main(String[] args) {
        Pessoa pessoa = new Pessoa();
        //pessoa.setCadastroPessoaFisica(JOptionPane.showInputDialog("Entre com o CPF: "));
        //pessoa.setRegistroGeral(JOptionPane.showInputDialog("Entre com o RG: "));
        
        //JOptionPane.showMessageDialog(null, pessoa.getCadastroPessoaFisica());
        //JOptionPane.showMessageDialog(null, pessoa.getRegistroGeral());

        String data = "03/03/1987";
        
        try{
            SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");
            Calendar calendar = Calendar.getInstance(TimeZone.getTimeZone("America/São Paulo"), new Locale("pt_BR"));
            sdf.setLenient(false);
            calendar.setTime(sdf.parse(data));
            
            JOptionPane.showMessageDialog(null, sdf.format(data));
            
        }catch(ParseException e){}
        }
        
    }
