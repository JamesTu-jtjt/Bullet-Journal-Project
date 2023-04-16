INSERT INTO Acc_pass ([Account],[Password],[name],
						[BirthY],[BirthM],[BirthD])
			VALUES ('test','test','test',1999,1,1);
SELECT * FROM Acc_pass;
INSERT INTO person_index([Table_type],[Table_name],[Account])VALUES ('LYD','log_year_datatest','test');
INSERT INTO person_index([Table_type],[Table_name],[Account])VALUES ('LMD','log_month_datatest','test');
INSERT INTO person_index([Table_type],[Table_name],[Account])VALUES ('LDD','log_day_datatest','test');
INSERT INTO person_index([Table_type],[Table_name],[Account])VALUES ('PL','proj_listtest','test');

INSERT INTO person_index([Table_type],[Table_name],[Account])VALUES ('PD','proj_datatest','test');
CREATE TABLE [dbo].[log_year_datatest] (
    [ID] INT NOT NULL PRIMARY KEY,
	[Year] INT NOT NULL,
	[Logname] NVARCHAR(50) NOT NULL,
	[Tag] NVARCHAR(50) NOT NULL,
	[Description] NVARCHAR(MAX) 
);
CREATE TABLE [dbo].[log_month_datatest] (
	[ID] INT NOT NULL PRIMARY KEY,
	[Year] INT NOT NULL,
	[Month] INT,
	[Logname] NVARCHAR(50) NOT NULL,
	[Tag] NVARCHAR(50) NOT NULL,
	[Description] NVARCHAR(MAX) 
);
CREATE TABLE [dbo].[log_day_datatest] (
	[ID] INT NOT NULL PRIMARY KEY,
	[Year] INT NOT NULL,
	[Month] INT,
	[Day] INT,
	[Logname] NVARCHAR(50) NOT NULL,
	[Tag] NVARCHAR(50) NOT NULL,
	[Description] NVARCHAR(MAX) 
);
CREATE TABLE [dbo].[proj_listtest] (
	[Tag] NVARCHAR(50) NOT NULL PRIMARY KEY,
	[StartYear] INT NOT NULL,
	[EndYear] INT NOT NULL,
	[StartMonth] INT NOT NULL,
	[EndMonth] INT NOT NULL,
	[Description] NVARCHAR(MAX)
);

CREATE TABLE [dbo].[proj_datatest] (
	[ID] INT NOT NULL PRIMARY KEY,
	[Tag] NVARCHAR(50) NOT NULL,
	[Logname] NVARCHAR(50) NOT NULL,
	[Year] INT NOT NULL,
	[Month] INT,
	[Day] INT,
	[Description] NVARCHAR(MAX)
);

INSERT INTO log_year_datatest([ID],[Year],[Logname],[Tag],[Description])
VALUES (100,2022,'New years mission','year_sch','Waking up before ７ a.m.');

INSERT INTO log_month_datatest([ID],[Year],[Month],[Logname],[Tag],[Description])
VALUES (1000,2022,1,'final_proj','school','deadline　is 1/10 and present on　1/15');
INSERT INTO log_month_datatest([ID],[Year],[Month],[Logname],[Tag],[Description])
VALUES (1001,2022,1,'exercise','exercise','exercise at least once a week');

INSERT INTO log_day_datatest([ID],[Year],[Month],[Day],[Logname],[Tag],[Description])
VALUES (10000,2022,1,1,'exercise','exercise','swimming');
INSERT INTO log_day_datatest([ID],[Year],[Month],[Day],[Logname],[Tag],[Description])
VALUES (10001,2022,1,3,'exercise','exercise','gym');
INSERT INTO log_day_datatest([ID],[Year],[Month],[Day],[Logname],[Tag],[Description])
VALUES (10002,2022,1,7,'exercise','exercise','swimming');
INSERT INTO log_day_datatest([ID],[Year],[Month],[Day],[Logname],[Tag],[Description])
VALUES (10003,2022,1,9,'exercise','exercise','swimming');
INSERT INTO log_day_datatest([ID],[Year],[Month],[Day],[Logname],[Tag],[Description])
VALUES (10004,2022,1,10,'final_proj','school','final check');
INSERT INTO log_day_datatest([ID],[Year],[Month],[Day],[Logname],[Tag],[Description])
VALUES (10005,2022,1,10,'exercise','exercise','gym');


INSERT INTO proj_listtest([Tag],[StartYear],[EndYear],[StartMonth],[EndMonth],[Description])
VALUES ('final_proj',2021,2022,12,1,'Winprogram');
INSERT INTO proj_listtest([Tag],[StartYear],[EndYear],[StartMonth],[EndMonth],[Description])
VALUES ('exercise',2022,2022,1,12,'exercise at least once a week');

INSERT INTO proj_datatest([ID],	[Tag],[Logname],[Year],[Month],[Day],[Description])
VALUES (10000,'exercise','exercise',2022,1,1,'swimming');
INSERT INTO proj_datatest([ID],	[Tag],[Logname],[Year],[Month],[Day],[Description])
VALUES (10001,'exercise','exercise',2022,1,3,'gym');
INSERT INTO proj_datatest([ID],	[Tag],[Logname],[Year],[Month],[Day],[Description])
VALUES (10002,'exercise','exercise',2022,1,7,'swimming');
INSERT INTO proj_datatest([ID],	[Tag],[Logname],[Year],[Month],[Day],[Description])
VALUES (10003,'exercise','exercise',2022,1,9,'swimming');
INSERT INTO proj_datatest([ID],	[Tag],[Logname],[Year],[Month],[Day],[Description])
VALUES (10004,'final_proj','school',2022,1,10,'final check');
INSERT INTO proj_datatest([ID],	[Tag],[Logname],[Year],[Month],[Day],[Description])
VALUES (10005,'exercise','exercise',2022,1,10,'gym');

