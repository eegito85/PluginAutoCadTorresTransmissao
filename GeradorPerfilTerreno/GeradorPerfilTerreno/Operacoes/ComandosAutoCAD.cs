using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorPerfilTerreno.Operacoes
{
    public class ComandosAutoCAD
    {
        public string DesenharPerfilTerreno(List<Point3d> listaPontos)
        {
            string mensagem = "";  
            Document acDoc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            Database acCurDb = acDoc.Database;

            int nPontos = listaPontos.Count();

            if (listaPontos != null)
            {
                using (Transaction acTrans = acCurDb.TransactionManager.StartTransaction())
                {
                    BlockTable acBlkTbl;
                    acBlkTbl = acTrans.GetObject(acCurDb.BlockTableId, OpenMode.ForRead) as BlockTable;
                    BlockTableRecord acBlkTblRec;
                    acBlkTblRec = acTrans.GetObject(acBlkTbl[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;
                    LayerTable acLyrTbl;
                    acLyrTbl = acTrans.GetObject(acCurDb.LayerTableId, OpenMode.ForRead) as LayerTable;
                    if (nPontos > 1)
                    {
                        try
                        {
                            //CASO QUEIRA UMA POLILINHA 2D
                            Polyline perfil = new Polyline();
                            perfil.SetDatabaseDefaults();
                            for (int i = 0; i < nPontos; i++)
                            {
                                perfil.AddVertexAt(i, new Point2d(listaPontos[i].X, listaPontos[i].Z), 0, 0, 0);
                            }
                            perfil.Closed = false;
                            acBlkTblRec.AppendEntity(perfil);
                            acTrans.AddNewlyCreatedDBObject(perfil, true);

                            //CASO QUEIRA A LINHA 3D - COMPLETA
                            //Point3d p1 = new Point3d(0, 0, 0);
                            //Point3d p2 = new Point3d(0, 0, 0);
                            //for (int i = 0; i < nPontos - 1; i++)
                            //{
                            //    Line linha = new Line();
                            //    linha.StartPoint = listaPontos[i];
                            //    linha.EndPoint = listaPontos[i + 1];
                            //    acBlkTblRec.AppendEntity(linha);
                            //    acTrans.AddNewlyCreatedDBObject(linha, true);
                            //}
                            mensagem = "Desenho feito com sucesso";
                            //dynamic acadApp = Autodesk.AutoCAD.ApplicationServices.Application.AcadApplication;
                            //acadApp.ZoomExtents();
                        }
                        catch { mensagem = "Erro ao gerar desenho"; }
                    }
                    else { mensagem = "Desenho não realizado - A lista de pontos só tem um ponto!"; }
                    acTrans.Commit();
                }
            }
            else { mensagem = "Desenho não realizado - A lista de pontos está vazia!"; }

            return mensagem;
        }    
        

        

    }
}
