CREATE TABLE GR_OPER ( 
	oper_name varchar(50) NOT NULL,
	gr_name varchar(50) NOT NULL
)
;

CREATE TABLE GROUP ( 
	gr_name varchar(50) NOT NULL,
	gr_desc varchar(50)
)
;

CREATE TABLE OPERATION ( 
	oper_name varchar(50) NOT NULL,
	oper_desc varchar(50)
)
;

CREATE TABLE USER ( 
	name varchar(50) NOT NULL,
	password varchar(50) NOT NULL
)
;

CREATE TABLE USER_GR ( 
	name varchar(50) NOT NULL,
	gr_name varchar(50) NOT NULL
)
;

CREATE TABLE USER_OPER ( 
	name varchar(50) NOT NULL,
	oper_name varchar(50) NOT NULL
)
;
