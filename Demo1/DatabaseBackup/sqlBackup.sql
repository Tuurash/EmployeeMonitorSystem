USE [EmployeeManagementSystem]
GO
/****** Object:  Table [dbo].[Details]    Script Date: 4/26/2019 10:54:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Details](
	[EmpID] [int] IDENTITY(1,1) NOT NULL,
	[DefaultSalary] [decimal](18, 2) NULL,
	[TotalSalary] [decimal](18, 2) NULL,
	[totalBonus] [decimal](18, 2) NULL,
	[OvertimeCount] [int] NULL,
	[WorkHourMonthly] [int] NULL,
 CONSTRAINT [PK_Details] PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee]    Script Date: 4/26/2019 10:54:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[EmpID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[ContactNo] [varchar](50) NULL,
	[JoiningDate] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Details] ON 

INSERT [dbo].[Details] ([EmpID], [DefaultSalary], [TotalSalary], [totalBonus], [OvertimeCount], [WorkHourMonthly]) VALUES (1, CAST(15000.00 AS Decimal(18, 2)), CAST(35000.00 AS Decimal(18, 2)), CAST(15000.00 AS Decimal(18, 2)), 30, 10)
INSERT [dbo].[Details] ([EmpID], [DefaultSalary], [TotalSalary], [totalBonus], [OvertimeCount], [WorkHourMonthly]) VALUES (3, CAST(20000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0, 0)
INSERT [dbo].[Details] ([EmpID], [DefaultSalary], [TotalSalary], [totalBonus], [OvertimeCount], [WorkHourMonthly]) VALUES (4, CAST(30000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0, 0)
INSERT [dbo].[Details] ([EmpID], [DefaultSalary], [TotalSalary], [totalBonus], [OvertimeCount], [WorkHourMonthly]) VALUES (12, CAST(12300.00 AS Decimal(18, 2)), CAST(14800.00 AS Decimal(18, 2)), CAST(2500.00 AS Decimal(18, 2)), 5, 250)
INSERT [dbo].[Details] ([EmpID], [DefaultSalary], [TotalSalary], [totalBonus], [OvertimeCount], [WorkHourMonthly]) VALUES (13, CAST(13400.00 AS Decimal(18, 2)), CAST(15900.00 AS Decimal(18, 2)), CAST(2500.00 AS Decimal(18, 2)), 5, 250)
INSERT [dbo].[Details] ([EmpID], [DefaultSalary], [TotalSalary], [totalBonus], [OvertimeCount], [WorkHourMonthly]) VALUES (14, CAST(89000.00 AS Decimal(18, 2)), CAST(101500.00 AS Decimal(18, 2)), CAST(12500.00 AS Decimal(18, 2)), 25, 290)
INSERT [dbo].[Details] ([EmpID], [DefaultSalary], [TotalSalary], [totalBonus], [OvertimeCount], [WorkHourMonthly]) VALUES (15, CAST(16000.00 AS Decimal(18, 2)), CAST(21000.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), 10, 260)
INSERT [dbo].[Details] ([EmpID], [DefaultSalary], [TotalSalary], [totalBonus], [OvertimeCount], [WorkHourMonthly]) VALUES (16, CAST(12000.00 AS Decimal(18, 2)), CAST(12000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0, 220)
SET IDENTITY_INSERT [dbo].[Details] OFF
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmpID], [Name], [Email], [ContactNo], [JoiningDate], [Address]) VALUES (12, N'Black', N'B@g.com', N'123', N'2019-04-26', N'Badda')
INSERT [dbo].[Employee] ([EmpID], [Name], [Email], [ContactNo], [JoiningDate], [Address]) VALUES (13, N'White', N'w@g.com', N'1234', N'2019-04-26', N'gulshan')
INSERT [dbo].[Employee] ([EmpID], [Name], [Email], [ContactNo], [JoiningDate], [Address]) VALUES (14, N'Purple', N'p@g.cm', N'12345', N'2019-04-26', N'dhanmondi')
INSERT [dbo].[Employee] ([EmpID], [Name], [Email], [ContactNo], [JoiningDate], [Address]) VALUES (15, N'steelblue', N's@g.cm', N'1234567', N'2019-04-26', N'uttara')
INSERT [dbo].[Employee] ([EmpID], [Name], [Email], [ContactNo], [JoiningDate], [Address]) VALUES (16, N'coral', N'c@g.com', N'1234566', N'2019-04-26', N'motijheel')
SET IDENTITY_INSERT [dbo].[Employee] OFF
