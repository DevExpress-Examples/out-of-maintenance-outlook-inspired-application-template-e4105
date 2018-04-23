Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers


Namespace TaskManager
    Partial Public Class Form1
        Inherits RibbonForm

        Public Sub New()
            InitializeComponent()
            InitSkinGallery()
            schedulerControl.Start = Date.Now
        End Sub
        Private Sub InitSkinGallery()
            SkinHelper.InitSkinGallery(rgbiSkins, True)
        End Sub

    End Class
End Namespace