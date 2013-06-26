

-- 用户表
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SystemUser]') AND type in (N'U'))
DROP TABLE [dbo].[SystemUser]

GO

CREATE TABLE [dbo].[SystemUser](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](200) NULL,
	[PassWord] [nvarchar](200) NULL,
	[Name] [nvarchar](200) NULL,
	[Phone] [nvarchar](200) NULL,
	[Email] [nvarchar](200) NULL,
	
	[state] [int] NULL DEFAULT ((0)),
	[remark] [nvarchar](500) NULL,
	[createUser] [int] NULL DEFAULT ((0)),
	[createIp] [nvarchar](50) NULL,
	[createTime] [datetime] NULL DEFAULT (getdate()),
	[updateUser] [int] NULL DEFAULT ((0)),
	[updateIp] [nvarchar](50) NULL,
	[updateTime] [datetime] NULL DEFAULT (getdate()),
 PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
