using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using System;

public class UPNDrawer
{
    public void Draw(UPNSection section, Point3d basePoint)
    {
        Document doc = Application.DocumentManager.MdiActiveDocument;
        Database db = doc.Database;

        using (Transaction tr = db.TransactionManager.StartTransaction())
        {
            BlockTable bt = (BlockTable)tr.GetObject(db.BlockTableId, OpenMode.ForRead);
            BlockTableRecord btr = (BlockTableRecord)tr.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite);

            
            
            double dx1 = section.UPNRootRadius * (1 - section.UPNFlangeSlope * Math.Pow(1 + Math.Pow(section.UPNFlangeSlope, 2), -0.5));
            double dy1 = section.UPNRootRadius * Math.Pow(1 + Math.Pow(section.UPNFlangeSlope, 2), -0.5);
            double dx2 = section.UPNFlangeWidth / 2 - section.UPNWebThickness - dx1;
            double dy2 = dx2 * section.UPNFlangeSlope;

            double dx11 = section.UPNToeRadius * (1 - section.UPNFlangeSlope * Math.Pow(1 + Math.Pow(section.UPNFlangeSlope, 2), -0.5));
            double dy11 = section.UPNToeRadius * Math.Pow(1 + Math.Pow(section.UPNFlangeSlope, 2), -0.5);
            double dx22 = section.UPNFlangeWidth - dx11 - dx1 - section.UPNWebThickness ;
            double dy22 = dx22 * section.UPNFlangeSlope ;
            Editor ed = doc.Editor;

        
            

            Polyline pl = new Polyline();

            // 🔴 مؤقتاً: شكل مستطيل بسيط (سنستبدله لاحقاً بهندسة UPN الحقيقية)
            pl.AddVertexAt(0, new Point2d(basePoint.X, basePoint.Y), 0, 0, 0);
            pl.AddVertexAt(1, new Point2d(basePoint.X + section.UPNFlangeWidth, basePoint.Y), 0, 0, 0);
            
            pl.AddVertexAt(2, new Point2d(basePoint.X + section.UPNFlangeWidth ,basePoint.Y + dy2+section.UPNFlangeThickness-dy22-dy11), Math.Tan((2 * Math.Atan(1) - Math.Atan(section.UPNFlangeSlope)) / 4), 0, 0);
            
            pl.AddVertexAt(3, new Point2d(basePoint.X+section.UPNFlangeWidth-dx11, basePoint.Y+section.UPNFlangeThickness+dy2-dy22), 0, 0, 0);
            
            pl.AddVertexAt(4, new Point2d(basePoint.X+section.UPNWebThickness+dx1, basePoint.Y+dy2+section.UPNFlangeThickness), Math.Tan((-2 * Math.Atan(1) + Math.Atan(section.UPNFlangeSlope)) / 4), 0, 0);
            
            pl.AddVertexAt(5, new Point2d(basePoint.X+section.UPNWebThickness, basePoint.Y+dy1+dy2+section.UPNFlangeThickness), 0, 0, 0);
            
            pl.AddVertexAt(6, new Point2d(basePoint.X+section.UPNWebThickness, basePoint.Y+section.UPNHeight-dy1-dy2-section.UPNFlangeThickness), Math.Tan((-2 * Math.Atan(1) + Math.Atan(section.UPNFlangeSlope)) / 4), 0, 0);
            
            pl.AddVertexAt(7, new Point2d(basePoint.X+section.UPNWebThickness+dx1, basePoint.Y+section.UPNHeight-dy2-section.UPNFlangeThickness), 0, 0, 0);
            
            pl.AddVertexAt(8, new Point2d(basePoint.X+section.UPNFlangeWidth-dx11, basePoint.Y + section.UPNHeight - dy2 - section.UPNFlangeThickness + dy22), Math.Tan((2 * Math.Atan(1) - Math.Atan(section.UPNFlangeSlope)) / 4), 0, 0);
            
            pl.AddVertexAt(9, new Point2d(basePoint.X+section.UPNFlangeWidth, basePoint.Y + section.UPNHeight - dy2 - section.UPNFlangeThickness + dy22 + dy11), 0, 0, 0);
            
            pl.AddVertexAt(10, new Point2d(basePoint.X+section.UPNFlangeWidth, basePoint.Y + section.UPNHeight), 0, 0, 0);
            
            pl.AddVertexAt(11, new Point2d(basePoint.X, basePoint.Y + section.UPNHeight), 0, 0, 0);
            
            pl.Closed = true;

            btr.AppendEntity(pl);
            tr.AddNewlyCreatedDBObject(pl, true);

            tr.Commit();
        }
    }
}