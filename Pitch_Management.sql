
/****** Object:  Table [dbo].[USER]    Script Date: 11/8/2021 7:46:03 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USER]') AND type in (N'U'))
DROP TABLE [dbo].[USER]
GO
/****** Object:  Table [dbo].[TIME_SLOT]    Script Date: 11/8/2021 7:46:03 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TIME_SLOT]') AND type in (N'U'))
DROP TABLE [dbo].[TIME_SLOT]
GO
/****** Object:  Table [dbo].[PRICE]    Script Date: 11/8/2021 7:46:03 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PRICE]') AND type in (N'U'))
DROP TABLE [dbo].[PRICE]
GO
/****** Object:  Table [dbo].[PITCH]    Script Date: 11/8/2021 7:46:03 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PITCH]') AND type in (N'U'))
DROP TABLE [dbo].[PITCH]
GO
create database PitchManager
use PitchManager 
CREATE TABLE [dbo].[CATEGORY](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORDER]    Script Date: 11/8/2021 7:46:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PitchName] [varchar](50) NULL,
	[Booker] [varchar](50) NULL,
	[Date] [datetime] NULL,
	[Time] [int] NULL,
	[DayOrdered]  AS (getdate()),
	[Price] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PITCH]    Script Date: 11/8/2021 7:46:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PITCH](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[CateID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRICE]    Script Date: 11/8/2021 7:46:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRICE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CateID] [int] NULL,
	[TimeSlotID] [int] NULL,
	[Price] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIME_SLOT]    Script Date: 11/8/2021 7:46:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIME_SLOT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[From] [int] NULL,
	[To] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USER]    Script Date: 11/8/2021 7:46:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[FullName] [varchar](50) NULL,
	[PhoneNumber] [varchar](10) NULL,
	[IsAdmin] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CATEGORY] ON 

INSERT [dbo].[CATEGORY] ([ID], [Name]) VALUES (1, N'5 people')
INSERT [dbo].[CATEGORY] ([ID], [Name]) VALUES (2, N'7 people')
SET IDENTITY_INSERT [dbo].[CATEGORY] OFF
GO
SET IDENTITY_INSERT [dbo].[PITCH] ON 

INSERT [dbo].[PITCH] ([ID], [Name], [CateID]) VALUES (1, N'1A', 1)
INSERT [dbo].[PITCH] ([ID], [Name], [CateID]) VALUES (2, N'1B', 1)
INSERT [dbo].[PITCH] ([ID], [Name], [CateID]) VALUES (3, N'1C', 1)
INSERT [dbo].[PITCH] ([ID], [Name], [CateID]) VALUES (4, N'1D', 1)
INSERT [dbo].[PITCH] ([ID], [Name], [CateID]) VALUES (5, N'2A', 1)
INSERT [dbo].[PITCH] ([ID], [Name], [CateID]) VALUES (6, N'2B', 1)
INSERT [dbo].[PITCH] ([ID], [Name], [CateID]) VALUES (7, N'2C', 1)
INSERT [dbo].[PITCH] ([ID], [Name], [CateID]) VALUES (8, N'2D', 1)
INSERT [dbo].[PITCH] ([ID], [Name], [CateID]) VALUES (9, N'3A', 2)
INSERT [dbo].[PITCH] ([ID], [Name], [CateID]) VALUES (10, N'3B', 2)
INSERT [dbo].[PITCH] ([ID], [Name], [CateID]) VALUES (11, N'3C', 2)
INSERT [dbo].[PITCH] ([ID], [Name], [CateID]) VALUES (12, N'3D', 2)
SET IDENTITY_INSERT [dbo].[PITCH] OFF
GO
SET IDENTITY_INSERT [dbo].[PRICE] ON 

INSERT [dbo].[PRICE] ([ID], [CateID], [TimeSlotID], [Price]) VALUES (2, 1, 1, 120000)
INSERT [dbo].[PRICE] ([ID], [CateID], [TimeSlotID], [Price]) VALUES (3, 1, 2, 250000)
INSERT [dbo].[PRICE] ([ID], [CateID], [TimeSlotID], [Price]) VALUES (4, 2, 1, 150000)
INSERT [dbo].[PRICE] ([ID], [CateID], [TimeSlotID], [Price]) VALUES (5, 2, 2, 300000)
SET IDENTITY_INSERT [dbo].[PRICE] OFF
GO
SET IDENTITY_INSERT [dbo].[TIME_SLOT] ON 

INSERT [dbo].[TIME_SLOT] ([ID], [From], [To]) VALUES (1, 5, 16)
INSERT [dbo].[TIME_SLOT] ([ID], [From], [To]) VALUES (2, 16, 21)
SET IDENTITY_INSERT [dbo].[TIME_SLOT] OFF
GO
SET IDENTITY_INSERT [dbo].[USER] ON 

INSERT [dbo].[USER] ([ID], [Username], [Password], [FullName], [PhoneNumber], [IsAdmin]) VALUES (1, N'Admin', N'123', N'Admin Name', N'1234567890', 1)
INSERT [dbo].[USER] ([ID], [Username], [Password], [FullName], [PhoneNumber], [IsAdmin]) VALUES (2, N'User1', N'123', N'User one Name', N'1234567890', 0)
INSERT [dbo].[USER] ([ID], [Username], [Password], [FullName], [PhoneNumber], [IsAdmin]) VALUES (3, N'User2', N'123', N'User two Name', N'1234567890', 0)
SET IDENTITY_INSERT [dbo].[USER] OFF
GO
ALTER TABLE [dbo].[PITCH]  WITH CHECK ADD FOREIGN KEY([CateID])
REFERENCES [dbo].[CATEGORY] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PRICE]  WITH CHECK ADD FOREIGN KEY([CateID])
REFERENCES [dbo].[CATEGORY] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PRICE]  WITH CHECK ADD FOREIGN KEY([TimeSlotID])
REFERENCES [dbo].[TIME_SLOT] ([ID])
ON DELETE CASCADE
GO
