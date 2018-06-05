Imports System.Data.SqlClient
Public Class MemberControlComponent
    Public Sub setAutoID()
        txtMemberID.Text = Val(getMaxID("Member_Detail", "[MID]").ToString()) + 1
    End Sub
    Private Sub MemberControlComponent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectDatabase()
        txtMemberBikeID.Focus()
        setAutoID()
    End Sub
    '@SaveMember Function
    Sub SaveMember()
        If txtMemberBikeID.Text = "" Then
            MessageBox.Show("ກະລຸນາປ້ອນຂໍ້ມູນໃຫ້ຄົບ", "ຜົນນການກວດສອບ")
            txtMemberBikeID.Focus()
            Exit Sub
        End If
        Try
            'dr.Close()
            '(Licence,LicenceName,BName,Model,Machine_Number,color,Name,LName,CardID,Adress,Tel,Email) 
            cmd = New SqlCommand("Insert into Member_Detail values(@Licence,@LicenceName,@BName,@Model,@Machine_Number,@color,@Name,@LName,@CardID,@Adress,@Tel,@Email)", conn)
            cmd.Parameters.AddWithValue("Licence", txtMemberBikeID.Text)
            cmd.Parameters.AddWithValue("LicenceName", cbBikeIDname.Text)
            cmd.Parameters.AddWithValue("BName", txtBName.Text)
            cmd.Parameters.AddWithValue("Model", txtBModel.Text)
            cmd.Parameters.AddWithValue("Machine_Number", txtBMachineNumber.Text)
            cmd.Parameters.AddWithValue("color", txtBcolor.Text)
            cmd.Parameters.AddWithValue("Name", txtMName.Text)
            cmd.Parameters.AddWithValue("LName", txtMLName.Text)
            cmd.Parameters.AddWithValue("CardID", txtMCardID.Text)
            cmd.Parameters.AddWithValue("Adress", txtMembrAdress.Text)
            cmd.Parameters.AddWithValue("Tel", txtMphone.Text)
            cmd.Parameters.AddWithValue("Email", txtMEmail.Text)
            cmd.ExecuteNonQuery()

            ClearMemberDetail()
            txtMemberBikeID.Focus()
            MsgBox(" ບັນທຶກຂໍ້ມູນແລ້ວ", MsgBoxStyle.Information, "ການບັນທຶກຂໍ້ມູນ")
            setAutoID()
        Catch ex As Exception
        End Try
    End Sub
    '@Edit MemberDetail 
    Sub EditMember()
        Try
            If txtMemberBikeID.Text = "" Then
                MessageBox.Show("ກະລຸນາປ້ອນລະຫັດສະມາຊິກ", "ຜົນນການກວດສອບ")
                txtMemberBikeID.Focus()
                Exit Sub
            End If
            If MessageBox.Show("ທ່ານຕ້ອງການແກ້ໄຂຂໍ້ມູນນິ້ ຫຼື ບໍ່?", "ຄຳຢືນຢັນ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                cmd = New SqlCommand("update Member_Detail Set Licence=@Licence,LicenceName=@LicenceName,BName=@BName,Model=@Model,Machine_Number=@Machine_Number,color=@color,Name=@Name,LName=@LName,CardID=@CardID,Adress=@Adress,Tel=@Tel,Email=@Email where MID=@MID", conn)
                cmd.Parameters.AddWithValue("@MID", txtMemberID.Text)
                cmd.Parameters.AddWithValue("@Licence", txtMemberBikeID.Text)
                cmd.Parameters.AddWithValue("@LicenceName", cbBikeIDname.Text)
                cmd.Parameters.AddWithValue("@BName", txtBName.Text)
                cmd.Parameters.AddWithValue("@Model", txtBModel.Text)
                cmd.Parameters.AddWithValue("@Machine_Number", txtBMachineNumber.Text)
                cmd.Parameters.AddWithValue("@color", txtBcolor.Text)
                cmd.Parameters.AddWithValue("@Name", txtMName.Text)
                cmd.Parameters.AddWithValue("@LName", txtMLName.Text)
                cmd.Parameters.AddWithValue("@CardID", txtMCardID.Text)
                cmd.Parameters.AddWithValue("@Adress", txtMembrAdress.Text)
                cmd.Parameters.AddWithValue("@Tel", txtMphone.Text)
                cmd.Parameters.AddWithValue("@Email", txtMEmail.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show(" ແກ້ໄຂຂໍ້ມູນສຳເລັດແລ້ວ!", "ແກ້ໄຂຂໍ້ມູນ")
                ClearMemberDetail()
                txtMemberBikeID.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub
    '@Delete MemberDetail
    Sub DeleteMember()
        Try

            If txtMemberBikeID.Text = "" Then
                MessageBox.Show("ກາລຸນາເລືອກຂໍ້ມູນສະມາຊິກກ່ອນ", "ການລຶບຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtMemberBikeID.Focus()
                Exit Sub
            End If
            If MessageBox.Show("ທ່ານຕ້ອງການລຶບຂໍ້ມູນນີ້ ຫຼື ບໍ່?", "ຄຳຢືນຢັນການລຶບ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                cmd = New SqlCommand("delete from  Member_Detail where MID = @MID", conn)
                cmd.Parameters.AddWithValue("@MID", txtMemberID.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("ລຶບຂໍ້ມູນສຳເລັດແລ້ວ!", "ການລອບຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearMemberDetail()
                txtMemberBikeID.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub
    '@ShowMember Function
    Sub ShowMember(Member As Integer)
        Try
            'dr.Close()
            cmd = New SqlCommand("select *from Member_Detail", conn)
            da = New SqlDataAdapter(cmd)
            da.Fill(table)
            table.Clear()
            da.Fill(table)
            If (table.Rows.Count() > 0) Then
                txtMemberID.Text = table.Rows(Member)(0).ToString
                txtMemberBikeID.Text = table.Rows(Member)(1).ToString
                cbBikeIDname.Text = table.Rows(Member)(2).ToString
                txtBName.Text = table.Rows(Member)(3).ToString
                txtBModel.Text = table.Rows(Member)(4).ToString
                txtBMachineNumber.Text = table.Rows(Member)(5).ToString
                txtBcolor.Text = table.Rows(Member)(6).ToString
                txtMName.Text = table.Rows(Member)(7).ToString
                txtMLName.Text = table.Rows(Member)(8).ToString
                txtMCardID.Text = table.Rows(Member)(9).ToString
                txtMembrAdress.Text = table.Rows(Member)(10).ToString
                txtMphone.Text = table.Rows(Member)(11).ToString
                txtMEmail.Text = table.Rows(Member)(12).ToString
            Else
                MsgBox("ບໍ່ມີຂໍ້ມູນໃນລະບົບ", MsgBoxStyle.Information, "ແຈ້ງເຕືອນ")
            End If
        Catch ex As Exception
        End Try

    End Sub
    Sub SeachMember()
        'Try
        '    Dim search As String = ""
        '    If MainComponentForm.txtSearch.Text = "" Then
        '        MessageBox.Show("ກາລຸນາປ້ອນຂໍ້ມູນກ່ອນ", "ແຈ້ງເຕືອນ")
        '        Exit Sub
        '    End If
        '    'Try
        '    search = "select *from Member_Detail where MID =@MID"
        '    dr.Close()
        '    cmd = New SqlCommand(search, conn)
        '    cmd.Parameters.Add("MID", SqlDbType.NVarChar).Value = MainComponentForm.txtSearch.Text
        '    da = New SqlDataAdapter(cmd)
        '    da.Fill(table)
        '    table.Clear()
        '    da.Fill(table)
        '    If (table.Rows.Count() > 0) Then
        '        txtMemberID.Text = table.Rows(0)(0).ToString
        '        txtMemberBikeID.Text = table.Rows(0)(1).ToString
        '        cbBikeIDname.Text = table.Rows(0)(2).ToString
        '        txtBName.Text = table.Rows(0)(3).ToString
        '        txtBModel.Text = table.Rows(0)(4).ToString
        '        txtBMachineNumber.Text = table.Rows(0)(5).ToString
        '        txtBcolor.Text = table.Rows(0)(6).ToString
        '        txtMName.Text = table.Rows(0)(7).ToString
        '        txtMLName.Text = table.Rows(0)(8).ToString
        '        txtMCardID.Text = table.Rows(0)(9).ToString
        '        txtMembrAdress.Text = table.Rows(0)(10).ToString
        '        txtMphone.Text = table.Rows(0)(11).ToString
        '        txtMEmail.Text = table.Rows(0)(12).ToString
        '    Else
        '        MessageBox.Show("ບໍ່ມີຂໍ້ມູນໃນລະບົບ", "ແຂ້ງເຕືອນ")
        '        MainComponentForm.txtSearch.Clear()
        '        MainComponentForm.txtSearch.Focus()
        '    End If

        'Catch ex As Exception

        'End Try
    End Sub
    Sub ClearMemberDetail()
        txtMemberID.Clear()
        txtMemberBikeID.Clear()
        txtBName.Clear()
        txtBModel.Clear()
        txtBMachineNumber.Clear()
        txtBcolor.Clear()
        txtMName.Clear()
        txtMLName.Clear()
        txtMCardID.Clear()
        txtMembrAdress.Clear()
        txtMEmail.Clear()
        txtMphone.Clear()
        txtMEmail.Clear()
    End Sub
    Sub NextMember()
        If index < 0 Then
            index = 0
        End If
        index += 1
        If index > table.Rows.Count() - 1 Then
            index = table.Rows.Count() - 1
        End If
        ShowMember(index)
    End Sub
    Public Sub PreviousMember()
        index -= 1
        If index < 0 Then
            index = 0
        End If
        ShowMember(index)

    End Sub
    Sub FirstMember()
        index = 0
        ShowMember(index)
    End Sub
    Sub LastMember()
        index = table.Rows.Count() - 1
        ShowMember(index)
    End Sub
    Private Sub txtMemberBikeID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMemberBikeID.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtBName.Focus()
        End If
    End Sub

    Private Sub txtBName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBName.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtBModel.Focus()
        End If
    End Sub

    Private Sub txtBModel_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBModel.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtBMachineNumber.Focus()
        End If
    End Sub

    Private Sub txtBMachineNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBMachineNumber.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtBcolor.Focus()
        End If
    End Sub

    Private Sub txtBcolor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBcolor.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtMName.Focus()
        End If
    End Sub

    Private Sub txtMName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMName.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtMLName.Focus()
        End If
    End Sub

    Private Sub txtMLName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMLName.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtMCardID.Focus()
        End If
    End Sub

    Private Sub txtMCardID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMCardID.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtMembrAdress.Focus()
        End If
    End Sub

    Private Sub txtMembrAdress_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMembrAdress.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtMphone.Focus()
        End If
    End Sub

    Private Sub txtMphone_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMphone.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtMEmail.Focus()
        End If
    End Sub

    Private Sub txtMEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMEmail.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtMemberBikeID.Focus()
        End If
    End Sub

    Public Sub setSearchAutoCompletion()
        '@reset
        'dr.Close()
        Try
            MainComponentForm.AutocompleteSearch.Items = New String() {}
            MainComponentForm.AutocompleteSearch.SetAutocompleteMenu(MainComponentForm.txtSearch, MainComponentForm.AutocompleteSearch)
            Dim da_meb = getSqlDataAdapter("Select [MID] , [Licence] , [LicenceName] from Member_Detail")
            Dim ds_meb As New DataSet
            ClearTables(ds_meb, "Search_members")
            da_meb.Fill(ds_meb, "Search_members")
            If ds_meb.Tables("Search_members").Rows.Count > 0 Then
                For i As Integer = 0 To ds_meb.Tables("Search_members").Rows.Count - 1
                    Dim itemAuto As New AutocompleteMenuNS.AutocompleteItem
                    Dim dtSet = ds_meb.Tables("Search_members").Rows(i)
                    itemAuto.Text = dtSet.Item(0).ToString
                    itemAuto.ToolTipText = "Search By ID " & itemAuto.Text
                    itemAuto.ToolTipTitle = "Search A Member By ID"
                    MainComponentForm.AutocompleteSearch.AddItem(itemAuto)
                    itemAuto = New AutocompleteMenuNS.AutocompleteItem
                    'license
                    itemAuto.Text = dtSet.Item(1).ToString
                    itemAuto.ToolTipText = "Search By Licence " & itemAuto.Text
                    itemAuto.ToolTipTitle = "Search A Member By Licence"
                    MainComponentForm.AutocompleteSearch.AddItem(itemAuto)
                    'license name
                    itemAuto = New AutocompleteMenuNS.AutocompleteItem
                    'license
                    itemAuto.Text = dtSet.Item(2).ToString
                    itemAuto.ToolTipText = "Search By LicenceName " & itemAuto.Text
                    itemAuto.ToolTipTitle = "Search A Member By LicenceName"
                    MainComponentForm.AutocompleteSearch.AddItem(itemAuto)
                Next
            End If
            MainComponentForm.AutocompleteSearch.Update()
            ClearReader(ds_meb, da_meb)
        Catch ex As Exception

        End Try

    End Sub
    '@SearchAutocompleteMember
    Public Sub SearchByAutoComplete(ByVal selectItem As String)
        Try
            Dim search_ = "SELECT * FROM Member_Detail WHERE MID LIKE '%" & selectItem & "%' OR [Licence] LIKE N'%" & selectItem & "%'
                       OR [LicenceName] LIKE N'%" & selectItem & "%'"
            Dim da_meb_search = getSqlDataAdapter(search_)
            Dim dtSet_meb As New DataSet
            ClearTables(dtSet_meb, "res_member")
            da_meb_search.Fill(dtSet_meb, "res_member")
            Dim dt_data = dtSet_meb.Tables("res_member")
            If (dt_data.Rows.Count() > 0) Then
                txtMemberID.Text = dt_data.Rows(0).Item(0).ToString
                txtMemberBikeID.Text = dt_data.Rows(0).Item(1).ToString
                cbBikeIDname.Text = dt_data.Rows(0).Item(2).ToString
                txtBName.Text = dt_data.Rows(0).Item(3).ToString
                txtBModel.Text = dt_data.Rows(0).Item(4).ToString
                txtBMachineNumber.Text = dt_data.Rows(0).Item(5).ToString
                txtBcolor.Text = dt_data.Rows(0).Item(6).ToString
                txtMName.Text = dt_data.Rows(0).Item(7).ToString
                txtMLName.Text = dt_data.Rows(0).Item(8).ToString
                txtMCardID.Text = dt_data.Rows(0).Item(9).ToString
                txtMembrAdress.Text = dt_data.Rows(0).Item(10).ToString
                txtMphone.Text = dt_data.Rows(0).Item(11).ToString
                txtMEmail.Text = dt_data.Rows(0).Item(12).ToString
            Else
                MsgBox("ບໍ່ມີຂໍ້ມູນໃນລະບົບ", MsgBoxStyle.Information, "ແຂ້ງເຕືອນ")
                MainComponentForm.txtSearch.Clear()
                MainComponentForm.txtSearch.Focus()
            End If
        Catch ex As Exception

        End Try

    End Sub

End Class
