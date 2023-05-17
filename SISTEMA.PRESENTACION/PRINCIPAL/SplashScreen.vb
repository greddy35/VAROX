Public Class SplashScreen
    Sub New
        InitializeComponent()
        Me.labelCopyright.Text = "Copyright © 1998-" & DateTime.Now.Year.ToString()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        Centrar(Me)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

End Class
