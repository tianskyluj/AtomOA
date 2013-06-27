
-- 插入超级用户	用户名：lan 
truncate table SystemUser
insert into SystemUser(userName,passWord,name)values('lan','2W9E012dgLzwivCZHVZUZQ==','唐富伟')

truncate table GlobalSetting
-- 初始化全局变量 
insert into GlobalSetting(companyName)values('原子OA系统')

