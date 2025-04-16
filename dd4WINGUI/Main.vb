Imports System.IO
Imports System.Runtime.InteropServices
Imports Microsoft.Win32.SafeHandles
Imports System.ComponentModel
Imports System.Text
Imports System.Management

Public Class Main
    Public numbers As Integer = -1
    Public letter As String
    Public free As String
    Dim appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    Public drive_manufacturer As String
    Public drive_model As String

    Public drive_index As Integer
    Public drive_size As ULong
    Public drive_parts As Integer
    Public drive_deviceid As String

    Public part_type As String
    Public part_index As Integer ''index reltive to Disk
    Public part_size As ULong   ''size of part
    Public part_deviceid As String '' DeviceID disk part
    Public space As String
    Public outfile
    Public infile
    Public blocksize





    Private Sub refresh_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refresh_btn.Click
        HDList.Items.Clear()
        HDList.Text = ""
        HDParts.Text = ""
        HDParts.Items.Clear()
        HDParts.Enabled = False

        numbers = -1
        Dim searcher As New ManagementObjectSearcher("select * from Win32_DiskDrive")
        For Each drive In searcher.Get
            drive_model = drive("Model").ToString
            drive_deviceid = drive("DeviceID")

            drive_manufacturer = drive("Manufacturer").ToString
            drive_index = drive("Index")
            drive_size = drive("Size")
            drive_parts = drive("Partitions")
            HDList.Items.Add(drive_index & " : " & drive_model & " | " & Format((drive_size / 1073741824), "0.00") & "GB")
        Next






    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HDList.Items.Clear()
        HDList.Text = ""
        HDParts.Text = ""
        HDParts.Items.Clear()
        bsone.Checked = True
        HDParts.Enabled = False

        numbers = -1
        Dim searcher As New ManagementObjectSearcher("select * from Win32_DiskDrive")

        Dim manufacturer As String
        Dim model As String

        Dim index As Integer
        Dim size As ULong
        Dim parts As Integer

        For Each drive In searcher.Get
            model = drive("Model").ToString
            manufacturer = drive("Manufacturer").ToString
            index = drive("Index")
            size = drive("Size")
            parts = drive("Partitions")
            HDList.Items.Add(index & " : " & model & " | " & Format((size / 1073741824), "0.00") & "GB")
        Next

    End Sub

    Private Sub browse_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browse_btn.Click

        If read.Checked = True Then

            Dim SaveFileDialog1 As New SaveFileDialog()
            SaveFileDialog1.Filter = "Image files (*.img)|*.img"
            SaveFileDialog1.FilterIndex = 1
            SaveFileDialog1.RestoreDirectory = True
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim path As String = SaveFileDialog1.FileName
                browse_fld.Text = path
            End If
        End If

        If write.Checked = True Then

            Dim OpenFileDialog1 As New OpenFileDialog()
            OpenFileDialog1.Filter = "Image files (*.iso,*.img)|*.iso;*.img; |All files (*.*)|*.*"
            OpenFileDialog1.FilterIndex = 1
            OpenFileDialog1.RestoreDirectory = True
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim path As String = OpenFileDialog1.FileName
                browse_fld.Text = path
            End If
        End If

    End Sub

    Private Sub read_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub write_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles write.CheckedChanged
        If write.Checked = True Then
            browse_btn.Text = "Browse"
            browse_fld.Text = ""
            browse_btn.Enabled = True

        End If
    End Sub

    Private Sub read_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles read.CheckedChanged
        If read.Checked = True Then
            browse_btn.Text = "Save Image"
            browse_fld.Text = ""
            browse_btn.Enabled = True
        End If
    End Sub

    Private Sub HDList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HDList.SelectedIndexChanged
        HDParts.Items.Clear()
        HDParts.Text = ""
        HDParts.Enabled = True
        Dim HDindex As String = HDList.SelectedItem.ToString()
        'MsgBox(HDindex)
        HDindex = HDindex.Substring(0, 1)
        Dim searcher As New ManagementObjectSearcher("select * from Win32_DiskPartition")
        HDParts.Items.Add("Whole Disk")
        For Each drive In searcher.Get
            part_index = drive("Index")
            part_size = drive("Size")
            part_deviceid = drive("DeviceID")
            part_type = drive("type")
            'MsgBox(part_type)
            If part_deviceid.Contains("Disk #" & HDindex) Then
                If part_type = ("Installable File System") Then
                    HDParts.Items.Add("Drive:" & HDindex & " Part:" & part_index + 1 & " | " & Format((part_size / 1073741824), "0.00") & "GB")
                End If
            End If
        Next

    End Sub

    Private Sub exit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    Private Sub bsone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsone.CheckedChanged
        bsother_box.Enabled = False
        bsother_box.Text = ""
        blocksize = "1M"

    End Sub

    Private Sub bstwo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bstwo.CheckedChanged
        bsother_box.Enabled = False
        bsother_box.Text = ""
        blocksize = "512"
    End Sub

    Private Sub bsother_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsother.CheckedChanged
        bsother_box.Enabled = True
        blocksize = bsother_box.Text
    End Sub

    Private Sub start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles start.Click
        If HDList.SelectedIndex = -1 Then
            MsgBox("Please Select a Disk Drive")
            Exit Sub
        End If
        If HDParts.SelectedIndex = -1 Then
            MsgBox("Please Select a Partition")
            Exit Sub
        End If

        If browse_fld.Text = "" Then
            MsgBox("No Image Selected")
            Exit Sub
        End If


        If write.Checked = True Then

            '------------- Check System Drive! -------------
            numbers = -1
            Dim systemDirectory As String
            systemDirectory = System.Environment.SystemDirectory
            Dim SystemDrive = systemDirectory.Substring(0, 3)
            ' MsgBox(SystemDrive)
            Dim HDindex As String = HDList.SelectedItem.ToString()
            HDindex = HDindex.Substring(0, 1)

            Dim syscheck = SystemDrive & " " & HDindex
            Dim drivechk As New List(Of String)

            Try
                Dim drives() As DriveInfo = DriveInfo.GetDrives()
                For Each di As DriveInfo In drives
                    If di.IsReady Then
                        Dim info As String = di.DriveType
                        letter = di.Name


                        If info.Equals("3") Then
                            numbers = numbers + 1
                            drivechk.Add(letter & " " & numbers)

                        End If
                        If info.Equals("2") Then
                            numbers = numbers + 1
                            'numbers = drive number from wmi
                            drivechk.Add(letter & " " & numbers)

                        End If
                    End If
                Next di
                Console.ReadLine()
            Catch ex As Exception
                ' handle ex
            End Try

            ' Dim sResult As String = String.Join(" | ", drivechk.ToArray())
            ' MsgBox(sResult)

            If drivechk.Contains(syscheck) Then
                MsgBox("System Drive Selected! I WILL NOT write to the system drive!")
                Exit Sub
            Else

            End If


            drivechk.Clear()
            '------------- END System Drive! -------------

            ''Begin code for DD win
            Dim hdpart = HDParts.SelectedItem.ToString
            ' MsgBox(hdpart)

            If hdpart = "Whole Disk" Then
                hdpart = HDList.SelectedItem.ToString()
                space = hdpart.Substring(hdpart.IndexOf("|"c) + 1)
                space = space.Substring(0, space.Length - 2)

                Dim inputfile As New FileInfo(browse_fld.Text)
                Dim inputfilesize As Long = inputfile.Length

                If (inputfilesize / 1073741824) > space Then

                    MsgBox("Not enough space left on Target Drive")
                    Exit Sub
                End If

                Dim hd = HDList.SelectedItem.ToString()
                hd = hd.Substring(0, 1)
                Dim driveletter As Char = Chr(hd + 65)
                driveletter = Char.ToLower(driveletter)
                outfile = "/dev/sd" & driveletter & " bs=" & blocksize & " status=progress"


                ' MsgBox(outfile)
            Else
                space = hdpart.Substring(hdpart.IndexOf("|"c) + 1)
                space = space.Substring(0, space.Length - 2)

                Dim inputfile As New FileInfo(browse_fld.Text)
                Dim inputfilesize As Long = inputfile.Length
                ' MsgBox(inputfilesize)
                ' MsgBox(space)
                If (inputfilesize / 1073741824) > space Then

                    MsgBox("Not enough space left on Target Drive")
                    Exit Sub
                End If

                Dim hd = HDList.SelectedItem.ToString()
                hd = hd.Substring(0, 1)
                Dim driveletter As Char = Chr(hd + 65)
                driveletter = Char.ToLower(driveletter)
                Dim drivenumber As String
                drivenumber = HDParts.SelectedIndex.ToString()
                outfile = "/dev/sd" & driveletter & drivenumber & " bs=" & blocksize & " status=progress"
                ' MsgBox(outfile)
            End If
            infile = browse_fld.Text
            Dim textdrive = HDList.SelectedItem.ToString() & " -> " & HDParts.SelectedItem.ToString()

            Select Case MsgBox("Drive Write!" & vbCrLf & vbCrLf & "File: " & infile & vbCrLf & vbCrLf & "Drive: " & textdrive & "" & vbCrLf & vbCrLf & "ALL DATA ON SELECTED DRIVE WILL BE OVERWRITTEN!" & vbCrLf & "Hit 'Yes' to continue.", MsgBoxStyle.YesNo, "Simple Disk Dump - Drive Write!")
                Case MsgBoxResult.Yes
                    Dim output As String = String.Format(" if={0} of={1}", infile, outfile)
                    Dim ddimage As New Process
                    ddimage = Process.Start(Application.StartupPath & "/ddcrygwin/dd.exe", arguments:=output)
                    Me.Hide()
                    ddimage.WaitForExit()
                    Me.Show()
                    MsgBox("Complete!")
                Case MsgBoxResult.No
                    Exit Sub
            End Select



            '' code for dd win

            ''end write check
        End If




        If read.Checked = True Then



            '------------- Check Freesapce Drive! -------------
            Dim save_target = browse_fld.Text
            save_target = save_target.Substring(0, 3)
            Dim hdpart = HDParts.SelectedItem.ToString
            ' MsgBox(hdpart)

            If hdpart = "Whole Disk" Then
                hdpart = HDList.SelectedItem.ToString()
                space = hdpart.Substring(hdpart.IndexOf("|"c) + 1)
                space = space.Substring(0, space.Length - 2)
                ' MsgBox(space)

            Else
                space = hdpart.Substring(hdpart.IndexOf("|"c) + 1)
                space = space.Substring(0, space.Length - 2)
                ' MsgBox(space)
            End If
            numbers = -1
            Try

                Dim drives() As DriveInfo = DriveInfo.GetDrives()
                For Each di As DriveInfo In drives
                    If di.IsReady Then
                        Dim info As String = di.DriveType

                        Dim letter As String = di.Name
                        Dim free As String = di.AvailableFreeSpace
                        If letter = save_target Then
                            If (free / 1073741824) > space Then
                            Else
                                MsgBox("Not enough space left on device")
                                Exit Sub
                            End If
                        End If
                    End If
                Next di
                Console.ReadLine()
            Catch ex As Exception
                ' handle ex
            End Try

            '------------- END Freesapce Drive! -------------



            ''Begin code for DD win
            hdpart = HDParts.SelectedItem.ToString
            ' MsgBox(hdpart)

            If hdpart = "Whole Disk" Then
                Dim hd = HDList.SelectedItem.ToString()
                hd = hd.Substring(0, 1)
                Dim driveletter As Char = Chr(hd + 65)
                driveletter = Char.ToLower(driveletter)
                infile = "/dev/sd" & driveletter


                ' MsgBox(outfile)
            Else
                Dim hd = HDList.SelectedItem.ToString()
                hd = hd.Substring(0, 1)
                Dim driveletter As Char = Chr(hd + 65)
                driveletter = Char.ToLower(driveletter)
                Dim drivenumber As String
                drivenumber = HDParts.SelectedIndex.ToString()
                infile = "/dev/sd" & driveletter & drivenumber
                ' MsgBox(outfile)
            End If


            outfile = browse_fld.Text & " bs=" & blocksize & " status=progress"
            Dim textdrive = HDList.SelectedItem.ToString() & " -> " & HDParts.SelectedItem.ToString()

            Select Case MsgBox("Drive Read!" & vbCrLf & vbCrLf & "Drive: " & textdrive & vbCrLf & vbCrLf & "File: " & browse_fld.Text & "" & vbCrLf & vbCrLf & "ALL DATA ON SELECTED DRIVE WILL BE SAVED TO FILE!" & vbCrLf & "Hit 'Yes' to continue.", MsgBoxStyle.YesNo, "Simple Disk Dump - Drive Read! ")
                Case MsgBoxResult.Yes
                    Dim output As String = String.Format(" if={0} of={1}", infile, outfile)
                    Dim ddimage As New Process
                    ddimage = Process.Start(Application.StartupPath & "/ddcrygwin/dd.exe", arguments:=output)
                    Me.Hide()
                    ddimage.WaitForExit()
                    Me.Show()
                    MsgBox("Complete!")
                Case MsgBoxResult.No
                    Exit Sub
            End Select

            '' code for dd win

        End If



    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs)

    End Sub
End Class

