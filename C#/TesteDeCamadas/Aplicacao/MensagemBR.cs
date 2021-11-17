using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dados;
using System.Collections;

namespace Aplicacao
{
    public class MensagemBR
    {
        public ArrayList getMensagem()
        {
//            MensagemDA obj = new MensagemDA();
            return new MensagemDA().getMensagem();
        }

    }
}
