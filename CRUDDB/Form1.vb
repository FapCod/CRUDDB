Imports System.Data.SqlClient

Public Class CRUDDB
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=ALUMNOS;Integrated Security=True")
    Dim sentencia, mensaje As String

    Private Sub picCerrar_Click(sender As Object, e As EventArgs) Handles picCerrar.Click
        Me.Close()
    End Sub

    Private Sub picMinimizar_Click(sender As Object, e As EventArgs) Handles picMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub picMaximizar_Click(sender As Object, e As EventArgs) Handles picMaximizar.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Sub Mostar()
        Dim da As New SqlDataAdapter("select * from alumno", conexion)
        Dim ds As New DataSet

        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        conexion.Close()
    End Sub
    Sub EjecutarSql(sql As String, msg As String)
        Try
            Dim cmd As New SqlCommand(sql, conexion)
            conexion.Open()
            cmd.ExecuteNonQuery()
            conexion.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub btnAGREGAR_Click(sender As Object, e As EventArgs) Handles btnAGREGAR.Click
        panelPuntero.Height = btnAGREGAR.Height
        panelPuntero.Top = btnAGREGAR.Top
        sentencia = "insert into alumno values('" + txtDNI.Text + "', '" + txtNOMBRE.Text + "','" + txtApellido.Text + "','" + txtGRADO.Text + "')"
        mensaje = "Datos insertados correctamente"
        EjecutarSql(sentencia, mensaje)
        Mostar()
    End Sub

    Private Sub btnEDITAR_Click(sender As Object, e As EventArgs) Handles btnEDITAR.Click
        panelPuntero.Height = btnEDITAR.Height
        panelPuntero.Top = btnEDITAR.Top
        sentencia = "update alumno set nombre='" + txtNOMBRE.Text + "', apillido='" + txtApellido.Text + "', grado='" + txtGRADO.Text + "' where dni='" + txtDNI.Text + "'"
        mensaje = "Datos actualizados correctamente"
        EjecutarSql(sentencia, mensaje)
        Mostar()
    End Sub

    Private Sub btnBUSCAR_Click(sender As Object, e As EventArgs) Handles btnBUSCAR.Click
        panelPuntero.Height = btnBUSCAR.Height
        panelPuntero.Top = btnBUSCAR.Top
        Mostar()
    End Sub

    Private Sub btnELIMINAR_Click(sender As Object, e As EventArgs) Handles btnELIMINAR.Click
        panelPuntero.Height = btnELIMINAR.Height
        panelPuntero.Top = btnELIMINAR.Top
        sentencia = "delete from alumno where dni='" + txtDNI.Text + "'"
        mensaje = "Datos eliminados correctamente"
        EjecutarSql(sentencia, mensaje)
        Mostar()
    End Sub
End Class
