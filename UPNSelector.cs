using System.Collections.Generic;
using Autodesk.AutoCAD.EditorInput;

public static class UPNSelector
{
    public static UPNSection Select(Editor ed, List<UPNSection> sections)
    {
        PromptKeywordOptions pko = new PromptKeywordOptions("\nSelect UPN section:");

        // عرض كل المقاطع
        foreach (var s in sections)
        {
            pko.Keywords.Add(s.Name);
        }

        pko.AllowNone = false;

        PromptResult pr = ed.GetKeywords(pko);

        if (pr.Status != PromptStatus.OK)
            return null;

        // إرجاع العنصر المختار
        return sections.Find(x => x.Name == pr.StringResult);
    }
}