#Region "Imports"
Imports System
Imports Microsoft.VisualBasic
Imports System.Runtime.InteropServices
Imports StayinFront.Shell
Imports StayinFront.Shell.Net
Imports StayinFront.Engine
Imports StayinFront.Engine.Net
Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
Imports StayinFront.Engine.Utility
Imports [minBaseClass] = System.Object
Imports [stdCompositeEdit] = System.Object
Imports [stdPersonName] = System.Object
Imports [minPerson] = System.Object
Imports [stdCountry] = System.Object
Imports [stdState] = System.Object
Imports [stdBaseAddress] = System.Object
Imports [stdAddress] = System.Object
Imports [stdPhoneNumber] = System.Object
Imports [stdeMailAddress] = System.Object
Imports [stdRecordStamp] = System.Object
Imports [stdDocument] = System.Object
Imports [CompositeDate] = System.Object
Imports [AlternateContact] = System.Object
Imports [stdPicklist] = System.Object
Imports [pikTaxcode] = System.Object
Imports [EmploymentDetail] = System.Object
Imports [stdWWWAddress] = System.Object
Imports [stdPerson] = System.Object
Imports [Candidate] = System.Object
Imports [minOrganization] = System.Object
Imports [stdOrganization] = System.Object
Imports [Organisation] = System.Object
Imports [ContactDepartment] = System.Object
Imports [Contact] = System.Object
Imports [Department] = System.Object
Imports [JobAssociation] = System.Object
Imports [Invoice] = System.Object
Imports [Timesheet] = System.Object
Imports [JobAssignment] = System.Object
Imports [PrefTempSupplierTitle] = System.Object
Imports [Job] = System.Object
Imports [stdTimeStamp] = System.Object
Imports [CandidateExpense] = System.Object
Imports [IncidentHistory] = System.Object
Imports [CandidateIncidentHistory] = System.Object
Imports [DepartmentHS] = System.Object
Imports [Document] = System.Object
Imports [Division] = System.Object
Imports [stdUser] = System.Object
Imports [SystemObj] = System.Object
Imports [ClassObj] = System.Object
Imports [Segment] = System.Object
Imports [Bucket] = System.Object
Imports [ViewGroup] = System.Object
Imports [View] = System.Object
Imports [PermitBase] = System.Object
Imports [PermitUser] = System.Object
Imports [GroupMember] = System.Object
Imports [UserGroup] = System.Object
Imports [PermitGroup] = System.Object
Imports [stdConfiguration] = System.Object
Imports [stdPostCode] = System.Object
Imports [MergeDoc] = System.Object
Imports [WF_Queue] = System.Object
Imports [WF_ServerGroup] = System.Object
Imports [WF_AppPool] = System.Object
Imports [WF_Process] = System.Object
Imports [WF_Job] = System.Object
Imports [WF_PendingWork] = System.Object
Imports [MM_PendingWork] = System.Object
Imports [WF_History] = System.Object
Imports [stdBaseClass] = System.Object
Imports [LG_Event] = System.Object
Imports [WF_LogEvent] = System.Object
Imports [WF_State] = System.Object
Imports [WF_Server] = System.Object
Imports [WF_ServerGroupWF_Server] = System.Object
Imports [WF_PendingWorkLock] = System.Object
Imports [WF_ServerGroupWF_AppPool] = System.Object
Imports [WF_ServerWF_AppPool] = System.Object
Imports [LG_Info] = System.Object
Imports [LG_Warning] = System.Object
Imports [LG_Error] = System.Object
Imports [LG_Detail] = System.Object
Imports [LG_ErrorDetail] = System.Object
Imports [LG_WarningDetail] = System.Object
Imports [Report] = System.Object
Imports [DayInfo] = System.Object
Imports [UserStore] = System.Object
Imports [UT_IDNumber] = System.Object
Imports [UT_MsgBox] = System.Object
Imports [Prof_ProfileValue] = System.Object
Imports [Prof_ProfileCategory] = System.Object
Imports [Prof_ProfileClass] = System.Object
Imports [Prof_AppliesTo] = System.Object
Imports [Prof_SelProfile] = System.Object
Imports [minActivity] = System.Object
Imports [stdColor] = System.Object
Imports [CandidateAttendee] = System.Object
Imports [ContactAttendee] = System.Object
Imports [JobActivity] = System.Object
Imports [Float] = System.Object
Imports [stdActivity] = System.Object
Imports [stdCallActivity] = System.Object
Imports [stdLetter] = System.Object
Imports [ImportDocument] = System.Object
Imports [MergeGeneric] = System.Object
Imports [stdTaskActivity] = System.Object
Imports [stdEmailActivity] = System.Object
Imports [stdFaxActivity] = System.Object
Imports [stdMeetingActivity] = System.Object
Imports [stdPhoneCallActivity] = System.Object
Imports [ActivityReminder] = System.Object
Imports [UserAttendee] = System.Object
Imports [Referee] = System.Object
Imports [TempJob] = System.Object
Imports [PermJob] = System.Object
Imports [SkillGroup] = System.Object
Imports [CandidateSkill] = System.Object
Imports [Skill] = System.Object
Imports [CandidateApproachedCompany] = System.Object
Imports [Test] = System.Object
Imports [CandidateTest] = System.Object
Imports [Industry] = System.Object
Imports [CandidateProfile] = System.Object
Imports [OrganisationProfile] = System.Object
Imports [Advertiser] = System.Object
Imports [AdvertisementType] = System.Object
Imports [Advertisement] = System.Object
Imports [PreviousEmployment] = System.Object
Imports [QCBatch] = System.Object
Imports [QC] = System.Object
Imports [Special] = System.Object
Imports [Leave] = System.Object
Imports [JobDocument] = System.Object
Imports [City] = System.Object
Imports [JobCandidate] = System.Object
Imports [PermPlacement] = System.Object
Imports [TempAssignment] = System.Object
Imports [ContractEngagement] = System.Object
Imports [ContractJob] = System.Object
Imports [UnavailableTime] = System.Object
Imports [QCContractEngagement] = System.Object
Imports [QCTempAssignment] = System.Object
Imports [QCPermPlacementCandidate] = System.Object
Imports [QCPermNotPlacedCandidate] = System.Object
Imports [WeeklyCallSchedule] = System.Object
Imports [QCPermPlacementClient] = System.Object
Imports [InterviewActivity] = System.Object
Imports [NextCallSchedule] = System.Object
Imports [ContactProfile] = System.Object
Imports [JobProfile] = System.Object
Imports [MedicalTest] = System.Object
Imports [CandidateMedicalTest] = System.Object
Imports [ImmunisationHistory] = System.Object
Imports [CandidateImmunisationHistory] = System.Object
Imports [MissedShift] = System.Object
Imports [CandidateInvoice] = System.Object
Imports [CandidateEquipment] = System.Object
Imports [Budget] = System.Object
Imports [CandidateTraining] = System.Object
Imports [HSGroup] = System.Object
Imports [HS] = System.Object
Imports [Candidate_HS] = System.Object
Imports [HS_Incident] = System.Object
Imports [HS_Event] = System.Object
#End Region

