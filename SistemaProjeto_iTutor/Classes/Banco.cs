using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaProjeto_iTutor.Classes
{
    public static class Banco
    {
        public static string enderecoBanco()
        {

            //return "server=DESKTOP-EBQVT0A\\SQLEXPRESS;database=iTutor;UID=sa;password=123456";
            //return "server=LAPTOP-RRGSDFI2\\SQLEXPRESS;database=iTutor;UID=sa;password=123456";
            //return "server=DESKTOP-O714ESL\\SQLEXPRESS;database=sandBox;UID=sa;password=123456";
            return "server=SENAC\\SQLEXPRESS; database=iTutor;UID=sa;password=123456";
        }
    }
}
