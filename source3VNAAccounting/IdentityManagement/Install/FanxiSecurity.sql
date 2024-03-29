USE [FanxiSecurity]
GO
/****** Object:  Table [dbo].[session]    Script Date: 11/05/2010 10:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[session](
	[sessionid] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](64) NOT NULL,
	[LastUpdate] [datetime] NULL,
 CONSTRAINT [PK_session] PRIMARY KEY CLUSTERED 
(
	[sessionid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[role]    Script Date: 11/05/2010 10:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[role](
	[roleid] [int] IDENTITY(1,1) NOT NULL,
	[AppID] [int] NOT NULL,
	[name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_role] PRIMARY KEY CLUSTERED 
(
	[roleid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Applications]    Script Date: 11/05/2010 10:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Applications](
	[AppID] [int] IDENTITY(1,1) NOT NULL,
	[AppName] [varchar](255) NOT NULL,
	[Description] [varchar](1024) NULL,
	[URL] [varchar](1024) NOT NULL,
 CONSTRAINT [PK__Applicat__8E2CF7D921B6055D] PRIMARY KEY CLUSTERED 
(
	[AppID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[operation]    Script Date: 11/05/2010 10:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[operation](
	[operationid] [int] IDENTITY(1,1) NOT NULL,
	[AppID] [int] NULL,
	[name] [nvarchar](100) NOT NULL,
	[cancreate] [bit] NULL,
	[canread] [bit] NULL,
	[canupdate] [bit] NULL,
	[candelete] [bit] NULL,
	[islocked] [bit] NOT NULL,
 CONSTRAINT [PK_operation] PRIMARY KEY CLUSTERED 
(
	[operationid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[object]    Script Date: 11/05/2010 10:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[object](
	[objectid] [int] IDENTITY(1,1) NOT NULL,
	[AppID] [int] NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[locked] [bit] NOT NULL,
 CONSTRAINT [PK__object__3DC088B54D94879B] PRIMARY KEY CLUSTERED 
(
	[objectid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 11/05/2010 10:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[userid] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](64) NOT NULL,
	[firstname] [nvarchar](50) NULL,
	[familyname] [nvarchar](100) NULL,
	[PasswordFormat] [int] NULL,
	[PasswordSalt] [nvarchar](128) NULL,
	[email] [nvarchar](100) NULL,
	[PasswordQuestion] [nvarchar](256) NULL,
	[PasswordAnswer] [nvarchar](256) NULL,
	[IsApproved] [bit] NULL,
	[IsLockedOut] [bit] NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastLoginDate] [datetime] NULL,
	[LastPasswordChangedDate] [datetime] NULL,
	[LastLockoutDate] [datetime] NOT NULL,
	[FailedPasswordAttemptCount] [int] NULL,
	[FailedPasswordAnswerAttemptCount] [int] NULL,
	[FailedPasswordAttemptWindowStart] [datetime] NULL,
	[FailedPasswordAnswerAttemptWindowStart] [datetime] NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserProfile]    Script Date: 11/05/2010 10:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserProfile](
	[ProfileID] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[PropertyName] [nvarchar](255) NOT NULL,
	[PropertyValuesString] [ntext] NULL,
	[PropertyValuesBinary] [image] NULL,
	[LastUpdateDate] [smalldatetime] NULL,
 CONSTRAINT [PK_UserProfile] PRIMARY KEY CLUSTERED 
(
	[ProfileID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_session]    Script Date: 11/05/2010 10:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_session](
	[userid] [int] NOT NULL,
	[sessionid] [int] NOT NULL,
 CONSTRAINT [PK_user_session] PRIMARY KEY CLUSTERED 
(
	[userid] ASC,
	[sessionid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_role]    Script Date: 11/05/2010 10:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_role](
	[roleid] [int] NOT NULL,
	[userid] [int] NOT NULL,
 CONSTRAINT [PK_user_role] PRIMARY KEY CLUSTERED 
(
	[roleid] ASC,
	[userid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[session_role]    Script Date: 11/05/2010 10:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[session_role](
	[roleid] [int] NOT NULL,
	[sessionid] [int] NOT NULL,
 CONSTRAINT [PK_session_role] PRIMARY KEY CLUSTERED 
(
	[roleid] ASC,
	[sessionid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppToken]    Script Date: 11/05/2010 10:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AppToken](
	[AppTokenID] [int] IDENTITY(1,1) NOT NULL,
	[Token] [varchar](255) NOT NULL,
	[AppName] [varchar](255) NOT NULL,
	[LoginID] [varchar](255) NOT NULL,
	[UserID] [int] NOT NULL,
	[AppID] [int] NOT NULL,
	[CreatedTime] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AppTokenID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[App_User]    Script Date: 11/05/2010 10:48:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[App_User](
	[AppID] [int] NOT NULL,
	[UserID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permission]    Script Date: 11/05/2010 10:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permission](
	[permissionid] [int] IDENTITY(1,1) NOT NULL,
	[AppID] [int] NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[objectid] [int] NOT NULL,
	[operationid] [int] NOT NULL,
 CONSTRAINT [PK_permission] PRIMARY KEY CLUSTERED 
(
	[permissionid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[role_permission]    Script Date: 11/05/2010 10:48:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[role_permission](
	[permissionid] [int] NOT NULL,
	[roleid] [int] NOT NULL,
 CONSTRAINT [PK_role_permission] PRIMARY KEY CLUSTERED 
(
	[permissionid] ASC,
	[roleid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF_user_IsApproved]    Script Date: 11/05/2010 10:48:53 ******/
