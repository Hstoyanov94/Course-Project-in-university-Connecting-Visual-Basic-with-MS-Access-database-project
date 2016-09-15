Public Class Form1

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TortiDataSet.Bought' table. You can move, or remove it, as needed.
        Me.BoughtTableAdapter.Fill(Me.TortiDataSet.Bought)
        'TODO: This line of code loads data into the 'TortiDataSet.Shipment' table. You can move, or remove it, as needed.
        Me.ShipmentTableAdapter.Fill(Me.TortiDataSet.Shipment)
        'TODO: This line of code loads data into the 'TortiDataSet.Cake' table. You can move, or remove it, as needed.
        Me.CakeTableAdapter.Fill(Me.TortiDataSet.Cake)
        'TODO: This line of code loads data into the 'TortiDataSet.Member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me.TortiDataSet.Member)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MemberBindingSource.MoveNext()
        CakeBindingSource.MoveNext()
        ShipmentBindingSource.MoveNext()
        BoughtBindingSource.MoveNext()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MemberBindingSource.MovePrevious()
        CakeBindingSource.MovePrevious()
        ShipmentBindingSource.MovePrevious()
        BoughtBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MemberBindingSource.AddNew()
        CakeBindingSource.AddNew()
        ShipmentBindingSource.AddNew()
        BoughtBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error GoTo SaveErr
        MemberBindingSource.EndEdit()
        MemberTableAdapter.Update(TortiDataSet.Member)
        CakeBindingSource.EndEdit()
        CakeTableAdapter.Update(TortiDataSet.Cake)
        ShipmentBindingSource.EndEdit()
        ShipmentTableAdapter.Update(TortiDataSet.Shipment)
        BoughtBindingSource.EndEdit()
        BoughtTableAdapter.Update(TortiDataSet.Bought)
        MessageBox.Show("Промените са запазени")
SaveErr:
        Exit Sub
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MemberBindingSource.RemoveCurrent()
        CakeBindingSource.RemoveCurrent()
        ShipmentBindingSource.RemoveCurrent()
        BoughtBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
