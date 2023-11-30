Imports DevExpress.Web
Imports DevExpress.Web.ASPxThemes
Imports DevExpress.XtraRichEdit
Imports System
Imports System.IO
Imports System.Web
Imports System.Web.Services

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		RichEdit.CreateDefaultRibbonTabs(True)
		RichEdit.RibbonTabs(0).Groups(0).Items.Clear()

		For i As Integer = 1 To RichEdit.RibbonTabs.Count - 1
			RichEdit.RibbonTabs(i).Visible = False
		Next i

		Dim saveItem = New RibbonButtonItem("Save")
		saveItem.LargeImage.IconID = IconID.SaveSave32x32
		saveItem.Size = RibbonItemSize.Large
		RichEdit.RibbonTabs(0).Groups(0).Items.Add(saveItem)
	End Sub
End Class