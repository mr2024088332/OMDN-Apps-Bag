Public Class 计算机
    Private Sub 联系我们ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 联系我们ToolStripMenuItem.Click
        Name = MsgBox("Email:2024088332@qq.com       mr2024088332@outlook.com", vbBoolean, "联系我们")
    End Sub

    Private Sub 关于ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
        Name = MsgBox("本软件开源,禁止用于商业用途", vbYes, "关于,OMDN工作室制作")
        Name = MsgBox("你的免费序列号是OMDN: 1.0    2HSH3-SADJ2-SJD34-DSDDA-DSA34", vbYes, "激活情况")
    End Sub

    Private Sub 计算机_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
