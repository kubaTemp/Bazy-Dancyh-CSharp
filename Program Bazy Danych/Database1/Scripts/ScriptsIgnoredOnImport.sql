
--Syntax Error: Incorrect syntax near GROUP.
--CREATE TABLE GROUP ( 
--	gr_name varchar(50) NOT NULL,
--	gr_desc varchar(50)
--)
--;

GO
--Syntax Error: Incorrect syntax near USER.
--CREATE TABLE USER ( 
--	name varchar(50) NOT NULL,
--	password varchar(50) NOT NULL
--)
--;

GO
--Syntax Error: Incorrect syntax near GROUP.
--ALTER TABLE GROUP
--	ADD CONSTRAINT UQ_GROUP_gr_name UNIQUE (gr_name)
--;

GO
--Syntax Error: Incorrect syntax near USER.
--ALTER TABLE USER
--	ADD CONSTRAINT UQ_USER_name UNIQUE (name)
--;

GO
--Syntax Error: Incorrect syntax near GROUP.
--ALTER TABLE GROUP ADD CONSTRAINT PK_GROUP 
--	PRIMARY KEY CLUSTERED (gr_name)
--;

GO
--Syntax Error: Incorrect syntax near USER.
--ALTER TABLE USER ADD CONSTRAINT PK_USER 
--	PRIMARY KEY CLUSTERED (name)
--;

GO
--Syntax Error: Incorrect syntax near GROUP.
--ALTER TABLE GR_OPER ADD CONSTRAINT FK_gr_name 
--	FOREIGN KEY (gr_name) REFERENCES GROUP (gr_name)
--;

GO
--Syntax Error: Incorrect syntax near GROUP.
--Syntax Error: Incorrect syntax near USER.
--Syntax Error: Incorrect syntax near USER.
--ALTER TABLE USER_GR ADD CONSTRAINT FK_gr_name 
--	FOREIGN KEY (gr_name) REFERENCES GROUP (gr_name)
--;
--
--ALTER TABLE USER_GR ADD CONSTRAINT FK_name 
--	FOREIGN KEY (name) REFERENCES USER (name)
--;
--
--ALTER TABLE USER_OPER ADD CONSTRAINT FK_name 
--	FOREIGN KEY (name) REFERENCES USER (name)
--;



GO