ALTER TABLE [dbo].[user] ADD  CONSTRAINT [DF_user_IsApproved]  DEFAULT ((0)) FOR [IsApproved]
GO
/****** Object:  Default [DF_user_IsLockedOut]    Script Date: 11/05/2010 10:48:53 ******/
ALTER TABLE [dbo].[user] ADD  CONSTRAINT [DF_user_IsLockedOut]  DEFAULT ((0)) FOR [IsLockedOut]
GO
/****** Object:  Default [DF__operation___crea__5441852A]    Script Date: 11/05/2010 10:48:53 ******/
ALTER TABLE [dbo].[operation] ADD  CONSTRAINT [DF__operation___crea__5441852A]  DEFAULT (NULL) FOR [cancreate]
GO
/****** Object:  Default [DF__operation___read__5535A963]    Script Date: 11/05/2010 10:48:53 ******/
ALTER TABLE [dbo].[operation] ADD  CONSTRAINT [DF__operation___read__5535A963]  DEFAULT (NULL) FOR [canread]
GO
/****** Object:  Default [DF__operation___upda__5629CD9C]    Script Date: 11/05/2010 10:48:53 ******/
ALTER TABLE [dbo].[operation] ADD  CONSTRAINT [DF__operation___upda__5629CD9C]  DEFAULT (NULL) FOR [canupdate]
GO
/****** Object:  Default [DF__operation___dele__571DF1D5]    Script Date: 11/05/2010 10:48:53 ******/
ALTER TABLE [dbo].[operation] ADD  CONSTRAINT [DF__operation___dele__571DF1D5]  DEFAULT (NULL) FOR [candelete]
GO
/****** Object:  Default [DF__operation__locke__5812160E]    Script Date: 11/05/2010 10:48:53 ******/
ALTER TABLE [dbo].[operation] ADD  CONSTRAINT [DF__operation__locke__5812160E]  DEFAULT ('0') FOR [islocked]
GO
/****** Object:  Default [DF__object__locked__4F7CD00D]    Script Date: 11/05/2010 10:48:53 ******/
ALTER TABLE [dbo].[object] ADD  CONSTRAINT [DF__object__locked__4F7CD00D]  DEFAULT ('0') FOR [locked]
GO
/****** Object:  ForeignKey [FK_session_role_role]    Script Date: 11/05/2010 10:48:53 ******/
ALTER TABLE [dbo].[session_role]  WITH CHECK ADD  CONSTRAINT [FK_session_role_role] FOREIGN KEY([roleid])
REFERENCES [dbo].[role] ([roleid])
GO
ALTER TABLE [dbo].[session_role] CHECK CONSTRAINT [FK_session_role_role]
GO
/****** Object:  ForeignKey [FK_session_role_session]    Script Date: 11/05/2010 10:48:53 ******/
ALTER TABLE [dbo].[session_role]  WITH CHECK ADD  CONSTRAINT [FK_session_role_session] FOREIGN KEY([sessionid])
REFERENCES [dbo].[session] ([sessionid])
GO
ALTER TABLE [dbo].[session_role] CHECK CONSTRAINT [FK_session_role_session]
GO
/****** Object:  ForeignKey [FK_role_permission_permission]    Script Date: 11/05/2010 10:48:53 ******/
ALTER TABLE [dbo].[role_permission]  WITH CHECK ADD  CONSTRAINT [FK_role_permission_permission] FOREIGN KEY([permissionid])
REFERENCES [dbo].[permission] ([permissionid])
GO
ALTER TABLE [dbo].[role_permission] CHECK CONSTRAINT [FK_role_permission_permission]
GO
/****** Object:  ForeignKey [FK_role_permission_role]    Script Date: 11/05/2010 10:48:53 ******/
ALTER TABLE [dbo].[role_permission]  WITH CHECK ADD  CONSTRAINT [FK_role_permission_role] FOREIGN KEY([roleid])
REFERENCES [dbo].[role] ([roleid])
GO
ALTER TABLE [dbo].[role_permission] CHECK CONSTRAINT [FK_role_permission_role]
GO
/****** Object:  ForeignKey [FK_permission_object]    Script Date: 11/05/2010 10:48:53 ******/
ALTER TABLE [dbo].[permission]  WITH CHECK ADD  CONSTRAINT [FK_permission_object] FOREIGN KEY([objectid])
REFERENCES [dbo].[object] ([objectid])
GO
ALTER TABLE [dbo].[permission] CHECK CONSTRAINT [FK_permission_object]
GO
/****** Object:  ForeignKey [FK_permission_operation]    Script Date: 11/05/2010 10:48:53 ******/
ALTER TABLE [dbo].[permission]  WITH CHECK ADD  CONSTRAINT [FK_permission_operation] FOREIGN KEY([operationid])
REFERENCES [dbo].[operation] ([operationid])
GO
ALTER TABLE [dbo].[permission] CHECK CONSTRAINT [FK_permission_operation]
GO
/****** Object:  ForeignKey [FK__AppToken__AppID__276EDEB3]    Script Date: 11/05/2010 10:48:54 ******/
ALTER TABLE [dbo].[AppToken]  WITH CHECK ADD  CONSTRAINT [FK__AppToken__AppID__276EDEB3] FOREIGN KEY([AppID])
REFERENCES [dbo].[Applications] ([AppID])
GO
ALTER TABLE [dbo].[AppToken] CHECK CONSTRAINT [FK__AppToken__AppID__276EDEB3]
GO
/****** Object:  ForeignKey [FK_AppToken_user]    Script Date: 11/05/2010 10:48:54 ******/
ALTER TABLE [dbo].[AppToken]  WITH CHECK ADD  CONSTRAINT [FK_AppToken_user] FOREIGN KEY([UserID])
REFERENCES [dbo].[user] ([userid])
GO
ALTER TABLE [dbo].[AppToken] CHECK CONSTRAINT [FK_AppToken_user]
GO
/****** Object:  ForeignKey [FK_App_User_Applications]    Script Date: 11/05/2010 10:48:54 ******/
ALTER TABLE [dbo].[App_User]  WITH CHECK ADD  CONSTRAINT [FK_App_User_Applications] FOREIGN KEY([AppID])
REFERENCES [dbo].[Applications] ([AppID])
GO
ALTER TABLE [dbo].[App_User] CHECK CONSTRAINT [FK_App_User_Applications]
GO
/****** Object:  ForeignKey [FK_App_User_user]    Script Date: 11/05/2010 10:48:54 ******/
ALTER TABLE [dbo].[App_User]  WITH CHECK ADD  CONSTRAINT [FK_App_User_user] FOREIGN KEY([UserID])
REFERENCES [dbo].[user] ([userid])
GO
ALTER TABLE [dbo].[App_User] CHECK CONSTRAINT [FK_App_User_user]
GO
/****** Object:  ForeignKey [FK_user_session_session]    Script Date: 11/05/2010 10:48:54 ******/
ALTER TABLE [dbo].[user_session]  WITH CHECK ADD  CONSTRAINT [FK_user_session_session] FOREIGN KEY([sessionid])
REFERENCES [dbo].[session] ([sessionid])
GO
ALTER TABLE [dbo].[user_session] CHECK CONSTRAINT [FK_user_session_session]
GO
/****** Object:  ForeignKey [FK_user_session_user]    Script Date: 11/05/2010 10:48:54 ******/
ALTER TABLE [dbo].[user_session]  WITH CHECK ADD  CONSTRAINT [FK_user_session_user] FOREIGN KEY([userid])
REFERENCES [dbo].[user] ([userid])
GO
ALTER TABLE [dbo].[user_session] CHECK CONSTRAINT [FK_user_session_user]
GO
/****** Object:  ForeignKey [FK_user_role_role]    Script Date: 11/05/2010 10:48:54 ******/
ALTER TABLE [dbo].[user_role]  WITH CHECK ADD  CONSTRAINT [FK_user_role_role] FOREIGN KEY([roleid])
REFERENCES [dbo].[role] ([roleid])
GO
ALTER TABLE [dbo].[user_role] CHECK CONSTRAINT [FK_user_role_role]
GO
/****** Object:  ForeignKey [FK_user_role_user]    Script Date: 11/05/2010 10:48:54 ******/
ALTER TABLE [dbo].[user_role]  WITH CHECK ADD  CONSTRAINT [FK_user_role_user] FOREIGN KEY([userid])
REFERENCES [dbo].[user] ([userid])
GO
ALTER TABLE [dbo].[user_role] CHECK CONSTRAINT [FK_user_role_user]
GO