#Region "forms"
<AutoGenerated> _
Public Class [MergeDoc_Jobs_form]
	Inherits [MergeDoc_form]

'****************************************************************************
' Do not debug in this generated code.  Debug the original AEF directly.
'****************************************************************************
#ExternalSource("MailMerge.aef",326)
Shared Dim iRefreshButId as Integer = -1
Shared Dim iRestartButId as Integer = -1
Shared Dim bWorkDeleted as Boolean = False

Function CreateImageList() as IntPtr
	Dim mmImgList as ImageList
	mmImgList = new ImageList
	
	Dim resImages() as String = { "MMRefresh", "MMRestart" } 
	
	For Each sRes as String In resImages
		Dim aeRes as IAeResource
		aeRes = TheSystem.Aspect("ActivElk.Resource").Item(sRes)
		If Not aeRes Is Nothing Then
			Dim stm as MemoryStream
			stm = new MemoryStream(aeRes.Binary)
			Try
				Dim img as Image = Bitmap.FromStream(stm)
				mmImgList.Images.Add(img)
			Catch e as ArgumentException
			End Try
		End If
	Next
	
	Return  mmImgList.Handle
End Function

Sub Jobs_Init()

	Dim JobsTab as FormForm = Form.Controls.Item("Tabs").Item("Jobs")
	Dim oGridCtrl as FormControl = JobsTab.Controls.Item("MailMergeJobs")
	
	Dim oGrid as IElkGrid178 = oGridCtrl.Control
	Dim otlbar as IElk9Toolbar
	otlbar = oGrid.ToolbarControl
	
	Dim nOffSet as Integer
	nOffSet = otlbar.AddImageList("Mail Merge Jobs Images", CreateImageList())
	
	Dim sButCap as String 
	Dim otlbarBut as IElk9ToolbarButton
	If iRefreshButId = -1 Or otlbar.Item(iRefreshButId) Is Nothing Then	 	
	 	sButCap = TheSystem.LoadString("RefreshBut_Cap")
		otlbarBut = otlbar.AddButton(sButCap, , nOffSet, 1)
		otlbarBut.Type = 0 
		otlbarBut.Enabled = True
		otlbarBut.AutoShowCaption = True
		otlbarBut.AutoSize = True  
		iRefreshButId = otlbarBut.Id
	End If
	
	If iRestartButId = -1 or otlbar.Item(iRestartButId) is nothing Then
		sButCap = TheSystem.LoadString("RestartBut_Cap")
		otlbarBut = otlbar.AddButton(sButCap, , nOffSet + 1, 1)
		otlbarBut.Type = 0 
		otlbarBut.Enabled = false
		otlbarBut.AutoShowCaption = True
		otlbarBut.AutoSize = True  
		iRestartButId = otlbarBut.Id
	End If 
