Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim setURL As String
        setURL = "http://cache.lego.com/r/dynamic/is/image/LEGO/" + TextBox1.Text + "?op_sharpen=1&resMode=sharp4&wid=500&fit=constrain,1&fmt=png-alpha"
        PictureBox1.ImageLocation = setURL
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim boxURL As String
        boxURL = "http://cache.lego.com/r/dynamic/is/image/LEGO/" + TextBox1.Text + "_alt1?op_sharpen=1&resMode=sharp4&wid=500&fit=constrain,1&fmt=png-alpha"
        PictureBox1.ImageLocation = boxURL
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://cache.lego.com/r/dynamic/is/image/LEGO/" + TextBox1.Text + "_alt1?op_sharpen=1&resMode=sharp4&wid=500&fit=constrain,1&fmt=png-alpha")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("http://cache.lego.com/r/dynamic/is/image/LEGO/" + TextBox1.Text + "_alt1?op_sharpen=1&resMode=sharp4&wid=1000&fit=constrain,1&fmt=png-alpha")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        System.Diagnostics.Process.Start("http://cache.lego.com/r/dynamic/is/image/LEGO/" + TextBox1.Text + "_alt1?op_sharpen=1&resMode=sharp4&wid=2000&fit=constrain,1&fmt=png-alpha")
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        System.Diagnostics.Process.Start("http://cache.lego.com/r/dynamic/is/image/LEGO/" + TextBox1.Text + "_alt1?op_sharpen=1&resMode=sharp4&wid=4000&fit=constrain,1&fmt=png-alpha")
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        System.Diagnostics.Process.Start("http://cache.lego.com/r/dynamic/is/image/LEGO/" + TextBox1.Text + "?op_sharpen=1&resMode=sharp4&wid=4000&fit=constrain,1&fmt=png-alpha")
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        System.Diagnostics.Process.Start("http://cache.lego.com/r/dynamic/is/image/LEGO/" + TextBox1.Text + "?op_sharpen=1&resMode=sharp4&wid=2000&fit=constrain,1&fmt=png-alpha")
    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        System.Diagnostics.Process.Start("http://cache.lego.com/r/dynamic/is/image/LEGO/" + TextBox1.Text + "?op_sharpen=1&resMode=sharp4&wid=1000&fit=constrain,1&fmt=png-alpha")
    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        System.Diagnostics.Process.Start("http://cache.lego.com/r/dynamic/is/image/LEGO/" + TextBox1.Text + "?op_sharpen=1&resMode=sharp4&wid=500&fit=constrain,1&fmt=png-alpha")
    End Sub

End Class
