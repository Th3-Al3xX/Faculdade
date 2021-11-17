package br.unip.ads.util;

import java.io.Serializable;

public class DigitoConferidor implements Serializable {

    /**
     * O método calcula os números dos dígitos verificadores do Cadastro de Pessoas Físicas da Receita Federal.
     * @param cadastroPessoaFisica
     * @return digitos verificadores
     * @throws NumberFormatException
     */
    public static String getDigitoCadastroPessoaFisica(String cadastroPessoaFisica) {
        if (cadastroPessoaFisica.contains(".")) {
            cadastroPessoaFisica = cadastroPessoaFisica.replace(".", "");
        }
        if (cadastroPessoaFisica.contains("-")) {
            cadastroPessoaFisica = cadastroPessoaFisica.replace("-", "");
        }

        if (cadastroPessoaFisica.length() > 9) {
            cadastroPessoaFisica = cadastroPessoaFisica.substring(0, 9);
        }

        int cpfEntrada = 0,
                resultDigitoHum = 0,
                resultDigitoDois = 0,
                digit1 = 0,
                fator_mult = 9;

        // aloca��o dos arrays de inteiros
        int array1[] = new int[9],
                array2[] = new int[9],
                array3[] = new int[9];

        // convers�o para inteiro do valor inserido
        cpfEntrada = Integer.parseInt(cadastroPessoaFisica.toString());

        //Distribui��o do d�gitos do RE no Array de inteiros
        for (int counter = 0; counter < array1.length; counter++) {
            array1[counter] = cpfEntrada % 10;
            cpfEntrada /= 10;
            array2[counter] = array1[counter] * fator_mult--;
            resultDigitoHum += array2[counter];
        }

        digit1 = (resultDigitoHum % 11);
        if (digit1 == 10) {
            digit1 = 0;
        }

        //Inser��o do 1� d�gito no novo array
        array3[ 0] = digit1;

        //Inser��o de dados no array3
        for (int counter = 0; counter < (array1.length - 1); counter++) {
            array3[counter + 1] = array1[counter];
        }


        fator_mult = 9;

        //m�ltiplica��o do array pelos pesos
        for (int counter = 0; counter < array3.length; counter++) {
            array2[counter] = array3[counter] * fator_mult--;
            resultDigitoDois += array2[counter];
        }


        //int digit2=0;

        int digit2 = (resultDigitoDois % 11);
        if (digit2 == 10) {
            digit2 = 0;
        }

        String ret = Integer.toString(digit1);

        ret += Integer.toString(digit2);

        return ret;
    }//Fim do m�todo CPF

    /**
     * O método verifica a autenticidade de um número do Cadastro de Pessoas Físicas da Receita Federal.
     * @param cadastroPessoaFisica
     * @return boolean
     * @throws NumberFormatException
     */
    public static boolean isCadastroPessoaFisica(String cadastroPessoaFisica) {
        boolean result = true;

        if (!"".equals(cadastroPessoaFisica.trim())) {
            if (cadastroPessoaFisica.contains(".")) {
                cadastroPessoaFisica = cadastroPessoaFisica.replace(".", "");
            }
            if (cadastroPessoaFisica.contains("-")) {
                cadastroPessoaFisica = cadastroPessoaFisica.replace("-", "");
            }

            if ("11111111111".equals(cadastroPessoaFisica) || "22222222222".equals(cadastroPessoaFisica) || "33333333333".equals(cadastroPessoaFisica) || "44444444444".equals(cadastroPessoaFisica) || "55555555555".equals(cadastroPessoaFisica) || "66666666666".equals(cadastroPessoaFisica) || "77777777777".equals(cadastroPessoaFisica) || "88888888888".equals(cadastroPessoaFisica) || "99999999999".equals(cadastroPessoaFisica) || "00000000000".equals(cadastroPessoaFisica)) {
                result = false;
            }

            if (!DigitoConferidor.getDigitoCadastroPessoaFisica(cadastroPessoaFisica.substring(0, 9)).equalsIgnoreCase(cadastroPessoaFisica.substring(9, 11))) {
                result = false;
            }
        } else {
            result = false;
        }
        return result;
    }

    /**
     * O método calcula o número do dígito verificador Registro Geral da Secretaria de Segurança Pública.
     * @param registroGerale
     * @return 
     * @throws NumberFormatException
     */
    public static String getDigitoRegistroGeral(String registroGeral) {

        int rGeral;
        int fatorMultiplicacao = 2;
        int digito = 0;
        int array[] = new int[9];

        StringBuilder result = new StringBuilder();

        if (!"".equals(registroGeral.trim())) {
            if (registroGeral.contains(".")) {
                registroGeral = registroGeral.replace(".", "");
            }
            if (registroGeral.contains("-")) {
                registroGeral = registroGeral.replace("-", "");
            }

            rGeral = Integer.parseInt(registroGeral.substring(0, registroGeral.length()-1));
            for (int i = 0; i < array.length; i++) {
                array[i] = rGeral % 10;
                rGeral /= 10;
                array[i] *= fatorMultiplicacao++;
                digito += array[i];
            }

            digito %= 11;

            //An�lise do d�gito conferidor
            switch (digito) {

                case 10:
                    result.append("X");
                    break;  // done processing case

                default:
                    result.append(digito);

            }  // end switch structure
        }
        return result.toString();

    }//Fim do metodo RG

    /**
     * O método verifica a autenticidade de um número do Registro Geral da Secretaria de Segurança Pública.
     * @param cadastroPessoaFisica
     * @return boolean
     * @throws NumberFormatException
     */
    public static boolean isRegistroGeral(String registroGeral) {
        boolean result = true;

        if (!"".equals(registroGeral.trim())) {

            if (registroGeral.trim().contains(".")) {
                registroGeral = registroGeral.trim().replace(".", "");
            }
            if (registroGeral.trim().contains("-")) {
                registroGeral = registroGeral.trim().replace("-", "");
            }

            String dig = registroGeral.substring(registroGeral.length() - 1, registroGeral.length());
            if (!dig.equalsIgnoreCase(DigitoConferidor.getDigitoRegistroGeral(registroGeral))) {
                result = false;
            }
        } else {
            result = false;
        }
        return result;
    }
}
