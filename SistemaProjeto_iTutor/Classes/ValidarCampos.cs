using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaProjeto_iTutor.Classes
{
    public static class ValidarCampos
    {
        public static string respostaFinal;
        public static bool camposIncompletos = false;

        public static void VerificarConsistencia(string nome, string cpf, int indexPerfilUsuario, string nascimento, string cep, string telefone, string rua, string numero, string bairro, string cidade, string estado, string usuario, string senha, string perfilUsuario, int indexFormacaoAcademica, string valorHoraAula)
        {
            camposIncompletos = false;
            string resposta = "Os seguintes campos precisam ser peenchidos: ";

            if (string.IsNullOrWhiteSpace(nome))
            {
                camposIncompletos = true;
                resposta += "\n - Nome";
            }

            if (string.IsNullOrWhiteSpace(cpf) || cpf.Length < 11)
            {
                camposIncompletos = true;
                resposta += "\n - CPF";
            }
            
            if (string.IsNullOrWhiteSpace(nascimento))
            {
                camposIncompletos = true;
                resposta += "\n - Data de nascimento";
            }
            else
            {
                DateTime result;
                if (!DateTime.TryParse(nascimento, out result))
                {
                    camposIncompletos = true;
                    resposta += "\n - Data de nascimento";
                }
            }

            if (string.IsNullOrWhiteSpace(cep) || cep.Length < 8)
            {
                camposIncompletos = true;
                resposta += "\n - CEP";
            }

            if (string.IsNullOrWhiteSpace(telefone) || telefone.Length < 10)
            {
                camposIncompletos = true;
                resposta += "\n - Telefone";
            }

            if (string.IsNullOrWhiteSpace(rua))
            {
                camposIncompletos = true;
                resposta += "\n - Rua";
            }

            if (string.IsNullOrWhiteSpace(numero))
            {
                camposIncompletos = true;
                resposta += "\n - Número";
            }

            if (string.IsNullOrWhiteSpace(bairro))
            {
                camposIncompletos = true;
                resposta += "\n - Bairro";
            }

            if (string.IsNullOrWhiteSpace(cidade))
            {
                camposIncompletos = true;
                resposta += "\n - Cidade";
            }

            if (string.IsNullOrWhiteSpace(estado))
            {
                camposIncompletos = true;
                resposta += "\n - Estado";
            }

            if (string.IsNullOrWhiteSpace(usuario))
            {
                camposIncompletos = true;
                resposta += "\n - Usuário";
            }

            if (string.IsNullOrWhiteSpace(senha) || senha.Length == 0)
            {
                camposIncompletos = true;
                resposta += "\n - Senha";
            }

            if (indexPerfilUsuario == -1)
            {
                camposIncompletos = true;
                resposta += "\n - Perfil usuário";
            }
            else
            {
                if (perfilUsuario == "Professor")
                {
                    if (indexFormacaoAcademica == -1)
                    {
                        camposIncompletos = true;
                        resposta += "\n - Formação acadêmica";
                    }

                    if (string.IsNullOrWhiteSpace(valorHoraAula))
                    {
                        camposIncompletos = true;
                        resposta += "\n - Valor hora/aula";
                    }
                }
            }

            if (camposIncompletos)
            {
                respostaFinal = resposta;
            }
        }

    }
}
