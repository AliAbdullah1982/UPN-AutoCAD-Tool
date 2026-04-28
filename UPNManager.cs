using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;

public class UPNManager
{
    private Editor _ed;

    public UPNManager(Editor ed)
    {
        _ed = ed;
    }

    public void Run()
    {
        // 1️⃣ Get all UPN sections from repository
        var sections = UPNRepository.GetAll();

        // 2️⃣ Let user select a UPN section
        var selected = UPNSelector.Select(_ed, sections);

        if (selected == null)
        {
            _ed.WriteMessage("\nNo selection made.");
            return;
        }

        // 3️⃣ Display selected result (temporary step)
        _ed.WriteMessage($"\nSelected UPN: {selected.Name}");
        UPNDrawer drawer = new UPNDrawer();
        drawer.Draw(selected, new Autodesk.AutoCAD.Geometry.Point3d(0, 0, 0));

        // 4️⃣ Next step will be:
        // - Get insertion point (UPNInput)
        // - Draw section (UPNDrawer)
    }
}