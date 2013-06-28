
-- 插入超级用户	用户名：lan -- 密码：12346 (OrwmNwHIjJI=)
truncate table SystemUser
insert into SystemUser(userName,passWord,name,ifAdmin)values('lan','2W9E012dgLzwivCZHVZUZQ==','唐富伟',1)

truncate table GlobalSetting
-- 初始化全局变量 
insert into GlobalSetting(companyName)values('原子OA系统')

