USE [AuthorizationDabase]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 16.11.2022 13:11:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 16.11.2022 13:11:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Role_ID] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([ID], [Name]) VALUES (1, N'Admin')
INSERT [dbo].[Role] ([ID], [Name]) VALUES (2, N'Client')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [Login], [Password], [Role_ID]) VALUES (1, N'admin', N'admin', 1)
INSERT [dbo].[User] ([ID], [Login], [Password], [Role_ID]) VALUES (2, N'client', N'client', 2)
INSERT [dbo].[User] ([ID], [Login], [Password], [Role_ID]) VALUES (3, N'1234', N'password', 2)
INSERT [dbo].[User] ([ID], [Login], [Password], [Role_ID]) VALUES (4, N'4321', N'1234', 2)
INSERT [dbo].[User] ([ID], [Login], [Password], [Role_ID]) VALUES (5, N'8123', N'8882', 2)
INSERT [dbo].[User] ([ID], [Login], [Password], [Role_ID]) VALUES (6, N'iuygfgh', N'sdfghjk', 2)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([Role_ID])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