End Sub

Sub MailMergeJobs_OnToolbarCommand(button as IElk9ToolbarButton, menuItemId as Integer, pHandled as Boolean)
	
	Dim JobsTab as FormForm = Form.Controls.Item("Tabs").Item("Jobs")
	Dim oGridCtrl as FormControl = JobsTab.Controls.Item("MailMergeJobs")
	Dim oGrid as IElkGrid = oGridCtrl.Control
	Dim otlbar as IElk9Toolbar
	otlbar = oGrid.ToolbarControl          
    
    pHandled = False      
	If button.ID = iRefreshButId Then
		If bWorkDeleted Then
			If (MessageBox.Show(TheSystem.LoadString("JobGridChanged"), Form.Object.Prompt(""), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No)
				bWorkDeleted = False
			End If
		End If
		
 		If bWorkDeleted Then
 			Dim oFrmtlbar as IElk9Toolbar = Form.Toolbar
 			oFrmtlbar.FireStandardCommand(_elkToolbarStandardButton.elkSave) 
 		Else
			oGrid.Refresh()
		End If
		pHandled = True
	ElseIf button.ID = iRestartButId Then
		Dim iSelRow as Integer
		iSelRow = oGrid.SelectedRow 
		If iSelRow > -1 And iSelRow < oGrid.RowCount Then
			Dim objMMJob as MM_PendingWork
			objMMJob = oGrid.RowObject(iSelRow)
			If not objMMJob is nothing Then
				If objMMJob.Status.Value.Value = "E" or objMMJob.Status.Value.Value = "X" Then
				    TheSystem.MMPendingWork_Restart(objMMJob) 
				    objMMJob.Save
				End If
			End If
		End If
		pHandled = True
	ElseIf button.ID = _elkToolbarStandardButton.elkDelete Then
		Dim iSelRow as Integer
		iSelRow = oGrid.SelectedRow 
		If iSelRow > -1 And iSelRow < oGrid.RowCount Then
			bWorkDeleted = True
		End If
	End If
End Sub

Sub MailMergeJobs_OnToolbarStateChange()

	Dim JobsTab as FormForm = Form.Controls.Item("Tabs").Item("Jobs")
	Dim oGridCtrl as FormControl = JobsTab.Controls.Item("MailMergeJobs")
	Dim oGrid as IElkGrid = oGridCtrl.Control 
	
	Dim otlbar as IElk9Toolbar
	otlbar = oGrid.ToolbarControl
	' Enable/disable restart button on toolbar if it exists	
	If iRestartButId <> -1 And Not otlbar.Item(iRestartButId) Is Nothing Then

		Dim iSelRow as Integer
		iSelRow = oGrid.SelectedRow 
		Dim otlbarBut as IElk9ToolbarButton
		otlbarBut =	otlbar.Item(iRestartButId)
		If iSelRow > -1 And iSelRow < oGrid.RowCount Then
			Dim objMMJob as MM_PendingWork
			objMMJob = oGrid.RowObject(iSelRow)
			If not objMMJob is nothing Then
				If objMMJob.Status.Value.Value = "E" Or objMMJob.Status.Value.Value = "X" Then
 	            	otlbarBut.Enabled = true
 	            Else
 	            	otlbarBut.Enabled = false
				End If 
			End If
		Else
			otlbarBut.Enabled = False
		End If
	End If
End Sub

Sub Form_Init()
	bWorkDeleted = False
End Sub

Sub Form_PostSave()
	bWorkDeleted = False
End Sub
#End ExternalSource

	<AutoGenerated> _
	Readonly Shadows Property [Tabs] As StayinFront.Shell.FormTabStrip
		Get
			[Tabs] = Controls("Tabs")
		End Get
	End Property
End Class

<AutoGenerated> _
Public Class [MergeDoc_form]
	Inherits [Object_form]
	<AutoGenerated> _
	Public Sub [Path_Choose]()
		ThisObj.InvokeAsForm("MergeDoc","Path_Choose",Nothing)
	End Sub
	<AutoGenerated> _
	Readonly Shadows Property [Path] As StayinFront.Shell.FormEdit
		Get
			[Path] = Controls("Path")
		End Get
	End Property
	<AutoGenerated> _
	Readonly Shadows Property [CommCtl] As StayinFront.Shell.FormControl
		Get
			[CommCtl] = Controls("CommCtl")
		End Get
	End Property
	<AutoGenerated> _
	Readonly Shadows Property [Tabs] As StayinFront.Shell.FormTabStrip
		Get
			[Tabs] = Controls("Tabs")
		End Get
	End Property
End Class

<AutoGenerated> _
Public Class [Object_form]
	Inherits [Object_0__form]
	<AutoGenerated> _
	Readonly Shadows Property [Tabs] As StayinFront.Shell.FormTabStrip
		Get
			[Tabs] = Controls("Tabs")
		End Get
	End Property
End Class

<AutoGenerated> _
Public Class [Object_0__form]
	Inherits StayinFront.Shell.Scripting.ShellForm
	<AutoGenerated> _
	Readonly Shadows Property [Title] As StayinFront.Shell.FormEdit
		Get
			[Title] = Controls("Title")
		End Get
	End Property
	<AutoGenerated> _
	Readonly Shadows Property [Tabs] As StayinFront.Shell.FormTabStrip
		Get
			[Tabs] = Controls("Tabs")
		End Get
	End Property
	<AutoGenerated> _
	ReadOnly Shadows Property TheSystem() As Model
		Get
			Return CType(MyBase.TheSystem,Model)
		End Get
	End Property

End Class

#End Region

#Region "menus"
#End Region

