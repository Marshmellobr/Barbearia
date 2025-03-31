using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbearia
{
    public partial class Agenda : Form
    {

        public void tela_inicial()
        {
            Tela_Inicial tela_Inicial = new Tela_Inicial();
            tela_Inicial.Show();
            this.Hide();
        }

        public Agenda()
        {
            InitializeComponent();
        }

        private void Bt_Sair_agenda_Click(object sender, EventArgs e)
        {
            tela_inicial();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }
    }
    
}
