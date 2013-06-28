-- 角色模块关联表 ，从此表读取用户权限
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RoleModuleRelation]') AND type in (N'U'))
DROP TABLE [dbo].[RoleModuleRelation]

GO

CREATE TABLE [dbo].[RoleModuleRelation](
	[Id] [int] IDENTITY(1,1) NOT NULL,	
	[RoleId] [int] NULL DEFAULT ((0)),
	[ModuleId] [int] NULL DEFAULT ((0)),
	[AuthorityId] [int] NULL DEFAULT ((0)),
	
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