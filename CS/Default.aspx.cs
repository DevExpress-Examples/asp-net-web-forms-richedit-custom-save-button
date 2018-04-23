using DevExpress.Web;
using DevExpress.Web.ASPxThemes;
using DevExpress.XtraRichEdit;
using System;
using System.IO;
using System.Web;
using System.Web.Services;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RichEdit.CreateDefaultRibbonTabs(true);
        RichEdit.RibbonTabs[0].Groups[0].Items.Clear();

        for (int i = 1; i < RichEdit.RibbonTabs.Count; i++)
            RichEdit.RibbonTabs[i].Visible = false;

        var saveItem = new RibbonButtonItem("Save");
        saveItem.LargeImage.IconID = IconID.SaveSave32x32;
        saveItem.Size = RibbonItemSize.Large;
        RichEdit.RibbonTabs[0].Groups[0].Items.Add(saveItem);
    }
}