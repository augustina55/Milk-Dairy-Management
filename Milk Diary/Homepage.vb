Public Class Homepage

    Private Sub buttonPurchase_Click(sender As Object, e As EventArgs) Handles buttonPurchase.Click
        panel4.Height = buttonPurchase.Height
        panel4.Top = buttonPurchase.Top
        panel3.Controls.Clear()

        Dim frm = New purchase
        frm.TopLevel = False
        panel3.Controls.Add(frm)
        frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panel4.Height = buttonPurchase.Height
        panel4.Top = buttonPurchase.Top
        panel3.Controls.Clear()

        Dim frm = New purchase
        frm.TopLevel = False
        panel3.Controls.Add(frm)
        frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        frm.Show()

        Dim sess = New session
        sess.ShowDialog()

    End Sub

    Private Sub buttonStaff_Click(sender As Object, e As EventArgs) Handles buttonStaff.Click
        panel4.Height = buttonStaff.Height
        panel4.Top = buttonStaff.Top
        panel3.Controls.Clear()

        Dim frm = New staff
        frm.TopLevel = False
        panel3.Controls.Add(frm)
        frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub buttonSearch_Click(sender As Object, e As EventArgs) Handles buttonSearch.Click
        panel4.Height = buttonSearch.Height
        panel4.Top = buttonSearch.Top
        panel3.Controls.Clear()

        Dim frm = New search
        frm.TopLevel = False
        panel3.Controls.Add(frm)
        frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub ButtonStock_Click(sender As Object, e As EventArgs) Handles ButtonStock.Click
        panel4.Height = ButtonStock.Height
        panel4.Top = ButtonStock.Top
        panel3.Controls.Clear()

        Dim frm = New stock
        frm.TopLevel = False
        panel3.Controls.Add(frm)
        frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub buttonTransaction_Click(sender As Object, e As EventArgs) Handles buttonTransaction.Click
        panel4.Height = buttonTransaction.Height
        panel4.Top = buttonTransaction.Top
        panel3.Controls.Clear()

        Dim frm = New transaction

        frm.TopLevel = False
        panel3.Controls.Add(frm)
        frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Dim result = MessageBox.Show(" Are you sure you want to quit", "Are you sure?",
                                     MessageBoxButtons.YesNoCancel)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub buttonSales_Click_1(sender As Object, e As EventArgs) Handles buttonSales.Click
        panel4.Height = buttonSales.Height
        panel4.Top = buttonSales.Top
        panel3.Controls.Clear()

        Dim frm = New sales
        frm.TopLevel = False
        panel3.Controls.Add(frm)
        frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub
End Class