﻿using FAWS_WMS;
using FAWS_WMS.Telas;
using Interface_WMS_ClientesFornecedores.g1_ClientesFornecedores;
using System;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace baseCF
{
    public partial class formTipoTributoInserir : Form
    {
        public formTipoTributoInserir()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void tmrDataHora_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }

        private void formTipoTributoInserir_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())

                try
                {


                    OleDbConnection con = new OleDbConnection(Globals.ConnString);
                    con.Open();

                    String SQL;
                    SQL = "Insert Into g1_tblTipoTributo (descTributo, codTributo, descSituacaoTributo) values ";
                    SQL += "('" + txtdescTributo.Text + "','" + txtcodTributo.Text + "','" + txtSituacaoTributo.Text + "')";


                    OleDbCommand cmd = new OleDbCommand(SQL, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados gravados com sucesso.");

                    UserI LC = new UserI();

                    LC.limparCampos(tabIdentTributo.Controls);

                    con.Close();

                    UserI fecharForm = new UserI();
                    fecharForm.abrirFecharForm(this, formTipoTributo.ActiveForm);




                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }


            else
                MessageBox.Show("Favor preencher todos os campos.");
        }

        private bool ValidarForm()
        {
            bool FormValido;

            if (txtdescTributo.Text == "")
                FormValido = false;
            else if (txtcodTributo.Text == "")
                FormValido = false;
            else if (txtSituacaoTributo.Text == "")
                FormValido = false;
            else
                FormValido = true;
            return FormValido;




        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            UserI fechar = new UserI();
            fechar.abrirFecharForm(this, formTipoTributo.ActiveForm);

        }

        private void formTipoTributoInserir_Activated(object sender, EventArgs e)
        {
            lbNomeUsuarioPrincipal.Text = FrmMenu.getUsuario;
        }

        private void optionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormManual>().Count() == 0)
            {
                FormManual frm = new FormManual();
                frm.Show();
            }
            else
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is FormManual)
                    {
                        openForm.Show();
                    }
                }
            }
        }

        private void suporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContatoLogin frm = new FormContatoLogin();
            frm.ShowDialog();
        }
    }


}
