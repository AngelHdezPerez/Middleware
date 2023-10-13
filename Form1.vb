Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ObjWsEjeMiddleware As New WsEjeMiddleware.Service
        Dim DsX As New DataSet

        DsX = ObjWsEjeMiddleware.FnListarRegistros
        Me.DGVPersonas.DataSource = DsX.Tables("Personas")
    End Sub
End Class
