USE [ProjectA]
GO
/****** Object:  StoredProcedure [dbo].[EvaluationsOfAgroup]    Script Date: 5/2/2019 11:12:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EvaluationsOfAgroup] 
		@GroupId int
AS SELECT Name AS [Evaluation Title], TotalMarks, ObtainedMarks
FROM Evaluation JOIN GroupEvaluation ON Evaluation.Id = GroupEvaluation.EvaluationId
WHERE GroupEvaluation.GroupId = @GroupId
GO
/****** Object:  StoredProcedure [dbo].[ListOfStudentsSupervisedGivenAdvisorName]    Script Date: 5/2/2019 11:12:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListOfStudentsSupervisedGivenAdvisorName] 
		@AdvisorName varchar(50)
AS 
SELECT RegistrationNo AS [Student Id], CONCAT(S.FirstName, ' ', S.LastName) AS [Student Name], GroupStudent.GroupId
FROM Advisor JOIN Person AS A ON Advisor.Id = A.Id
JOIN ProjectAdvisor ON ProjectAdvisor.AdvisorId = Advisor.Id
JOIN Project ON ProjectAdvisor.ProjectId = Project.Id
JOIN GroupProject ON GroupProject.ProjectId = Project.Id
JOIN GroupStudent ON GroupStudent.GroupId = GroupProject.GroupId
JOIN Student ON Student.Id = GroupStudent.StudentId
JOIN Person AS S ON S.Id = Student.Id
WHERE 
    CONCAT(A.FirstName, ' ', A.LastName) = @AdvisorName

GO
/****** Object:  Table [dbo].[Advisor]    Script Date: 5/2/2019 11:12:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Advisor](
	[Id] [int] NOT NULL,
	[Designation] [int] NOT NULL,
	[Salary] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Evaluation]    Script Date: 5/2/2019 11:12:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Evaluation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[TotalMarks] [int] NOT NULL,
	[TotalWeightage] [int] NOT NULL,
 CONSTRAINT [PK_Evaluation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Group]    Script Date: 5/2/2019 11:12:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Created_On] [date] NOT NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GroupEvaluation]    Script Date: 5/2/2019 11:12:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupEvaluation](
	[GroupId] [int] NOT NULL,
	[EvaluationId] [int] NOT NULL,
	[ObtainedMarks] [int] NOT NULL,
	[EvaluationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GroupEvaluation] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC,
	[EvaluationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GroupProject]    Script Date: 5/2/2019 11:12:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupProject](
	[ProjectId] [int] NOT NULL,
	[GroupId] [int] NOT NULL,
	[AssignmentDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GroupProject] PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC,
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GroupStudent]    Script Date: 5/2/2019 11:12:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupStudent](
	[GroupId] [int] NOT NULL,
	[StudentId] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[AssignmentDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GroupStudent] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC,
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lookup]    Script Date: 5/2/2019 11:12:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lookup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Value] [varchar](100) NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Lookup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Person]    Script Date: 5/2/2019 11:12:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NOT NULL,
	[LastName] [varchar](100) NULL,
	[Contact] [varchar](20) NULL,
	[Email] [varchar](30) NOT NULL,
	[DateOfBirth] [datetime] NULL,
	[Gender] [int] NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Project]    Script Date: 5/2/2019 11:12:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Project](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](max) NULL,
	[Title] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProjectAdvisor]    Script Date: 5/2/2019 11:12:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectAdvisor](
	[AdvisorId] [int] NOT NULL,
	[ProjectId] [int] NOT NULL,
	[AdvisorRole] [int] NOT NULL,
	[AssignmentDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ProjectAdvisor] PRIMARY KEY CLUSTERED 
(
	[AdvisorId] ASC,
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student]    Script Date: 5/2/2019 11:12:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] NOT NULL,
	[RegistrationNo] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[ListOfAdvisors]    Script Date: 5/2/2019 11:12:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ListOfAdvisors] AS 
SELECT CONCAT(FirstName, ' ', LastName) AS Name, Value AS Designation
FROM Advisor JOIN Person ON Advisor.Id = Person.Id
JOIN Lookup ON Advisor.Designation = Lookup.Id
WHERE Advisor.Id NOT IN (SELECT AdvisorId FROM ProjectAdvisor)
GO
/****** Object:  View [dbo].[ListOfProjectbyEachAdvisors]    Script Date: 5/2/2019 11:12:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ListOfProjectbyEachAdvisors] AS
SELECT CONCAT(FirstName, ' ', LastName) AS Name, Title AS [Project]
FROM Advisor JOIN Person ON Advisor.Id = Person.Id
JOIN ProjectAdvisor ON ProjectAdvisor.AdvisorId = Advisor.Id
JOIN Project ON Project.Id = ProjectAdvisor.ProjectId
GO
/****** Object:  View [dbo].[ListOfStudentsSupervisedbyEachAdvisor]    Script Date: 5/2/2019 11:12:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ListOfStudentsSupervisedbyEachAdvisor] AS
SELECT CONCAT(A.FirstName, ' ', A.LastName) AS [Advisor Name], RegistrationNo AS Student
FROM Advisor JOIN Person AS A ON Advisor.Id = A.Id
JOIN ProjectAdvisor ON ProjectAdvisor.AdvisorId = Advisor.Id
JOIN Project ON ProjectAdvisor.ProjectId = Project.Id
JOIN GroupProject ON GroupProject.ProjectId = Project.Id
JOIN GroupStudent ON GroupStudent.GroupId = GroupProject.GroupId
JOIN Student ON Student.Id = GroupStudent.StudentId
JOIN Person AS S ON S.Id = Student.Id
GO
/****** Object:  View [dbo].[ProjectCountOfEachAdvisor]    Script Date: 5/2/2019 11:12:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ProjectCountOfEachAdvisor] AS
 SELECT CONCAT(FirstName, ' ', LastName) AS [Advisor Name], COUNT(ProjectId) AS [Project Count]
 FROM ProjectAdvisor JOIN Advisor ON ProjectAdvisor.AdvisorId = Advisor.Id
 JOIN Person ON Person.Id = Advisor.Id
 GROUP BY CONCAT(FirstName, ' ', LastName)
GO
INSERT [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (35, 8, CAST(200000000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (62, 9, CAST(30000000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (65, 6, CAST(300000 AS Decimal(18, 0)))
GO
SET IDENTITY_INSERT [dbo].[Evaluation] ON 

GO
INSERT [dbo].[Evaluation] ([Id], [Name], [TotalMarks], [TotalWeightage]) VALUES (3, N'p1', 200, 15)
GO
INSERT [dbo].[Evaluation] ([Id], [Name], [TotalMarks], [TotalWeightage]) VALUES (6, N'p2', 100, 100)
GO
SET IDENTITY_INSERT [dbo].[Evaluation] OFF
GO
SET IDENTITY_INSERT [dbo].[Group] ON 

GO
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (48, CAST(0x793F0B00 AS Date))
GO
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (61, CAST(0x7C3F0B00 AS Date))
GO
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (63, CAST(0x963F0B00 AS Date))
GO
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (64, CAST(0x963F0B00 AS Date))
GO
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (66, CAST(0x963F0B00 AS Date))
GO
SET IDENTITY_INSERT [dbo].[Group] OFF
GO
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (61, 3, 1, CAST(0x0000AA21006C591C AS DateTime))
GO
INSERT [dbo].[GroupProject] ([ProjectId], [GroupId], [AssignmentDate]) VALUES (6, 66, CAST(0x0000AA3B00BF8D1C AS DateTime))
GO
INSERT [dbo].[GroupProject] ([ProjectId], [GroupId], [AssignmentDate]) VALUES (8, 61, CAST(0x0000AA21006D8198 AS DateTime))
GO
INSERT [dbo].[GroupProject] ([ProjectId], [GroupId], [AssignmentDate]) VALUES (8, 64, CAST(0x0000AA3B00BF9B2C AS DateTime))
GO
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (48, 55, 4, CAST(0x0000AA1E00072420 AS DateTime))
GO
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (61, 37, 3, CAST(0x0000AA2100675F48 AS DateTime))
GO
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (63, 55, 4, CAST(0x0000AA3B00AC821C AS DateTime))
GO
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (63, 60, 4, CAST(0x0000AA3B00AC821C AS DateTime))
GO
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (64, 55, 3, CAST(0x0000AA3B00B5AFB8 AS DateTime))
GO
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (64, 56, 4, CAST(0x0000AA3B00B5AFB8 AS DateTime))
GO
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (64, 60, 4, CAST(0x0000AA3B00B5AFB8 AS DateTime))
GO
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (66, 56, 3, CAST(0x0000AA3B00BB8CE4 AS DateTime))
GO
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (66, 60, 3, CAST(0x0000AA3B00BB8CE4 AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Lookup] ON 

GO
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (1, N'Male', N'GENDER')
GO
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (2, N'Female', N'GENDER')
GO
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (3, N'Active', N'STATUS')
GO
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (4, N'InActive', N'STATUS')
GO
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (6, N'Professor', N'DESIGNATION')
GO
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (7, N'Associate Professor', N'DESIGNATION')
GO
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (8, N'Assisstant Professor', N'DESIGNATION')
GO
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (9, N'Lecturer', N'DESIGNATION')
GO
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (10, N'Industry Professional', N'DESIGNATION')
GO
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (11, N'Main Advisor', N'ADVISOR_ROLE')
GO
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (12, N'Co-Advisror', N'ADVISOR_ROLE')
GO
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (14, N'Industry Advisor', N'ADVISOR_ROLE')
GO
SET IDENTITY_INSERT [dbo].[Lookup] OFF
GO
SET IDENTITY_INSERT [dbo].[Person] ON 

GO
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (31, N'Rida', N'Sajid', N'03331234567', N'r@gmail.com', CAST(0x00008CEB01153FC8 AS DateTime), 2)
GO
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (35, N'Sir', N'Samyan', N'03001234568', N'samyan@gmail.com', CAST(0x00008531006CB6DC AS DateTime), 1)
GO
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (37, N'Aqsa', N'khan', N'03331234567', N'aqsa@gmail.com', CAST(0x0000AA120000C3B4 AS DateTime), 2)
GO
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (38, N'ayeza', N'sajid', N'03337654324', N'a@gmail.com', CAST(0x00008D3400000000 AS DateTime), 1)
GO
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (40, N'Hiba', N'azam', N'03331234567', N'h@gmail.com', CAST(0x00008CEB01574DF0 AS DateTime), 2)
GO
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (55, N'Rida', N'Sajid', N'03331234567', N'rida@gmail.com', CAST(0x00008C1B01681BE4 AS DateTime), 2)
GO
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (56, N'Umer', N'Ghauri', N'03331234567', N'haha@gmail.com', CAST(0x00008C1B016D6D9C AS DateTime), 1)
GO
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (59, N'Bushra', N'Shakeel', N'03331234567', N'haha@gmail.com', CAST(0x00008B8A000D3AB8 AS DateTime), 2)
GO
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (60, N'Nida', N'Iqbal', N'03333212345', N'lolol@gmail.com', CAST(0x00008B2900000000 AS DateTime), 1)
GO
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (62, N'Maam', N'Sahar', N'03331234567', N'maamsahar@gmail.com', CAST(0x00007F37014A5028 AS DateTime), 2)
GO
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (64, N'Faiqa', N'Saeed', N'03331234567', N'faiqa1123@gmail.com', CAST(0x00008AF900BEBEDC AS DateTime), 2)
GO
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (65, N'Hina', N'Khalid', N'03331234567', N'Hina@gmail.com', CAST(0x00007F8A00BF052C AS DateTime), 2)
GO
SET IDENTITY_INSERT [dbo].[Person] OFF
GO
SET IDENTITY_INSERT [dbo].[Project] ON 

GO
INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (6, N'description of project', N'a project')
GO
INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (8, N'Database project', N'Mini project')
GO
SET IDENTITY_INSERT [dbo].[Project] OFF
GO
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (35, 6, 11, CAST(0x0000AA1F0017FB74 AS DateTime))
GO
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (35, 8, 11, CAST(0x0000AA21006D2D38 AS DateTime))
GO
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (62, 6, 12, CAST(0x0000AA1F017DD920 AS DateTime))
GO
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (62, 8, 14, CAST(0x0000AA21006D437C AS DateTime))
GO
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (37, N'2016-CE-10')
GO
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (55, N' 2016-CE-616')
GO
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (56, N'2017-CE-09')
GO
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (60, N'2019-CE-919')
GO
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (64, N'2016-CY-999')
GO
ALTER TABLE [dbo].[Advisor]  WITH CHECK ADD  CONSTRAINT [FK_Advisor_Lookup] FOREIGN KEY([Designation])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[Advisor] CHECK CONSTRAINT [FK_Advisor_Lookup]
GO
ALTER TABLE [dbo].[GroupEvaluation]  WITH CHECK ADD  CONSTRAINT [FK_GroupEvaluation_Evaluation] FOREIGN KEY([EvaluationId])
REFERENCES [dbo].[Evaluation] ([Id])
GO
ALTER TABLE [dbo].[GroupEvaluation] CHECK CONSTRAINT [FK_GroupEvaluation_Evaluation]
GO
ALTER TABLE [dbo].[GroupEvaluation]  WITH CHECK ADD  CONSTRAINT [FK_GroupEvaluation_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[GroupEvaluation] CHECK CONSTRAINT [FK_GroupEvaluation_Group]
GO
ALTER TABLE [dbo].[GroupProject]  WITH CHECK ADD  CONSTRAINT [FK_GroupProject_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[GroupProject] CHECK CONSTRAINT [FK_GroupProject_Group]
GO
ALTER TABLE [dbo].[GroupProject]  WITH CHECK ADD  CONSTRAINT [FK_GroupProject_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
ALTER TABLE [dbo].[GroupProject] CHECK CONSTRAINT [FK_GroupProject_Project]
GO
ALTER TABLE [dbo].[GroupStudent]  WITH CHECK ADD  CONSTRAINT [FK_GroupStudents_Lookup] FOREIGN KEY([Status])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[GroupStudent] CHECK CONSTRAINT [FK_GroupStudents_Lookup]
GO
ALTER TABLE [dbo].[GroupStudent]  WITH CHECK ADD  CONSTRAINT [FK_ProjectStudents_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[GroupStudent] CHECK CONSTRAINT [FK_ProjectStudents_Group]
GO
ALTER TABLE [dbo].[GroupStudent]  WITH CHECK ADD  CONSTRAINT [FK_ProjectStudents_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[GroupStudent] CHECK CONSTRAINT [FK_ProjectStudents_Student]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Lookup] FOREIGN KEY([Gender])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Lookup]
GO
ALTER TABLE [dbo].[ProjectAdvisor]  WITH CHECK ADD  CONSTRAINT [FK_ProjectAdvisor_Lookup] FOREIGN KEY([AdvisorRole])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[ProjectAdvisor] CHECK CONSTRAINT [FK_ProjectAdvisor_Lookup]
GO
ALTER TABLE [dbo].[ProjectAdvisor]  WITH CHECK ADD  CONSTRAINT [FK_ProjectAdvisor_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
ALTER TABLE [dbo].[ProjectAdvisor] CHECK CONSTRAINT [FK_ProjectAdvisor_Project]
GO
ALTER TABLE [dbo].[ProjectAdvisor]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTeachers_Teacher] FOREIGN KEY([AdvisorId])
REFERENCES [dbo].[Advisor] ([Id])
GO
ALTER TABLE [dbo].[ProjectAdvisor] CHECK CONSTRAINT [FK_ProjectTeachers_Teacher]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Person] FOREIGN KEY([Id])
REFERENCES [dbo].[Person] ([Id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Person]
GO
USE [master]
GO
ALTER DATABASE [ProjectA] SET  READ_WRITE 
GO
