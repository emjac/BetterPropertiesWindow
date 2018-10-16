
Public Class Form1

    Dim std As Object = GetObject(, "StaadPro.OpenSTAAD")
    Dim prop As OpenSTAADUI.OSPropertyUI = std.Property
    Dim geo As OpenSTAADUI.OSGeometryUI = std.Geometry
    Dim view As OpenSTAADUI.IOSViewUI = std.View

    Dim lSectionRefs As Long
    Dim bSec As Boolean

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated



    End Sub

    Private Sub CreateDataSet()

        Dim dProp As DataTable = New DataTable
        dProp.TableName = "Sections Table"
        dProp.Columns.Add("Ref", GetType(Double))
        dProp.Columns.Add("Section", GetType(String))
        dProp.Columns.Add("Sort", GetType(Double))

        dProp.Columns.Add("Material", GetType(String))
        'dProp.Columns.Add("Iz", GetType(Double))
        'dProp.Columns.Add("Zz", GetType(Double))

        Dim dRow As DataRow
        Dim lSectionCnt As Long = prop.GetSectionPropertyCount() + prop.GetThicknessPropertyCount()
        Dim SectionName As String = ""

        For lSec As Long = 1 To lSectionCnt

            prop.GetSectionPropertyName(lSec, SectionName)

            'If SectionName.First() = "W" Then

            dRow = dProp.NewRow()

            dRow("Ref") = lSec
            'dRow("Sort") = CDbl((SectionName.Split("X")(0)).Split("W")(1)) + CDbl((SectionName.Split("X")(1)).Split("-")(0)) / 1000
            dRow("Section") = SectionName
            prop.GetSectionPropertyAssignedBeamCount(lSec)
            dRow("Material") = GetSectionMaterial(lSec)
            'dRow("Iz") = GetSectionProperty(lSec, "Iz")
            'dRow("Zz") = Math.Round(GetSectionProperty(lSec, "Iz") / GetSectionProperty(lSec, "Az"))

            dProp.Rows.Add(dRow)

            'End If

        Next

        DataSet1.Tables.Add("Sections Table")

    End Sub


    Private Sub FirstLoadDataGridView()



        LoadPropertiesTable()



        FormatGridView()

    End Sub

    Private Function GetMaterialProperty(iMat As Integer, sProperty As String) As Long

        Dim E As String = ""
        Dim Poisson As String = ""
        Dim G As String = ""
        Dim Density As String = ""
        Dim Alpha As String = ""
        Dim CrDamp As String = ""
        Dim Fy As String = ""
        Dim Fu As String = ""
        Dim Ry As String = ""
        Dim Rt As String = ""
        Dim Fcu As String = ""

        prop.GetIsotropicMaterialPropertiesEx(iMat, E, Poisson, G, Density, Alpha, CrDamp, Fy, Fu, Ry, Rt, Fcu)

        Select Case sProperty
            Case "E"
                Return (E)
            Case "Poisson"
                Return (Poisson)
            Case "G"
                Return (G)
            Case "Density"
                Return (Density)
            Case Alpha
                Return (Alpha)
            Case CrDamp
                Return (CrDamp)
            Case "Fy"
                Return (Fy)
            Case "Fu"
                Return (Fu)
            Case "Ry"
                Return (Ry)
            Case "Rt"
                Return (Rt)
            Case "Fcu"
                Return (Fcu)
            Case Else
                Return ("")
        End Select

    End Function

    Private Sub RefreshPropertiesTable()



    End Sub

    Private Sub DataGridView(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SectionDataGridView.CellClick

        If Not e.RowIndex = -1 Then

            Dim oValue As Object = SectionDataGridView.Rows(e.RowIndex).Cells(0).Value

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

    Private Sub LoadPropertiesTable()

        SectionDataGridView.DataSource = DataSet1.Tables("Sections Table")

    End Sub

    Private Sub FilterDataGridView(searchString As String, dProp As DataTable)

        Dim dvFilter As DataView = New DataView(dProp)

        dvFilter.RowFilter = "Section like '%" + searchString + "%'"
        SectionDataGridView.DataSource = dvFilter

    End Sub

    Private Sub FormatGridView()

        Dim colRef As DataGridViewColumn = SectionDataGridView.Columns(0)
        Dim colSort As DataGridViewColumn = SectionDataGridView.Columns(2)
        Dim colSec As DataGridViewColumn = SectionDataGridView.Columns(1)
        'Dim colWeight As DataGridViewColumn = SectonDataGridView.Columns(3)
        Dim colMat As DataGridViewColumn = SectionDataGridView.Columns(3)
        'Dim colIz As DataGridViewColumn = SectonDataGridView.Columns(5)
        'Dim colZz As DataGridViewColumn = SectonDataGridView.Columns(6)

        'SectonDataGridView.Width = 380

        colRef.Width = 40
        colSec.Width = 100
        colSort.Width = 30
        'colWeight.Width = 40
        colMat.Width = 100
        'colIz.Width = 20
        'colZz.Width = 20

    End Sub

    Private Function GetSectionMaterial(lSection As Long) As String
        'Returns material property of a beam

        Dim lBeamList() As Integer
        Dim sReturn As String = ""

        ReDim lBeamList(0 To prop.GetSectionPropertyAssignedBeamCount(lSection) - 1)

        If Not lBeamList.Length = 0 Then
            prop.GetSectionPropertyAssignedBeamList(lSection, lBeamList)
            Return (prop.GetBeamMaterialName(lBeamList(0)))
        Else
            Return ("")
        End If

    End Function

    Private Function GetSectionProperty(lSection As Long, sName As String) As Double

        'Takes section reference number and string containing name of property request eg. "Ix" and returns value of Ix

        Dim width As Double
        Dim depth As Double
        Dim Ix As Double
        Dim Iy As Double
        Dim Iz As Double
        Dim Ax As Double
        Dim Ay As Double
        Dim Az As Double
        Dim Tf As Double
        Dim Tw As Double

        prop.GetSectionPropertyValues(lSection, width, depth, Ax, Ay, Az, Ix, Iy, Iz, Tf, Tw)

        Select Case sName
            Case "width"
                Return (width)
            Case "depth"
                Return (depth)
            Case "Ax"
                Return (Ax)
            Case "Ay"
                Return (Ay)
            Case "Az"
                Return (Az)
            Case "Ix"
                Return (Ix)
            Case "Iy"
                Return (Iy)
            Case "Iz"
                Return (Iz)
            Case "Tf"
                Return (Tf)
            Case "Tw"
                Return (Tw)
            Case Else
                Return (vbNull)
        End Select

    End Function

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TopMost = True

        Dim sFileName As String = ""

        std.GetSTAADFile(sFileName, True)

        TextBoxFileName.Text = sFileName

        view.SetModeSectionPage(0, 3, 6)

        FirstLoadDataGridView()

    End Sub

    Private Sub AssignToSelectedButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AssignToSelectedButton.Click

        Dim lRef As Long
        Dim SelBeamsCnt As Long

        SelBeamsCnt = geo.GetNoOfSelectedBeams

        Dim SelBeams(SelBeamsCnt - 1) As Integer
        geo.GetSelectedBeams(SelBeams, 1)

        lRef = SectionDataGridView.CurrentRow.Cells(0).Value

        prop.AssignBeamProperty(SelBeams, lRef)

    End Sub

    Private Sub CopyNodeNumButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CopyNodeNumButton.Click
        CopyNodesAsTable()
    End Sub

    Private Sub CopyBeamNumButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CopyBeamNumButton.Click
        CopyBeamsAsTable()
    End Sub

    Private Sub ButtonBump_Click(sender As Object, e As EventArgs) Handles BumpButton.Click
        BeamBumper()
        RefreshPropertiesTable()
    End Sub

    Private Sub BeamBumper()

        'Increases the weight of selected W sections to the next weight in their depth class

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

    End Sub

    Private Sub CopyNodesAsTable()

        'Copies the node numbers for the nodes that are selected to the clipboard

        Dim SelNodesNo As Long = geo.GetNoOfSelectedNodes
        Dim SelNodes() As Integer
        Dim NodeString As String = ""

        If SelNodesNo > 0 Then
            ReDim SelNodes(SelNodesNo - 1)
            geo.GetSelectedNodes(SelNodes, 1)

            For i = 0 To SelNodesNo - 1
                NodeString = NodeString & (SelNodes(i)) & vbCrLf
            Next

            Clipboard.SetText(NodeString)

        End If

    End Sub

    Private Sub CopyBeamsAsTable()

        'Copies the element numbers for the beams that are selected to the clipboard

        Dim SelBeamsNo As Long
        SelBeamsNo = geo.GetNoOfSelectedBeams
        Dim SelBeams() As Integer
        Dim BeamString As String = ""

        If SelBeamsNo > 0 Then

            ReDim SelBeams(SelBeamsNo - 1)
            geo.GetSelectedBeams(SelBeams, 1)

            For i = 0 To SelBeamsNo - 1
                BeamString = BeamString & (SelBeams(i)) & vbCrLf
            Next i

            Clipboard.SetText(BeamString)

        End If

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs)
        Dim lRef As Long
        lRef = SectionDataGridView.CurrentRow.Cells(0).Value
        prop.DeleteProperty(lRef)
        RefreshPropertiesTable()
    End Sub

    Private Sub Test(sender As Object, e As EventArgs) Handles TextBoxFilter.TextChanged

        FilterDataGridView(TextBoxFilter.Text, DataSet1.Tables("Sections Table"))

    End Sub

End Class


