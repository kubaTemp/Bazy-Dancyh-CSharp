CREATE TABLE USER_OPER ( 
	name varchar(50) NOT NULL,
	oper_name varchar(50) NOT NULL
)
;

ALTER TABLE USER_OPER ADD CONSTRAINT PK_USER_OPER 
	PRIMARY KEY CLUSTERED (name, oper_name)
;

ALTER TABLE USER_OPER ADD CONSTRAINT FK_name 
	FOREIGN KEY (name) REFERENCES USER (name)
;

ALTER TABLE USER_OPER ADD CONSTRAINT FK_oper_name 
	FOREIGN KEY (oper_name) REFERENCES OPERATION (oper_name)
;



