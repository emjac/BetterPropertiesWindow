
Public Class Form1

    Dim std As Object = GetObject(, "StaadPro.OpenSTAAD")

    Dim prop As OpenSTAADUI.OSPropertyUI = std.Property
    Dim geo As OpenSTAADUI.OSGeometryUI = std.Geometry


    Dim lSectionRefs As Long
    Dim bSec As Boolean

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        Me.TopMost = True

        LoadDataIntoDataGridView()

    End Sub

    Private Sub LoadDataIntoDataGridView()

        With DataGridView1

            Dim dProp = New DataTable
            Dim dRow As DataRow
            Dim lBeamList() As Integer
            Dim bSec As Boolean
            Dim width As Double
            Dim depth As Double
            Dim Ix As Double
            Dim Iy As Double
            Dim Iz As Double
            Dim Ax As Double
            Dim Ay As Double
            Dim Az As Double
            Dim lSectionCnt As Long = prop.GetSectionPropertyCount()

            .Width = 380

            dProp.Columns.Add("Ref")
            dProp.Columns.Add("Section")
            dProp.Columns.Add("Material")
            dProp.Columns.Add("Iz")
            dProp.Columns.Add("Zz")

            For lSec As Long = 1 To lSectionCnt
                dRow = dProp.NewRow()
                dRow("Ref") = lSec
                dRow("Section") = "s"

                prop.GetSectionPropertyName(lSec, dRow("Section"))
                prop.GetSectionPropertyAssignedBeamCount(lSec)

                ReDim lBeamList(0 To prop.GetSectionPropertyAssignedBeamCount(lSec) - 1)

                If Not lBeamList.Length = 0 Then
                    bSec = prop.GetSectionPropertyAssignedBeamList(lSec, lBeamList)
                    dRow("Material") = prop.GetBeamMaterialName(lBeamList(0))
                    dRow("Iz") = prop.GetBeamProperty(lBeamList(0), width, depth, Ax, Ay, Az, Ix, Iy, Iz)
                    If Not Ax = 0 Then
                        Dim Zz As Long = Math.Round(Iz / Az)
                        dRow("Iz") = Iz
                        dRow("Zz") = Zz
                    End If
                End If

                dProp.Rows.Add(dRow)

            Next

            .DataSource = dProp

        End With

        Dim colRef As DataGridViewColumn = DataGridView1.Columns(0)
        Dim colSec As DataGridViewColumn = DataGridView1.Columns(1)
        Dim colMat As DataGridViewColumn = DataGridView1.Columns(2)
        Dim colIz As DataGridViewColumn = DataGridView1.Columns(3)
        Dim colZz As DataGridViewColumn = DataGridView1.Columns(4)

        colRef.Width = 40
        colSec.Width = 125
        colMat.Width = 80
        colIz.Width = 50
        colZz.Width = 50

        bSec = prop.GetSectionPropertyList(lSectionRefs)
    End Sub

    Private Sub DataGridView(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If Not e.RowIndex = -1 Then

            Dim oValue As Object = DataGridView1.Rows(e.RowIndex).Cells(0).Value

            Dim iChk As Boolean = CheckBox1.Checked

            If iChk Then
                geo.ClearMemberSelection()
                Dim lBeamList() As Integer
                prop.GetSectionPropertyAssignedBeamCount(oValue)
                ReDim lBeamList(0 To prop.GetSectionPropertyAssignedBeamCount(oValue) - 1)
                bSec = prop.GetSectionPropertyAssignedBeamList(oValue, lBeamList)
                geo.SelectMultipleBeams(lBeamList)
            End If

        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'comment
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim lRef As Long
        Dim SelBeamsCnt As Long

        SelBeamsCnt = geo.GetNoOfSelectedBeams

        Dim SelBeams(SelBeamsCnt - 1) As Integer
        geo.GetSelectedBeams(SelBeams, 1)

        lRef = DataGridView1.CurrentRow.Cells(0).Value

        prop.AssignBeamProperty(SelBeams, lRef)

        LoadDataIntoDataGridView()

    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BeamBumper()

        Dim i As Integer
        Dim SelBeamsNo As Long
        Dim SelBeams() As Integer
        Dim Country As Long
        Dim SectionName As String
        Dim SectionNameBumped As String
        Dim TypeSpec As Long
        Dim Ref As Long
        Dim Mat As String
        Dim dSectionWeight As Double
        Dim sSectionWeight As Double
        Dim X_Pos As Double
        Dim BumpChk As Boolean
        Dim SectionClass As String

        Country = 1 ' USA USA!
        TypeSpec = 0

        SelBeamsNo = geo.GetNoOfSelectedBeams

        If SelBeamsNo > 0 Then
            ReDim SelBeams(SelBeamsNo - 1)

            geo.GetSelectedBeams(SelBeams, 1)

            For i = 0 To SelBeamsNo - 1

                SectionName = prop.GetBeamSectionName(SelBeams(i))

                Dim ChkW As Boolean = IIf(Strings.Left(SectionName, 1) = "W", True, False)

                If ChkW Then 'Zero for ST  Sections
                    BumpChk = 0

                    X_Pos = InStr(SectionName, "X")
                    sSectionWeight = Strings.Right(SectionName, Strings.Len(SectionName) - X_Pos)
                    dSectionWeight = Convert.ToDouble(sSectionWeight)
                    SectionClass = Strings.Left(SectionName, X_Pos)
                    Mat = prop.GetBeamMaterialName(SelBeams(i))

                    While Not BumpChk

                        dSectionWeight = dSectionWeight + 1
                        SectionNameBumped = Trim(SectionClass & CStr(dSectionWeight))
                        Ref = prop.CreateBeamPropertyFromTable(Country, SectionNameBumped, TypeSpec, 0.0, 0.0)
                        BumpChk = prop.AssignBeamProperty(SelBeams(i), Ref)
                        prop.AssignMaterialToMember(Mat, SelBeams(i))

                    End While
                End If


            Next i

        End If

        LoadDataIntoDataGridView()

    End Sub

    Private Sub ButtonBump_Click(sender As Object, e As EventArgs) Handles ButtonBump.Click
        BeamBumper()
    End Sub
End Class

