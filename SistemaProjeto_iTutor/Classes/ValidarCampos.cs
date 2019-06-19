﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaProjeto_iTutor.Classes
{
    public static class ValidarCampos
    {
        public static bool validarNome(string nome)
        {
            return !(string.IsNullOrWhiteSpace(nome)); //previne null, vazio e espaço em branco
        }

        public static bool validarCPF(string cpf)
        {
            return !(string.IsNullOrWhiteSpace(AdaptarParametros.adaptarCPF(cpf))); 
            //inserir função que faz a validação de CPFs
        }

    }
}
