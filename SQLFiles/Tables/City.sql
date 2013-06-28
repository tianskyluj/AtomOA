-- 城市表
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[City]') AND type in (N'U'))
DROP TABLE [dbo].[City]

GO

CREATE TABLE [dbo].[City](
	[Id] [int] IDENTITY(1,1) NOT NULL,	
	[ProvinceId] [int] NULL DEFAULT ((0)),		-- 省份Id
	[CityName] [nvarchar](200) NULL DEFAULT '',	-- 城市名称
	
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