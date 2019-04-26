using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorPerfilTerreno.Operacoes
{
    public class GerenciarArquivo
    {
        public List<Point3d> selecionarArquivoExcel(double fatorAmpliacaoZ)
        {
            Stream myStream = null;
            OpenFileDialog caixaDialogo = new OpenFileDialog();
            List<Point3d> listaPontos = new List<Point3d>();
            caixaDialogo.InitialDirectory = "c:\\";
            caixaDialogo.Filter = "Excel files (*.xlsx)|*.xlsx|Excel macro files (*.xlsm)|*.xlsm";
            caixaDialogo.FilterIndex = 1;
            caixaDialogo.RestoreDirectory = true;

            if (caixaDialogo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = caixaDialogo.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string nomeArquivo = caixaDialogo.FileName;
                            listaPontos = pegaDadosExcel(nomeArquivo, fatorAmpliacaoZ);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível ler o arquivo. Original error: " + ex.Message);
                }
            }
            return listaPontos;
        }

        private List<Point3d> pegaDadosExcel(string nomeArquivo, double fatorAmpliacao)
        {
            string nomeWorksheet = "Lista";
            List<Point3d> listaDados = new List<Point3d>();
            OleDbConnection conexao = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + nomeArquivo + ";Extended Properties='Excel 12.0 Xml;HDR=NO;IMEX=1'");
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from [" + nomeWorksheet + "]", conexao);
            DataSet ds = new DataSet();

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application
            {
                Visible = false
            };
            Microsoft.Office.Interop.Excel.Workbook wbExcel = excelApp.Workbooks.Open(nomeArquivo, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, null, null);
            Microsoft.Office.Interop.Excel.Worksheet activeSheet = (Microsoft.Office.Interop.Excel.Worksheet)wbExcel.ActiveSheet;
            Microsoft.Office.Interop.Excel.Worksheet wsPlanilha = (Microsoft.Office.Interop.Excel.Worksheet)wbExcel.Worksheets.get_Item(1);

            try
            {
                double X = 0;
                double Y = 0;
                double Z = 0;
                string sX = wsPlanilha.get_Range("E2", "E2").Text;
                string sY = wsPlanilha.get_Range("F2", "F2").Text;
                string sZ = wsPlanilha.get_Range("G2", "G2").Text;
                string colX = "E2";
                string colY = "F2";
                string colZ = "G2";
                int linha = 2;
                int indicador = 0;
                Point3d ponto = new Point3d(0, 0, 0);
                while (indicador == 0)
                {
                    sX = wsPlanilha.get_Range(colX, colX).Text;
                    if(sX == null || sX == "") { break; }
                    sY = wsPlanilha.get_Range(colY, colY).Text;
                    if(sY == null || sY == "") { break; }
                    sZ = wsPlanilha.get_Range(colZ, colZ).Text;
                    if(sZ == null || sZ == "") { break; }
                    
                    X = ConverterParaNumero(sX);
                    Y = ConverterParaNumero(sY);
                    Z = fatorAmpliacao * ConverterParaNumero(sZ);
                    ponto = new Point3d(X, Y, Z);
                    listaDados.Add(ponto);
                    linha++;
                    colX = string.Concat("E", linha.ToString());
                    colY = string.Concat("F", linha.ToString());
                    colZ = string.Concat("G", linha.ToString());
                }
                //listaDados = OrdenarListaPorAbcissa(listaDados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar arquivo: " + ex.Message);
            }

            excelApp.Workbooks.Close();
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wbExcel);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);


            return listaDados;
        }

        public double ConverterParaNumero(string sNumero)
        {
            double numero = 0;
            sNumero = sNumero.TrimStart();
            sNumero = sNumero.TrimEnd();
            sNumero = sNumero.Replace(',', '.');
            numero = Convert.ToDouble(sNumero);
            return numero;
        }

        private List<Point3d> OrdenarListaPorAbcissa(List<Point3d> listaAntiga)
        {
            List<Point3d> listaOrdenada = new List<Point3d>();

            listaOrdenada = listaAntiga.OrderBy(a => a.X).ToList();

            return listaOrdenada; 
        }
    }
}
