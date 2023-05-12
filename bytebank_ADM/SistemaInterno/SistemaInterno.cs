using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string senha)
        {
            bool usuarioAutenticardo = funcionario.Autenticar(senha);
            if (usuarioAutenticardo)
            {
                Console.WriteLine("Boas vindas ao nosso sistema. ");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }

        public bool Logar(GerenteDeContas funcionario, string senha)
        {
            bool usuarioAutenticardo = funcionario.Autenticar(senha);
            if (usuarioAutenticardo)
            {
                Console.WriteLine("Boas vindas ao nosso sistema. ");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }

      
        }
    }

