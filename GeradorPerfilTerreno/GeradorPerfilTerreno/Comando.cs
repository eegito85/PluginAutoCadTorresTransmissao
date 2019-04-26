using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;
using GeradorPerfilTerreno.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorPerfilTerreno
{
    public class Comando
    {
        [CommandMethod("gerarDesenhoTerreno")]
        public static void gerarDesenhoFundacao()
        {
            Document acDoc = Application.DocumentManager.MdiActiveDocument;
            FormInicial frmPrincipal = new FormInicial();
            frmPrincipal.ShowDialog();

        }
    }
}
