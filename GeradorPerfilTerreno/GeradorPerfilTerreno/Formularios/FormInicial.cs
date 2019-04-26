using Autodesk.AutoCAD.Geometry;
using GeradorPerfilTerreno.Operacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorPerfilTerreno.Formularios
{
    public partial class FormInicial : Form
    {
        ComandosAutoCAD comando = new ComandosAutoCAD();
        GerenciarArquivo arquivo = new GerenciarArquivo();
        public List<Point3d> listaDePontos = new List<Point3d>();

        public FormInicial()
        {
            InitializeComponent();
        }

        private void btSelecionarPlanilha_Click(object sender, EventArgs e)
        {
            double fatorAmplZ = PegarFatorAmpliacaoZ();
            listaDePontos = arquivo.selecionarArquivoExcel(fatorAmplZ);
            btDesenharPerfil.Enabled = true;
        }

        private void btDesenharPerfil_Click(object sender, EventArgs e)
        {
            string mensagem = comando.DesenharPerfilTerreno(listaDePontos);
            MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double PegarFatorAmpliacaoZ()
        {
            double fator = 0;
            string sFator = txtFatorAmplZ.Text;
            sFator = sFator.TrimStart();
            sFator = sFator.TrimEnd();

            try
            {
                fator = arquivo.ConverterParaNumero(sFator);
            }
            catch
            {
                MessageBox.Show("Campo inválido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fator = 1;
            }
            return fator;
        }

    }
}
