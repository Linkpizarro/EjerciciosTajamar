USE TCAP

CREATE TABLE ROLES(
	ID_ROL INT IDENTITY(1,1) PRIMARY KEY,
	NAME_ROL NVARCHAR(255) NOT NULL
);
INSERT INTO ROLES VALUES ('CLIENT')
INSERT INTO ROLES VALUES ('PLAYER')

CREATE TABLE USERS(
	ID_USER INT IDENTITY(1,1) PRIMARY KEY,
	ID_ROL INT NOT NULL,
	NAME_USER NVARCHAR(45) NOT NULL,
	SURNAME_USER NVARCHAR(45) NOT NULL,
	EMAIL_USER NVARCHAR(255) NOT NULL,
	PASSWORD_USER TEXT NOT NULL,
	IMAGE_USER TEXT NULL,
	COUNTRY_USER NVARCHAR(45) NOT NULL,
	CP_USER NVARCHAR(45) NOT NULL,
	CREATED_USER DATETIME NOT NULL,
	UPDATED_USER DATETIME NOT NULL,
	FOREIGN KEY (ID_ROL) REFERENCES ROLES(ID_ROL)
);

CREATE TABLE PLAYERS(
	ID_PLAYER INT IDENTITY(1,1) PRIMARY KEY,
	ID_USER INT NOT NULL,
	NICK_PLAYER NVARCHAR(45)NULL,
	AGE_PLAYER INT NULL,
	SEX_PLAYER NVARCHAR(1) NULL CHECK (SEX_PLAYER IN('M','F')),
	DESCRIPTION_PLAYER NVARCHAR(255) NULL,
	PP_PLAYER INT NOT NULL DEFAULT 0,
	NP_PLAYER INT NOT NULL DEFAULT 0,
	SEALS_PLAYER INT NOT NULL DEFAULT 0,
	LEVEL_PLAYER INT NOT NULL DEFAULT 1,
	FOREIGN KEY (ID_USER) REFERENCES USERS(ID_USER)
);

CREATE TABLE CLIENTS(
	ID_CLIENT INT IDENTITY(1,1) PRIMARY KEY,
	ID_USER INT NOT NULL,
	DNI_CLIENT NVARCHAR(45) NULL,
	ADDRESS_CLIENT NVARCHAR(255) NULL,
	MOBILE_CLIENT NVARCHAR(45) NULL,
	TELEPHONE_CLIENT NVARCHAR(45) NULL,
	FOREIGN KEY (ID_USER) REFERENCES USERS(ID_USER)
);

GO
CREATE TRIGGER INSERT_USER ON USERS 
AFTER INSERT  
AS
	DECLARE @ROL INT
	DECLARE @ID INT
	SELECT @ID = ID_USER,@ROL = ID_ROL FROM INSERTED
	IF( @ROL = 1 )
		BEGIN
			INSERT INTO CLIENTS VALUES(@ID,NULL,NULL,NULL,NULL)
		END
	ELSE
		BEGIN
			INSERT INTO PLAYERS VALUES(@ID,NULL,NULL,NULL,NULL,0,0,0,1)
		END
GO

CREATE PROCEDURE INSERTUSER(@ROL INT,@N NVARCHAR(45),@S NVARCHAR(45),@E NVARCHAR(255),@P TEXT,@C NVARCHAR(45),@CP NVARCHAR(45))
AS
	INSERT INTO USERS VALUES(@ROL,@N,@S,@E,@P,
	NULL,@C,@CP,CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)
GO
