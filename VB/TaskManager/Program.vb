Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports TaskManager.TaskDatabase
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo

Namespace TaskManager
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            DevExpress.Skins.SkinManager.EnableFormSkins()

            ConnectionHelper.Connect(AutoCreateOption.None)
            XpoDefault.Session = New Session()

            Application.Run(New Form1())
        End Sub
    End Class
End Namespace