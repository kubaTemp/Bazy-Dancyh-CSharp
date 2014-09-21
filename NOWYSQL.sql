CREATE TABLE T_GR_OPER ( 
	oper_name varchar(50) NOT NULL,
	gr_name varchar(50) NOT NULL
)
;

CREATE TABLE T_GROUP ( 
	gr_name varchar(50) NOT NULL,
	gr_desc varchar(50)
)
;

CREATE TABLE T_OPERATION ( 
	oper_name varchar(50) NOT NULL,
	oper_desc varchar(50)
)
;

CREATE TABLE T_USER ( 
	name varchar(50) NOT NULL,
	password varchar(50) NOT NULL
)
;

CREATE TABLE T_USER_GR ( 
	name varchar(50) NOT NULL,
	gr_name varchar(50) NOT NULL
)
;

CREATE TABLE T_USER_OPER ( 
	name varchar(50) NOT NULL,
	oper_name varchar(50) NOT NULL
)
;


ALTER TABLE T_GROUP
	ADD CONSTRAINT UQ_GROUP_gr_name UNIQUE (gr_name)
;

ALTER TABLE T_OPERATION
	ADD CONSTRAINT UQ_OPERATION_oper_name UNIQUE (oper_name)
;

ALTER TABLE T_USER
	ADD CONSTRAINT UQ_USER_name UNIQUE (name)
;

ALTER TABLE T_GR_OPER ADD CONSTRAINT PK_GR_OPER 
	PRIMARY KEY CLUSTERED (oper_name, gr_name)
;

ALTER TABLE T_GROUP ADD CONSTRAINT PK_GROUP 
	PRIMARY KEY CLUSTERED (gr_name)
;

ALTER TABLE T_OPERATION ADD CONSTRAINT PK_OPERATION 
	PRIMARY KEY CLUSTERED (oper_name)
;

ALTER TABLE T_USER ADD CONSTRAINT PK_USER 
	PRIMARY KEY CLUSTERED (name)
;

ALTER TABLE T_USER_GR ADD CONSTRAINT PK_USER_GR 
	PRIMARY KEY CLUSTERED (name, gr_name)
;

ALTER TABLE T_USER_OPER ADD CONSTRAINT PK_USER_OPER 
	PRIMARY KEY CLUSTERED (name, oper_name)
;



ALTER TABLE T_GR_OPER ADD CONSTRAINT FK_gr_name 
	FOREIGN KEY (gr_name) REFERENCES T_GROUP (gr_name)
;

ALTER TABLE T_GR_OPER ADD CONSTRAINT FK_oper_name 
	FOREIGN KEY (oper_name) REFERENCES T_OPERATION (oper_name)
;

ALTER TABLE T_USER_GR ADD CONSTRAINT FK_gr_name 
	FOREIGN KEY (gr_name) REFERENCES T_GROUP (gr_name)
;

ALTER TABLE T_USER_GR ADD CONSTRAINT FK_name 
	FOREIGN KEY (name) REFERENCES T_USER (name)
;

ALTER TABLE T_USER_OPER ADD CONSTRAINT FK_name 
	FOREIGN KEY (name) REFERENCES T_USER (name)
;

ALTER TABLE T_USER_OPER ADD CONSTRAINT FK_oper_name 
	FOREIGN KEY (oper_name) REFERENCES T_OPERATION (oper_name)
;