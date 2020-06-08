using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtoMine
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        // Acadêmicos: Bruno Delani, João V. Lopes Alves e Pedro Luís

        // 3º Semestre : Trabalho Interdisciplinar, Desenvolvimento de sistema de coleta 
        // e venda de itens em ambiente de jogo.
    }
}
