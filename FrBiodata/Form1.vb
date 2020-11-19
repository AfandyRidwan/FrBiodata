Public Class Form1

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        cmStatus.Items.Add("Menikah")
        cmStatus.Items.Add("Belum Menikah")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.txtNIM.Text = "201902015"
        Me.txtNama.Text = "Asep Ridwan Afandy"


        Me.txtAlamat.Text = "Gg. Desa Sidamulya, Sidamulya, Cipunagara, Subang"
        Me.txtKota.Text = "Subang"
        Me.txtTlp.Text = "082321062430"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.txtNIM.Clear()
        Me.txtNama.Clear()
        Me.txtAlamat.Clear()
        Me.txtKota.Clear()
        Me.txtTlp.Clear()

    End Sub
End Class
