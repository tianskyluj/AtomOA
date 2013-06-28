

-- 用户表
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SystemUser]') AND type in (N'U'))
DROP TABLE [dbo].[SystemUser]

GO

CREATE TABLE [dbo].[SystemUser](
	[Id] [int] IDENTITY(1,1) NOT NULL,	
	[CompanyId] [int] NULL DEFAULT ((0)),
	[UserName] [nvarchar](200) NULL DEFAULT '',
	[PassWord] [nvarchar](200) NULL DEFAULT '',
	[Name] [nvarchar](200) NULL DEFAULT '',
	[Phone] [nvarchar](200) NULL DEFAULT '',
	[Email] [nvarchar](200) NULL DEFAULT '',
	[QQ] [nvarchar](200) NULL DEFAULT '',
	[Avatar] [nvarchar](200) NULL DEFAULT '',
	
	[IfAdmin] [int] NULL DEFAULT ((0)),
	[ProvinceId] [int] NULL DEFAULT ((0)),
	[CityId] [int] NULL DEFAULT ((0)),
	[AreaId] [int] NULL DEFAULT ((0)),
	[DepartmentId] [int] NULL DEFAULT ((0)),
	
	[state] [int] NULL DEFAULT ((0)),
	[remark] [nvarchar](500) NULL DEFAULT '',
	[createUser] [int] NULL DEFAULT ((0)),
	[createIp] [nvarchar](50) NULL DEFAULT '',
	[createTime] [datetime] NULL DEFAULT (getdate()),
	[updateUser] [int] NULL DEFAULT ((0)) ,
	[updateIp] [nvarchar](50) NULL DEFAULT '',
	[updateTime] [datetime] NULL DEFAULT (getdate()),
 PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
