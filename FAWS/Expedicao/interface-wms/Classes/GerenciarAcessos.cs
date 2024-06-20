using FAWS_WMS;
using System;

namespace Interface_WMS_Expedicao.Classes
{
    class GerenciarAcessos
    {

        private static string Cargo; //Primeiro Commit suposto ajuste emergencia produção
        private static string NivelPermissao; //Primeiro Commit suposto ajuste emergencia produção

        private static string Usuario;
        private static string ResultLogin;

        public static string getUsuario { get => Usuario; }

        //Liberar o acesso dos campos de determinado Login
        internal static String LiberarAcesso()
        {

            Usuario = FrmMenu.getUsuario;
            ResultLogin = FrmMenu.getResultLogin;

            return Usuario;

            //switch (Usuario)
            //{
            //    case "PROFESSOR@01":

            //        break;
            //} 


        }
    }
}