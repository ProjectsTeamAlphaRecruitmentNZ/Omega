#Region "Imports"
Imports System
Imports Microsoft.VisualBasic
Imports System.Runtime.InteropServices
Imports StayinFront.Engine
Imports StayinFront.Engine.Net
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

Public NotInheritable Class Model
	Inherits StayinFront.Engine.Scripting.SystemBase
	#Region "folders"
	<AutoGenerated> _
	Public Function [Activities]() As IAeFolder
		[Activities]=Folders("Activities")
	End Function
	<AutoGenerated> _
	Public Function [Tasks]() As IAeFolder
		[Tasks]=Folders("Tasks")
	End Function
	<AutoGenerated> _
	Public Function [Communications]() As IAeFolder
		[Communications]=Folders("Communications")
	End Function
	<AutoGenerated> _
	Public Function [Candidate]() As IAeFolder
		[Candidate]=Folders("Candidate")
	End Function
	<AutoGenerated> _
	Public Function [Reminders]() As IAeFolder
		[Reminders]=Folders("Reminders")
	End Function
	<AutoGenerated> _
	Public Function [Referee]() As IAeFolder
		[Referee]=Folders("Referee")
	End Function
	<AutoGenerated> _
	Public Function [TempJob]() As IAeFolder
		[TempJob]=Folders("TempJob")
	End Function
	<AutoGenerated> _
	Public Function [PermJob]() As IAeFolder
		[PermJob]=Folders("PermJob")
	End Function
	<AutoGenerated> _
	Public Function [Skills]() As IAeFolder
		[Skills]=Folders("Skills")
	End Function
	<AutoGenerated> _
	Public Function [Jobs]() As IAeFolder
		[Jobs]=Folders("Jobs")
	End Function
	<AutoGenerated> _
	Public Function [SkillGroup]() As IAeFolder
		[SkillGroup]=Folders("SkillGroup")
	End Function
	<AutoGenerated> _
	Public Function [Tests]() As IAeFolder
		[Tests]=Folders("Tests")
	End Function
	<AutoGenerated> _
	Public Function [Industry]() As IAeFolder
		[Industry]=Folders("Industry")
	End Function
	<AutoGenerated> _
	Public Function [Person]() As IAeFolder
		[Person]=Folders("Person")
	End Function
	<AutoGenerated> _
	Public Function [PrefTempSupplierTitle]() As IAeFolder
		[PrefTempSupplierTitle]=Folders("PrefTempSupplierTitle")
	End Function
	<AutoGenerated> _
	Public Function [Organisation]() As IAeFolder
		[Organisation]=Folders("Organisation")
	End Function
	<AutoGenerated> _
	Public Function [Department]() As IAeFolder
		[Department]=Folders("Department")
	End Function
	<AutoGenerated> _
	Public Function [Advertisement]() As IAeFolder
		[Advertisement]=Folders("Advertisement")
	End Function
	<AutoGenerated> _
	Public Function [Contact]() As IAeFolder
		[Contact]=Folders("Contact")
	End Function
	<AutoGenerated> _
	Public Function [ActiveContact]() As IAeFolder
		[ActiveContact]=Folders("ActiveContact")
	End Function
	<AutoGenerated> _
	Public Function [Consultants]() As IAeFolder
		[Consultants]=Folders("Consultants")
	End Function
	<AutoGenerated> _
	Public Function [ActiveUsers]() As IAeFolder
		[ActiveUsers]=Folders("ActiveUsers")
	End Function
	<AutoGenerated> _
	Public Function [ContactDepartment]() As IAeFolder
		[ContactDepartment]=Folders("ContactDepartment")
	End Function
	<AutoGenerated> _
	Public Function [Advertisers]() As IAeFolder
		[Advertisers]=Folders("Advertisers")
	End Function
	<AutoGenerated> _
	Public Function [QCs]() As IAeFolder
		[QCs]=Folders("QCs")
	End Function
	<AutoGenerated> _
	Public Function [Document]() As IAeFolder
		[Document]=Folders("Document")
	End Function
	<AutoGenerated> _
	Public Function [Leave]() As IAeFolder
		[Leave]=Folders("Leave")
	End Function
	<AutoGenerated> _
	Public Function [Prof_ProfileValue]() As IAeFolder
		[Prof_ProfileValue]=Folders("Prof_ProfileValue")
	End Function
	<AutoGenerated> _
	Public Function [Candidate_ProfileValue]() As IAeFolder
		[Candidate_ProfileValue]=Folders("Candidate_ProfileValue")
	End Function
	<AutoGenerated> _
	Public Function [Organisation_ProfileValue]() As IAeFolder
		[Organisation_ProfileValue]=Folders("Organisation_ProfileValue")
	End Function
	<AutoGenerated> _
	Public Function [Contact_ProfileValue]() As IAeFolder
		[Contact_ProfileValue]=Folders("Contact_ProfileValue")
	End Function
	<AutoGenerated> _
	Public Function [Job_ProfileValue]() As IAeFolder
		[Job_ProfileValue]=Folders("Job_ProfileValue")
	End Function
	<AutoGenerated> _
	Public Function [Cities]() As IAeFolder
		[Cities]=Folders("Cities")
	End Function
	<AutoGenerated> _
	Public Function [PermPlacements]() As IAeFolder
		[PermPlacements]=Folders("PermPlacements")
	End Function
	<AutoGenerated> _
	Public Function [TempAssignments]() As IAeFolder
		[TempAssignments]=Folders("TempAssignments")
	End Function
	<AutoGenerated> _
	Public Function [ContractEngagements]() As IAeFolder
		[ContractEngagements]=Folders("ContractEngagements")
	End Function
	<AutoGenerated> _
	Public Function [ContractJob]() As IAeFolder
		[ContractJob]=Folders("ContractJob")
	End Function
	<AutoGenerated> _
	Public Function [Invoices]() As IAeFolder
		[Invoices]=Folders("Invoices")
	End Function
	<AutoGenerated> _
	Public Function [JobAssignments]() As IAeFolder
		[JobAssignments]=Folders("JobAssignments")
	End Function
	<AutoGenerated> _
	Public Function [ContractQCs]() As IAeFolder
		[ContractQCs]=Folders("ContractQCs")
	End Function
	<AutoGenerated> _
	Public Function [TempQCs]() As IAeFolder
		[TempQCs]=Folders("TempQCs")
	End Function
	<AutoGenerated> _
	Public Function [PermPlacementCandQCs]() As IAeFolder
		[PermPlacementCandQCs]=Folders("PermPlacementCandQCs")
	End Function
	<AutoGenerated> _
	Public Function [PermNotPlacedQCs]() As IAeFolder
		[PermNotPlacedQCs]=Folders("PermNotPlacedQCs")
	End Function
	<AutoGenerated> _
	Public Function [QCBatch]() As IAeFolder
		[QCBatch]=Folders("QCBatch")
	End Function
	<AutoGenerated> _
	Public Function [Division]() As IAeFolder
		[Division]=Folders("Division")
	End Function
	<AutoGenerated> _
	Public Function [WeeklyCallSchedule]() As IAeFolder
		[WeeklyCallSchedule]=Folders("WeeklyCallSchedule")
	End Function
	<AutoGenerated> _
	Public Function [PermPlacementClientQCs]() As IAeFolder
		[PermPlacementClientQCs]=Folders("PermPlacementClientQCs")
	End Function
	<AutoGenerated> _
	Public Function [Timesheets]() As IAeFolder
		[Timesheets]=Folders("Timesheets")
	End Function
	<AutoGenerated> _
	Public Function [ContactCallSchedule]() As IAeFolder
		[ContactCallSchedule]=Folders("ContactCallSchedule")
	End Function
	<AutoGenerated> _
	Public Function [Float]() As IAeFolder
		[Float]=Folders("Float")
	End Function
	<AutoGenerated> _
	Public Function [MedicalTest]() As IAeFolder
		[MedicalTest]=Folders("MedicalTest")
	End Function
	<AutoGenerated> _
	Public Function [ImmunisationHistory]() As IAeFolder
		[ImmunisationHistory]=Folders("ImmunisationHistory")
	End Function
	<AutoGenerated> _
	Public Function [pikTaxCode]() As IAeFolder
		[pikTaxCode]=Folders("pikTaxCode")
	End Function
	<AutoGenerated> _
	Public Function [CandidateExpense]() As IAeFolder
		[CandidateExpense]=Folders("CandidateExpense")
	End Function
	<AutoGenerated> _
	Public Function [DepartmentHS]() As IAeFolder
		[DepartmentHS]=Folders("DepartmentHS")
	End Function
	<AutoGenerated> _
	Public Function [HSGroup]() As IAeFolder
		[HSGroup]=Folders("HSGroup")
	End Function
	<AutoGenerated> _
	Public Function [HS]() As IAeFolder
		[HS]=Folders("HS")
	End Function
	<AutoGenerated> _
	Public Function [HS_Incident]() As IAeFolder
		[HS_Incident]=Folders("HS_Incident")
	End Function
	<AutoGenerated> _
	Public Function [HS_Event]() As IAeFolder
		[HS_Event]=Folders("HS_Event")
	End Function
	<AutoGenerated> _
	Public Function [CandidateIncidentHistory]() As IAeFolder
		[CandidateIncidentHistory]=Folders("CandidateIncidentHistory")
	End Function
	<AutoGenerated> _
	Public Function [Users]() As IAeFolder
		[Users]=Folders("Users")
	End Function
	<AutoGenerated> _
	Public Function [Segments]() As IAeFolder
		[Segments]=Folders("Segments")
	End Function
	<AutoGenerated> _
	Public Function [Buckets]() As IAeFolder
		[Buckets]=Folders("Buckets")
	End Function
	<AutoGenerated> _
	Public Function [Views]() As IAeFolder
		[Views]=Folders("Views")
	End Function
	<AutoGenerated> _
	Public Function [ViewGroups]() As IAeFolder
		[ViewGroups]=Folders("ViewGroups")
	End Function
	<AutoGenerated> _
	Public Function [UserGroups]() As IAeFolder
		[UserGroups]=Folders("UserGroups")
	End Function
	<AutoGenerated> _
	Public Function [stdConfiguration]() As IAeFolder
		[stdConfiguration]=Folders("stdConfiguration")
	End Function
	<AutoGenerated> _
	Public Function [Configurations]() As IAeFolder
		[Configurations]=Folders("Configurations")
	End Function
	<AutoGenerated> _
	Public Function [Countries]() As IAeFolder
		[Countries]=Folders("Countries")
	End Function
	<AutoGenerated> _
	Public Function [States]() As IAeFolder
		[States]=Folders("States")
	End Function
	<AutoGenerated> _
	Public Function [PostCodes]() As IAeFolder
		[PostCodes]=Folders("PostCodes")
	End Function
	<AutoGenerated> _
	Public Function [MergeDocs]() As IAeFolder
		[MergeDocs]=Folders("MergeDocs")
	End Function
	<AutoGenerated> _
	Public Function [MM_PendingWork]() As IAeFolder
		[MM_PendingWork]=Folders("MM_PendingWork")
	End Function
	<AutoGenerated> _
	Public Function [WF_MailMergeProcesses]() As IAeFolder
		[WF_MailMergeProcesses]=Folders("WF_MailMergeProcesses")
	End Function
	<AutoGenerated> _
	Public Function [WF_PendingWork]() As IAeFolder
		[WF_PendingWork]=Folders("WF_PendingWork")
	End Function
	<AutoGenerated> _
	Public Function [WF_PendingWorkByUser]() As IAeFolder
		[WF_PendingWorkByUser]=Folders("WF_PendingWorkByUser")
	End Function
	<AutoGenerated> _
	Public Function [WF_PendingWorkHidden]() As IAeFolder
		[WF_PendingWorkHidden]=Folders("WF_PendingWorkHidden")
	End Function
	<AutoGenerated> _
	Public Function [WorkflowQueues]() As IAeFolder
		[WorkflowQueues]=Folders("WorkflowQueues")
	End Function
	<AutoGenerated> _
	Public Function [WF_Processes]() As IAeFolder
		[WF_Processes]=Folders("WF_Processes")
	End Function
	<AutoGenerated> _
	Public Function [WF_MaintenanceProcesses]() As IAeFolder
		[WF_MaintenanceProcesses]=Folders("WF_MaintenanceProcesses")
	End Function
	<AutoGenerated> _
	Public Function [WF_LogEvent]() As IAeFolder
		[WF_LogEvent]=Folders("WF_LogEvent")
	End Function
	<AutoGenerated> _
	Public Function [Workflow_Jobs]() As IAeFolder
		[Workflow_Jobs]=Folders("Workflow Jobs")
	End Function
	<AutoGenerated> _
	Public Function [WF_State]() As IAeFolder
		[WF_State]=Folders("WF_State")
	End Function
	<AutoGenerated> _
	Public Function [WF_ServerGroup]() As IAeFolder
		[WF_ServerGroup]=Folders("WF_ServerGroup")
	End Function
	<AutoGenerated> _
	Public Function [WF_Server]() As IAeFolder
		[WF_Server]=Folders("WF_Server")
	End Function
	<AutoGenerated> _
	Public Function [WF_PendingWorkLock]() As IAeFolder
		[WF_PendingWorkLock]=Folders("WF_PendingWorkLock")
	End Function
	<AutoGenerated> _
	Public Function [WF_AppPool]() As IAeFolder
		[WF_AppPool]=Folders("WF_AppPool")
	End Function
	<AutoGenerated> _
	Public Function [LG_Event]() As IAeFolder
		[LG_Event]=Folders("LG_Event")
	End Function
	<AutoGenerated> _
	Public Function [LG_SystemEvent]() As IAeFolder
		[LG_SystemEvent]=Folders("LG_SystemEvent")
	End Function
	<AutoGenerated> _
	Public Function [LG_Info]() As IAeFolder
		[LG_Info]=Folders("LG_Info")
	End Function
	<AutoGenerated> _
	Public Function [LG_Warning]() As IAeFolder
		[LG_Warning]=Folders("LG_Warning")
	End Function
	<AutoGenerated> _
	Public Function [LG_Error]() As IAeFolder
		[LG_Error]=Folders("LG_Error")
	End Function
	<AutoGenerated> _
	Public Function [Reports]() As IAeFolder
		[Reports]=Folders("Reports")
	End Function
	<AutoGenerated> _
	Public Function [DayInfo]() As IAeFolder
		[DayInfo]=Folders("DayInfo")
	End Function
	<AutoGenerated> _
	Public Function [UT_IDNumber]() As IAeFolder
		[UT_IDNumber]=Folders("UT_IDNumber")
	End Function
	<AutoGenerated> _
	Public Function [Prof_ProfileCategory]() As IAeFolder
		[Prof_ProfileCategory]=Folders("Prof_ProfileCategory")
	End Function
	<AutoGenerated> _
	Public Function [Prof_ProfileClass]() As IAeFolder
		[Prof_ProfileClass]=Folders("Prof_ProfileClass")
	End Function
	<AutoGenerated> _
	Public Function [Letters]() As IAeFolder
		[Letters]=Folders("Letters")
	End Function
	<AutoGenerated> _
	Public Function [ImportDocument]() As IAeFolder
		[ImportDocument]=Folders("ImportDocument")
	End Function
	<AutoGenerated> _
	Public Function [MergeGeneric]() As IAeFolder
		[MergeGeneric]=Folders("MergeGeneric")
	End Function
	#End Region
	#Region "scripted methods"
	<AutoGenerated> _
	Public Sub [Elk9ScriptFn]([hWnd] As Object, [scriptName] As Object, [propertyName] As Object)
		Dim __args__() As Object = { [hWnd], [scriptName], [propertyName] }
		ThisObj.InvokeMethod("Elk9ScriptFn",__args__)
	End Sub
	<AutoGenerated> _
	Public Sub [Startup]([hWnd] As Object)
		Dim __args__() As Object = { [hWnd] }
		ThisObj.InvokeMethod("Startup",__args__)
	End Sub
	<AutoGenerated> _
	Public Sub [Elk9Startup]([hWnd] As Object)
		Dim __args__() As Object = { [hWnd] }
		ThisObj.InvokeMethod("Elk9Startup",__args__)
	End Sub
	<AutoGenerated> _
	Public Sub [Shutdown]([hWnd] As Object)
		Dim __args__() As Object = { [hWnd] }
		ThisObj.InvokeMethod("Shutdown",__args__)
	End Sub
	<AutoGenerated> _
	Public Sub [Elk9Shutdown]([hWnd] As Object)
		Dim __args__() As Object = { [hWnd] }
		ThisObj.InvokeMethod("Elk9Shutdown",__args__)
	End Sub
	<AutoGenerated> _
	Public Function [CanShutdown]([hWnd] As Object) As Object
		Dim __args__() As Object = { [hWnd] }
		[CanShutdown] = ThisObj.InvokeMethod("CanShutdown",__args__)
	End Function
	<AutoGenerated> _
	Public Function [Elk9CanShutdown]([hWnd] As Object) As Object
		Dim __args__() As Object = { [hWnd] }
		[Elk9CanShutdown] = ThisObj.InvokeMethod("Elk9CanShutdown",__args__)
	End Function
	<AutoGenerated> _
	Public Function [OptimizeSegments]([Progress] As Object) As Object
		Dim __args__() As Object = { [Progress] }
		[OptimizeSegments] = ThisObj.InvokeMethod("OptimizeSegments",__args__)
	End Function
	<AutoGenerated> _
	Public Function [Configuration]() As Object
		[Configuration] = ThisObj.InvokeMethod("Configuration",Nothing)
	End Function
	<AutoGenerated> _
	Public Function [GetConfiguration]() As Object
		[GetConfiguration] = ThisObj.InvokeMethod("GetConfiguration",Nothing)
	End Function
	<AutoGenerated> _
	Public Sub [IndexStandardToolbarButtons]()
		ThisObj.InvokeMethod("IndexStandardToolbarButtons",Nothing)
	End Sub
	<AutoGenerated> _
	Public Function [GetToolbarImageIndex]([ButtonName] As Object) As Object
		Dim __args__() As Object = { [ButtonName] }
		[GetToolbarImageIndex] = ThisObj.InvokeMethod("GetToolbarImageIndex",__args__)
	End Function
	<AutoGenerated> _
	Public Function [NVL]([tstrValue] As Object, [tstrDefault] As Object) As Object
		Dim __args__() As Object = { [tstrValue], [tstrDefault] }
		[NVL] = ThisObj.InvokeMethod("NVL",__args__)
	End Function
	<AutoGenerated> _
	Public Function [IsNullEnum]([pEnumMember] As Object) As Object
		Dim __args__() As Object = { [pEnumMember] }
		[IsNullEnum] = ThisObj.InvokeMethod("IsNullEnum",__args__)
	End Function
	<AutoGenerated> _
	Public Function [SelectVerticalTab]([tobjForm] As Object, [tintActiveFormIndex] As Object) As Object
		Dim __args__() As Object = { [tobjForm], [tintActiveFormIndex] }
		[SelectVerticalTab] = ThisObj.InvokeMethod("SelectVerticalTab",__args__)
	End Function
	<AutoGenerated> _
	Public Sub [MMPendingWork_Restart]([objMMPendingWork] As Object)
		Dim __args__() As Object = { [objMMPendingWork] }
		ThisObj.InvokeMethod("MMPendingWork_Restart",__args__)
	End Sub
	<AutoGenerated> _
	Public Function [WF_LogEntry]([tstrProcess] As Object, [tintType] As Object) As Object
		Dim __args__() As Object = { [tstrProcess], [tintType] }
		[WF_LogEntry] = ThisObj.InvokeMethod("WF_LogEntry",__args__)
	End Function
	<AutoGenerated> _
	Public Function [WF_StartWithInstance]([tobjProcess] As Object, [tobjJob] As Object, [tobjObj] As Object, [tobjAETrans] As Object, [tobjParams] As Object, [bInitializeOnly] As Object) As Object
		Dim __args__() As Object = { [tobjProcess], [tobjJob], [tobjObj], [tobjAETrans], [tobjParams], [bInitializeOnly] }
		[WF_StartWithInstance] = ThisObj.InvokeMethod("WF_StartWithInstance",__args__)
	End Function
	<AutoGenerated> _
	Public Sub [WF_AddItemParams]([tobjItem] As Object, [tobjItemParams] As Object, [tobjParams] As Object)
		Dim __args__() As Object = { [tobjItem], [tobjItemParams], [tobjParams] }
		ThisObj.InvokeMethod("WF_AddItemParams",__args__)
	End Sub
	<AutoGenerated> _
	Public Sub [WF_RemoveItemParams]([tobjItem] As Object, [tobjItemParams] As Object, [tobjParams] As Object)
		Dim __args__() As Object = { [tobjItem], [tobjItemParams], [tobjParams] }
		ThisObj.InvokeMethod("WF_RemoveItemParams",__args__)
	End Sub
	<AutoGenerated> _
	Public Function [WF_CreateJob]([strTitle] As Object, [strDescr] As Object, [tobjWF_Process] As Object, [Items] As Object, [tobjAETrans] As Object, [tobjParams] As Object, [tobjItemParams] As Object, [bShowForm] As Object, [tobjParentForm] As Object) As Object
		Dim __args__() As Object = { [strTitle], [strDescr], [tobjWF_Process], [Items], [tobjAETrans], [tobjParams], [tobjItemParams], [bShowForm], [tobjParentForm] }
		[WF_CreateJob] = ThisObj.InvokeMethod("WF_CreateJob",__args__)
	End Function
	<AutoGenerated> _
	Public Function [LG_LogJobStarted]([tstrProcessID] As Object) As Object
		Dim __args__() As Object = { [tstrProcessID] }
		[LG_LogJobStarted] = ThisObj.InvokeMethod("LG_LogJobStarted",__args__)
	End Function
	<AutoGenerated> _
	Public Function [LG_LogEvent]([tstrProcess] As Object, [tintType] As Object) As Object
		Dim __args__() As Object = { [tstrProcess], [tintType] }
		[LG_LogEvent] = ThisObj.InvokeMethod("LG_LogEvent",__args__)
	End Function
	<AutoGenerated> _
	Public Function [GetCalendarProperty]([sProperty] As Object) As Object
		Dim __args__() As Object = { [sProperty] }
		[GetCalendarProperty] = ThisObj.InvokeMethod("GetCalendarProperty",__args__)
	End Function
	<AutoGenerated> _
	Public Function [GetUserPickerFormName]() As Object
		[GetUserPickerFormName] = ThisObj.InvokeMethod("GetUserPickerFormName",Nothing)
	End Function
	<AutoGenerated> _
	Public Function [GetCalPropMilitaryTime]([defaultValue] As Object) As Object
		Dim __args__() As Object = { [defaultValue] }
		[GetCalPropMilitaryTime] = ThisObj.InvokeMethod("GetCalPropMilitaryTime",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_NVL]([Thing] As Object, [Default] As Object) As Object
		Dim __args__() As Object = { [Thing], [Default] }
		[UT_NVL] = ThisObj.InvokeMethod("UT_NVL",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_ShortenStart]([InString] As Object, [Length] As Object) As Object
		Dim __args__() As Object = { [InString], [Length] }
		[UT_ShortenStart] = ThisObj.InvokeMethod("UT_ShortenStart",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_ShortenEnd]([InString] As Object, [Length] As Object) As Object
		Dim __args__() As Object = { [InString], [Length] }
		[UT_ShortenEnd] = ThisObj.InvokeMethod("UT_ShortenEnd",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_ShortenCenter]([InString] As Object, [Length] As Object) As Object
		Dim __args__() As Object = { [InString], [Length] }
		[UT_ShortenCenter] = ThisObj.InvokeMethod("UT_ShortenCenter",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_Shorten]([InString] As Object, [Length] As Object, [Where] As Object) As Object
		Dim __args__() As Object = { [InString], [Length], [Where] }
		[UT_Shorten] = ThisObj.InvokeMethod("UT_Shorten",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_InitProgress]([nCount] As Object, [sMessage] As Object) As Object
		Dim __args__() As Object = { [nCount], [sMessage] }
		[UT_InitProgress] = ThisObj.InvokeMethod("UT_InitProgress",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_MsgBox]([sPrompt] As Object, [Buttons] As Object, [sTitle] As Object) As Object
		Dim __args__() As Object = { [sPrompt], [Buttons], [sTitle] }
		[UT_MsgBox] = ThisObj.InvokeMethod("UT_MsgBox",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_SystemIsWebWorks]() As Object
		[UT_SystemIsWebWorks] = ThisObj.InvokeMethod("UT_SystemIsWebWorks",Nothing)
	End Function
	<AutoGenerated> _
	Public Function [UT_CreateObject]([ClassID] As Object) As Object
		Dim __args__() As Object = { [ClassID] }
		[UT_CreateObject] = ThisObj.InvokeMethod("UT_CreateObject",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_DoScriptWithObjectEx]([tStrScriptID] As Object, [tStrProcedure] As Object, [oClassInst] As Object, [iWidth] As Object, [iHeight] As Object) As Object
		Dim __args__() As Object = { [tStrScriptID], [tStrProcedure], [oClassInst], [iWidth], [iHeight] }
		[UT_DoScriptWithObjectEx] = ThisObj.InvokeMethod("UT_DoScriptWithObjectEx",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_DoScriptWithObject]([tStrScriptID] As Object, [tStrProcedure] As Object, [oClassInst] As Object) As Object
		Dim __args__() As Object = { [tStrScriptID], [tStrProcedure], [oClassInst] }
		[UT_DoScriptWithObject] = ThisObj.InvokeMethod("UT_DoScriptWithObject",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_DoScript]([tStrScriptID] As Object, [tStrProcedure] As Object) As Object
		Dim __args__() As Object = { [tStrScriptID], [tStrProcedure] }
		[UT_DoScript] = ThisObj.InvokeMethod("UT_DoScript",__args__)
	End Function
	<AutoGenerated> _
	Public Sub [UT_EditExpression]([objClass] As Object, [Member] As Object)
		Dim __args__() As Object = { [objClass], [Member] }
		ThisObj.InvokeMethod("UT_EditExpression",__args__)
	End Sub
	<AutoGenerated> _
	Public Sub [UT_EditExpressionEx]([objClass] As Object, [Instance] As Object, [Member] As Object)
		Dim __args__() As Object = { [objClass], [Instance], [Member] }
		ThisObj.InvokeMethod("UT_EditExpressionEx",__args__)
	End Sub
	<AutoGenerated> _
	Public Function [UT_Evaluate]([Instance] As Object, [Expression] As Object, [sErrors] As Object) As Object
		Dim __args__() As Object = { [Instance], [Expression], [sErrors] }
		[UT_Evaluate] = ThisObj.InvokeMethod("UT_Evaluate",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_GetObject]([strKey] As Object, [strClass] As Object) As Object
		Dim __args__() As Object = { [strKey], [strClass] }
		[UT_GetObject] = ThisObj.InvokeMethod("UT_GetObject",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_CanModifyMember]([oMember] As Object) As Object
		Dim __args__() As Object = { [oMember] }
		[UT_CanModifyMember] = ThisObj.InvokeMethod("UT_CanModifyMember",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_CanModifyInstance]([oClassInst] As Object) As Object
		Dim __args__() As Object = { [oClassInst] }
		[UT_CanModifyInstance] = ThisObj.InvokeMethod("UT_CanModifyInstance",__args__)
	End Function
	<AutoGenerated> _
	Public Sub [UT_CopyMemberValue]([oFromMember] As Object, [oToMember] As Object)
		Dim __args__() As Object = { [oFromMember], [oToMember] }
		ThisObj.InvokeMethod("UT_CopyMemberValue",__args__)
	End Sub
	<AutoGenerated> _
	Public Sub [UT_Clear]([Member] As Object)
		Dim __args__() As Object = { [Member] }
		ThisObj.InvokeMethod("UT_Clear",__args__)
	End Sub
	<AutoGenerated> _
	Public Function [UT_AssignValue]([Value] As Object, [Scale] As Object) As Object
		Dim __args__() As Object = { [Value], [Scale] }
		[UT_AssignValue] = ThisObj.InvokeMethod("UT_AssignValue",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_MemberIsNull]([Member] As Object) As Object
		Dim __args__() As Object = { [Member] }
		[UT_MemberIsNull] = ThisObj.InvokeMethod("UT_MemberIsNull",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_DisplayValue]([Member] As Object) As Object
		Dim __args__() As Object = { [Member] }
		[UT_DisplayValue] = ThisObj.InvokeMethod("UT_DisplayValue",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_GetMemberChildren]([oMember] As Object) As Object
		Dim __args__() As Object = { [oMember] }
		[UT_GetMemberChildren] = ThisObj.InvokeMethod("UT_GetMemberChildren",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_MemberIsDirty]([oMember] As Object) As Object
		Dim __args__() As Object = { [oMember] }
		[UT_MemberIsDirty] = ThisObj.InvokeMethod("UT_MemberIsDirty",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_ClassInstIsDirty]([oClassInst] As Object, [CheckSubFolders] As Object) As Object
		Dim __args__() As Object = { [oClassInst], [CheckSubFolders] }
		[UT_ClassInstIsDirty] = ThisObj.InvokeMethod("UT_ClassInstIsDirty",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_GetFormForm]([oForm] As Object) As Object
		Dim __args__() As Object = { [oForm] }
		[UT_GetFormForm] = ThisObj.InvokeMethod("UT_GetFormForm",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_GetFormElementChildren]([oElem] As Object) As Object
		Dim __args__() As Object = { [oElem] }
		[UT_GetFormElementChildren] = ThisObj.InvokeMethod("UT_GetFormElementChildren",__args__)
	End Function
	<AutoGenerated> _
	Public Sub [UT_SetFormElementEnabled]([oElem] As Object, [Enabled] As Object)
		Dim __args__() As Object = { [oElem], [Enabled] }
		ThisObj.InvokeMethod("UT_SetFormElementEnabled",__args__)
	End Sub
	<AutoGenerated> _
	Public Sub [UT_RemoveGridColumn]([Grid] As Object, [Expression] As Object)
		Dim __args__() As Object = { [Grid], [Expression] }
		ThisObj.InvokeMethod("UT_RemoveGridColumn",__args__)
	End Sub
	<AutoGenerated> _
	Public Sub [UT_InsertGridColumn]([Grid] As Object, [ColumnName] As Object, [Expression] As Object)
		Dim __args__() As Object = { [Grid], [ColumnName], [Expression] }
		ThisObj.InvokeMethod("UT_InsertGridColumn",__args__)
	End Sub
	<AutoGenerated> _
	Public Function [UT_FindTab]([TabSet] As Object, [TabName] As Object) As Object
		Dim __args__() As Object = { [TabSet], [TabName] }
		[UT_FindTab] = ThisObj.InvokeMethod("UT_FindTab",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_FilterChooser]([strFilter] As Object, [ctrlChooser] As Object) As Object
		Dim __args__() As Object = { [strFilter], [ctrlChooser] }
		[UT_FilterChooser] = ThisObj.InvokeMethod("UT_FilterChooser",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_DateString]([tdDate] As Object) As Object
		Dim __args__() As Object = { [tdDate] }
		[UT_DateString] = ThisObj.InvokeMethod("UT_DateString",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_ElkVal]([sVal] As Object) As Object
		Dim __args__() As Object = { [sVal] }
		[UT_ElkVal] = ThisObj.InvokeMethod("UT_ElkVal",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_ElkQuote]([sVal] As Object) As Object
		Dim __args__() As Object = { [sVal] }
		[UT_ElkQuote] = ThisObj.InvokeMethod("UT_ElkQuote",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_FilterExpr]([KeyField] As Object, [Key] As Object, [Compare] As Object) As Object
		Dim __args__() As Object = { [KeyField], [Key], [Compare] }
		[UT_FilterExpr] = ThisObj.InvokeMethod("UT_FilterExpr",__args__)
	End Function
	<AutoGenerated> _
	Public Sub [UT_CopyFolderNT]([objSourceFolder] As Object, [objDestFolder] As Object)
		Dim __args__() As Object = { [objSourceFolder], [objDestFolder] }
		ThisObj.InvokeMethod("UT_CopyFolderNT",__args__)
	End Sub
	<AutoGenerated> _
	Public Sub [UT_CopyFolder]([objSourceFolder] As Object, [objDestFolder] As Object, [Transaction] As Object)
		Dim __args__() As Object = { [objSourceFolder], [objDestFolder], [Transaction] }
		ThisObj.InvokeMethod("UT_CopyFolder",__args__)
	End Sub
	<AutoGenerated> _
	Public Function [UT_ElkFolder]([oAeFolder] As Object) As Object
		Dim __args__() As Object = { [oAeFolder] }
		[UT_ElkFolder] = ThisObj.InvokeMethod("UT_ElkFolder",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_ElkFolderCount]([oAeElkFolder] As Object) As Object
		Dim __args__() As Object = { [oAeElkFolder] }
		[UT_ElkFolderCount] = ThisObj.InvokeMethod("UT_ElkFolderCount",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_OnlyOneItemExpr]([Folder] As Object, [Filter] As Object) As Object
		Dim __args__() As Object = { [Folder], [Filter] }
		[UT_OnlyOneItemExpr] = ThisObj.InvokeMethod("UT_OnlyOneItemExpr",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_OnlyOneItem]([Folder] As Object) As Object
		Dim __args__() As Object = { [Folder] }
		[UT_OnlyOneItem] = ThisObj.InvokeMethod("UT_OnlyOneItem",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_AtLeastOneItemExpr]([Folder] As Object, [Filter] As Object) As Object
		Dim __args__() As Object = { [Folder], [Filter] }
		[UT_AtLeastOneItemExpr] = ThisObj.InvokeMethod("UT_AtLeastOneItemExpr",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_AtLeastOneItem]([Folder] As Object) As Object
		Dim __args__() As Object = { [Folder] }
		[UT_AtLeastOneItem] = ThisObj.InvokeMethod("UT_AtLeastOneItem",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_IsUniqueObj]([Folder] As Object, [ClassInst] As Object, [MemberName] As Object) As Object
		Dim __args__() As Object = { [Folder], [ClassInst], [MemberName] }
		[UT_IsUniqueObj] = ThisObj.InvokeMethod("UT_IsUniqueObj",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_IsUnique]([FolderName] As Object, [ClassInst] As Object, [MemberName] As Object) As Object
		Dim __args__() As Object = { [FolderName], [ClassInst], [MemberName] }
		[UT_IsUnique] = ThisObj.InvokeMethod("UT_IsUnique",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_ExistsCompareObj]([Folder] As Object, [KeyField] As Object, [Key] As Object, [Compare] As Object) As Object
		Dim __args__() As Object = { [Folder], [KeyField], [Key], [Compare] }
		[UT_ExistsCompareObj] = ThisObj.InvokeMethod("UT_ExistsCompareObj",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_ScanExprObj]([Folder] As Object, [Filter] As Object, [Fields] As Object, [nRows] As Object, [Order] As Object) As Object
		Dim __args__() As Object = { [Folder], [Filter], [Fields], [nRows], [Order] }
		[UT_ScanExprObj] = ThisObj.InvokeMethod("UT_ScanExprObj",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_ScanObj]([Folder] As Object, [KeyField] As Object, [Key] As Object, [Fields] As Object, [nRows] As Object, [Order] As Object) As Object
		Dim __args__() As Object = { [Folder], [KeyField], [Key], [Fields], [nRows], [Order] }
		[UT_ScanObj] = ThisObj.InvokeMethod("UT_ScanObj",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_ScanExpr]([FolderName] As Object, [Filter] As Object, [Fields] As Object, [nRows] As Object, [Order] As Object) As Object
		Dim __args__() As Object = { [FolderName], [Filter], [Fields], [nRows], [Order] }
		[UT_ScanExpr] = ThisObj.InvokeMethod("UT_ScanExpr",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_Scan]([FolderName] As Object, [KeyField] As Object, [Key] As Object, [Fields] As Object, [nRows] As Object, [Order] As Object) As Object
		Dim __args__() As Object = { [FolderName], [KeyField], [Key], [Fields], [nRows], [Order] }
		[UT_Scan] = ThisObj.InvokeMethod("UT_Scan",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_ExistsExprObj]([Folder] As Object, [Filter] As Object) As Object
		Dim __args__() As Object = { [Folder], [Filter] }
		[UT_ExistsExprObj] = ThisObj.InvokeMethod("UT_ExistsExprObj",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_ExistsExpr]([FolderName] As Object, [Filter] As Object) As Object
		Dim __args__() As Object = { [FolderName], [Filter] }
		[UT_ExistsExpr] = ThisObj.InvokeMethod("UT_ExistsExpr",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_ExistsObj]([Folder] As Object, [KeyField] As Object, [Key] As Object) As Object
		Dim __args__() As Object = { [Folder], [KeyField], [Key] }
		[UT_ExistsObj] = ThisObj.InvokeMethod("UT_ExistsObj",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_Exists]([FolderName] As Object, [KeyField] As Object, [Key] As Object) As Object
		Dim __args__() As Object = { [FolderName], [KeyField], [Key] }
		[UT_Exists] = ThisObj.InvokeMethod("UT_Exists",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_FetchExprObj]([Folder] As Object, [Filter] As Object) As Object
		Dim __args__() As Object = { [Folder], [Filter] }
		[UT_FetchExprObj] = ThisObj.InvokeMethod("UT_FetchExprObj",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_FetchExpr]([FolderName] As Object, [Filter] As Object) As Object
		Dim __args__() As Object = { [FolderName], [Filter] }
		[UT_FetchExpr] = ThisObj.InvokeMethod("UT_FetchExpr",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_FetchObj]([Folder] As Object, [KeyField] As Object, [Key] As Object) As Object
		Dim __args__() As Object = { [Folder], [KeyField], [Key] }
		[UT_FetchObj] = ThisObj.InvokeMethod("UT_FetchObj",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_Fetch]([FolderName] As Object, [KeyField] As Object, [Key] As Object) As Object
		Dim __args__() As Object = { [FolderName], [KeyField], [Key] }
		[UT_Fetch] = ThisObj.InvokeMethod("UT_Fetch",__args__)
	End Function
	<AutoGenerated> _
	Public Sub [UT_SetJoinMemberFromFolderObj]([Folder] As Object, [KeyField] As Object, [Key] As Object, [Thing] As Object)
		Dim __args__() As Object = { [Folder], [KeyField], [Key], [Thing] }
		ThisObj.InvokeMethod("UT_SetJoinMemberFromFolderObj",__args__)
	End Sub
	<AutoGenerated> _
	Public Function [UT_FetchOrCreateObjFromJoinNT]([Folder] As Object, [KeyField] As Object, [oAeJoinMember] As Object) As Object
		Dim __args__() As Object = { [Folder], [KeyField], [oAeJoinMember] }
		[UT_FetchOrCreateObjFromJoinNT] = ThisObj.InvokeMethod("UT_FetchOrCreateObjFromJoinNT",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_FetchOrCreateObjFromJoin]([Folder] As Object, [KeyField] As Object, [oAeJoinMember] As Object, [Transaction] As Object) As Object
		Dim __args__() As Object = { [Folder], [KeyField], [oAeJoinMember], [Transaction] }
		[UT_FetchOrCreateObjFromJoin] = ThisObj.InvokeMethod("UT_FetchOrCreateObjFromJoin",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_FetchOrCreateObj]([Folder] As Object, [KeyField] As Object, [Key] As Object, [Transaction] As Object) As Object
		Dim __args__() As Object = { [Folder], [KeyField], [Key], [Transaction] }
		[UT_FetchOrCreateObj] = ThisObj.InvokeMethod("UT_FetchOrCreateObj",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_FetchOrCreate]([FolderName] As Object, [KeyField] As Object, [Key] As Object, [Transaction] As Object) As Object
		Dim __args__() As Object = { [FolderName], [KeyField], [Key], [Transaction] }
		[UT_FetchOrCreate] = ThisObj.InvokeMethod("UT_FetchOrCreate",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_SumExprObj]([Folder] As Object, [Field] As Object, [Filter] As Object) As Object
		Dim __args__() As Object = { [Folder], [Field], [Filter] }
		[UT_SumExprObj] = ThisObj.InvokeMethod("UT_SumExprObj",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_SumObj]([Folder] As Object, [Field] As Object, [KeyField] As Object, [Key] As Object) As Object
		Dim __args__() As Object = { [Folder], [Field], [KeyField], [Key] }
		[UT_SumObj] = ThisObj.InvokeMethod("UT_SumObj",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_UserFromContact]([Contact] As Object) As Object
		Dim __args__() As Object = { [Contact] }
		[UT_UserFromContact] = ThisObj.InvokeMethod("UT_UserFromContact",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_Conf]([EntryName] As Object) As Object
		Dim __args__() As Object = { [EntryName] }
		[UT_Conf] = ThisObj.InvokeMethod("UT_Conf",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_ConfDef]([EntryName] As Object, [Default] As Object) As Object
		Dim __args__() As Object = { [EntryName], [Default] }
		[UT_ConfDef] = ThisObj.InvokeMethod("UT_ConfDef",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_UniqueID]([Category] As Object, [Identifier] As Object, [Description] As Object, [Default] As Object) As Object
		Dim __args__() As Object = { [Category], [Identifier], [Description], [Default] }
		[UT_UniqueID] = ThisObj.InvokeMethod("UT_UniqueID",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_AutoNumberFromFolder]([Folder] As Object, [Field] As Object, [Default] As Object) As Object
		Dim __args__() As Object = { [Folder], [Field], [Default] }
		[UT_AutoNumberFromFolder] = ThisObj.InvokeMethod("UT_AutoNumberFromFolder",__args__)
	End Function
	<AutoGenerated> _
	Public Function [UT_TempFile]([strPath] As Object) As Object
		Dim __args__() As Object = { [strPath] }
		[UT_TempFile] = ThisObj.InvokeMethod("UT_TempFile",__args__)
	End Function
	<AutoGenerated> _
	Public Sub [Prof_CreateCompulsoryProfiles]([tobjEntityInst] As Object, [tstrSubFolder] As Object, [tobjGrid] As Object)
		Dim __args__() As Object = { [tobjEntityInst], [tstrSubFolder], [tobjGrid] }
		ThisObj.InvokeMethod("Prof_CreateCompulsoryProfiles",__args__)
	End Sub
	<AutoGenerated> _
	Public Sub [Prof_CreateProfile]([tobjEntityInst] As Object, [tstrSubFolder] As Object, [tobjProfile] As Object, [tobjGrid] As Object)
		Dim __args__() As Object = { [tobjEntityInst], [tstrSubFolder], [tobjProfile], [tobjGrid] }
		ThisObj.InvokeMethod("Prof_CreateProfile",__args__)
	End Sub
	<AutoGenerated> _
	Public Function [Prof_ProfileExists]([tobjEntityInst] As Object, [tstrSubFolder] As Object, [tstrCompProfileKey] As Object) As Object
		Dim __args__() As Object = { [tobjEntityInst], [tstrSubFolder], [tstrCompProfileKey] }
		[Prof_ProfileExists] = ThisObj.InvokeMethod("Prof_ProfileExists",__args__)
	End Function
	<AutoGenerated> _
	Public Sub [ImportDoc]([strPath] As Object)
		Dim __args__() As Object = { [strPath] }
		ThisObj.InvokeMethod("ImportDoc",__args__)
	End Sub
	<AutoGenerated> _
	Public Function [GetSession]() As Object
		[GetSession] = ThisObj.InvokeMethod("GetSession",Nothing)
	End Function
	<AutoGenerated> _
	Public Sub [FillNotes]([oGrid] As Object, [oTextBox] As Object, [oLabel] As Object, [strText] As Object, [strMember] As Object, [blnAttendee] As Object)
		Dim __args__() As Object = { [oGrid], [oTextBox], [oLabel], [strText], [strMember], [blnAttendee] }
		ThisObj.InvokeMethod("FillNotes",__args__)
	End Sub
	<AutoGenerated> _
	Public Sub [FillQCNotes]([oGrid] As Object, [oTextBox] As Object, [oLabel] As Object, [strText] As Object, [strMember] As Object)
		Dim __args__() As Object = { [oGrid], [oTextBox], [oLabel], [strText], [strMember] }
		ThisObj.InvokeMethod("FillQCNotes",__args__)
	End Sub
	<AutoGenerated> _
	Public Function [NextDay]([FromDate] As Object) As Object
		Dim __args__() As Object = { [FromDate] }
		[NextDay] = ThisObj.InvokeMethod("NextDay",__args__)
	End Function
	<AutoGenerated> _
	Public Function [WeekStartDate]() As Object
		[WeekStartDate] = ThisObj.InvokeMethod("WeekStartDate",Nothing)
	End Function
	<AutoGenerated> _
	Public Function [WeekEndDate]() As Object
		[WeekEndDate] = ThisObj.InvokeMethod("WeekEndDate",Nothing)
	End Function
	<AutoGenerated> _
	Public Sub [CreateJobComm]([strType] As Object, [strCategory] As Object, [strAttendee] As Object, [strNotes] As Object, [oJob] As Object, [oAttendee] As Object)
		Dim __args__() As Object = { [strType], [strCategory], [strAttendee], [strNotes], [oJob], [oAttendee] }
		ThisObj.InvokeMethod("CreateJobComm",__args__)
	End Sub
	<AutoGenerated> _
	Public Sub [CreateComm]([strType] As Object, [strCategory] As Object, [strAttendee] As Object, [strNotes] As Object, [oAttendee] As Object)
		Dim __args__() As Object = { [strType], [strCategory], [strAttendee], [strNotes], [oAttendee] }
		ThisObj.InvokeMethod("CreateComm",__args__)
	End Sub
	<AutoGenerated> _
	Public Function [CreateAssignmentTask]([strCategory] As Object, [dateDue] As Object, [strNotes] As Object, [oAssignee] As Object) As Object
		Dim __args__() As Object = { [strCategory], [dateDue], [strNotes], [oAssignee] }
		[CreateAssignmentTask] = ThisObj.InvokeMethod("CreateAssignmentTask",__args__)
	End Function
	<AutoGenerated> _
	Public Function [CreateAssignmentCall]([strCategory] As Object, [dateDue] As Object, [strNotes] As Object, [oAssignee] As Object) As Object
		Dim __args__() As Object = { [strCategory], [dateDue], [strNotes], [oAssignee] }
		[CreateAssignmentCall] = ThisObj.InvokeMethod("CreateAssignmentCall",__args__)
	End Function
	<AutoGenerated> _
	Public Sub [CreateAttendee]([oActivity] As Object, [strFolder] As Object, [strMember] As Object, [oAttendee] As Object)
		Dim __args__() As Object = { [oActivity], [strFolder], [strMember], [oAttendee] }
		ThisObj.InvokeMethod("CreateAttendee",__args__)
	End Sub
	<AutoGenerated> _
	Public Sub [CreateJobAttendee]([oActivity] As Object, [oJob] As Object, [oAssignment] As Object)
		Dim __args__() As Object = { [oActivity], [oJob], [oAssignment] }
		ThisObj.InvokeMethod("CreateJobAttendee",__args__)
	End Sub
	<AutoGenerated> _
	Public Sub [LoadReminder]([tobjReminderForm] As Object, [tobjCurInst] As Object, [tstrFolder] As Object, [tstrFilter] As Object)
		Dim __args__() As Object = { [tobjReminderForm], [tobjCurInst], [tstrFolder], [tstrFilter] }
		ThisObj.InvokeMethod("LoadReminder",__args__)
	End Sub
	<AutoGenerated> _
	Public Function [ProcessWeeklyCalls]([StartDate] As Object, [EndDate] As Object, [UserKey] As Object, [DeleteOldCalls] As Object) As Object
		Dim __args__() As Object = { [StartDate], [EndDate], [UserKey], [DeleteOldCalls] }
		[ProcessWeeklyCalls] = ThisObj.InvokeMethod("ProcessWeeklyCalls",__args__)
	End Function
	<AutoGenerated> _
	Public Function [NullToZero]([pData] As Object) As Object
		Dim __args__() As Object = { [pData] }
		[NullToZero] = ThisObj.InvokeMethod("NullToZero",__args__)
	End Function
	#End Region
End Class

