-- ְ角色表
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Role]') AND type in (N'U'))
DROP TABLE [dbo].[Role]

GO

CREATE TABLE [dbo].[Role](
	[Id] [int] IDENTITY(1,1) NOT NULL,	
	[RoleName] [nvarchar](200) NULL DEFAULT '',
	
	[ProvinceId] [int] NULL DEFAULT ((0)),
	[CityId] [int] NULL DEFAULT ((0)),
	[AreaId] [int] NULL DEFAULT ((0)),
	[DepartmentId] [int] NULL DEFAULT ((0)),
	
	[ProvinceIds] [nvarchar](200) NULL DEFAULT '',
	[CityIds]  [nvarchar](200) NULL DEFAULT '',
	[AreaIds]  [nvarchar](200) NULL DEFAULT '',
	[DepartmentIds] [nvarchar](200) NULL DEFAULT '',
	
	[DepartmentNames] [nvarchar](200) NULL DEFAULT '',
	
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