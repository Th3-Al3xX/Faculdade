/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.unip.jdbc;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ResourceBundle;

/**
 *
 * @author UNIP
 */
public class JDBC {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws SQLException {
        ResourceBundle bundle = ResourceBundle.getBundle("br.com.unip.jdbc.util.configuracaoSistema");
        Connection connection = null;
        try {
            Class.forName(bundle.getString("driver"));
            connection = DriverManager.getConnection(bundle.getString("caminho"), bundle.getString("usuario"), bundle.getString("senha"));
            Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("Select * FROM jdbc.pessoa");

            while (resultSet.next()) {
                System.out.println(resultSet.getString("id_pessoa") + " - " + resultSet.getString("nome_pessoa"));
            }
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
            System.out.println("Erro ao processar o Banco");
        } catch (Exception e) {
            System.out.println("Erro ao processar o Banco");
        } finally {
            System.out.println("Passou Aqui");
            connection.close();
        }
    }
}