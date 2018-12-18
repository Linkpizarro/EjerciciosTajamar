USE TCAP

CREATE TABLE ROLES(
	ID_ROL INT IDENTITY(1,1) PRIMARY KEY,
	NAME_ROL NVARCHAR(255) NOT NULL
);
INSERT INTO ROLES VALUES ('CLIENT')
INSERT INTO ROLES VALUES ('PLAYER')

CREATE TABLE STATUSS(
	ID_STATUS INT IDENTITY(1,1) PRIMARY KEY,
	NAME_STATUS NVARCHAR(255) NOT NULL
);
INSERT INTO STATUSS VALUES ('INACTIVE')
INSERT INTO STATUSS VALUES ('ACTIVATE')

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
	STATUS_USER INT NOT NULL DEFAULT 0,
	FOREIGN KEY (ID_ROL) REFERENCES ROLES(ID_ROL),
	FOREIGN KEY (STATUS_USER) REFERENCES STATUSS(ID_STATUS)
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

CREATE TABLE TOKENS(
	ID_TOKEN INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ID_USER INT NOT NULL,
	VALUE_TOKEN TEXT NOT NULL,
	START_TOKEN DATETIME NOT NULL,
	END_TOKEN DATETIME NOT NULL,
	FOREIGN KEY (ID_USER) REFERENCES USERS(ID_USER)
);

GO

CREATE PROCEDURE TOKEN(@E NVARCHAR(255),@T TEXT)
AS
	DECLARE @ID INT
	SELECT @ID = ID_USER FROM USERS WHERE EMAIL_USER = @E
	AND STATUS_USER = 1
	INSERT INTO TOKENS VALUES(@ID,@T,CURRENT_TIMESTAMP,DATEADD(MINUTE,15,CURRENT_TIMESTAMP))
GO

CREATE PROCEDURE CONFIRM(@T TEXT)
AS
	DECLARE @ID INT
	SELECT @ID = ID_USER FROM TOKENS
	WHERE VALUE_TOKEN LIKE @T
	SELECT ID_ROL,NAME_USER,PASSWORD_USER,SURNAME_USER,ID_USER FROM USERS 
	WHERE ID_USER = @ID
	AND STATUS_USER = 1
GO

CREATE PROCEDURE REGISTER(@ROL INT,@N NVARCHAR(45),@S NVARCHAR(45),@E NVARCHAR(255),@P TEXT,@C NVARCHAR(45),@CP NVARCHAR(45))
AS
	DECLARE @COUNT INT
	SELECT  @COUNT = COUNT(EMAIL_USER) FROM USERS
	WHERE EMAIL_USER = @E
	IF(@COUNT = 0)
		BEGIN
			INSERT INTO USERS VALUES(@ROL,@N,@S,@E,@P,
			NULL,@C,@CP,CURRENT_TIMESTAMP,CURRENT_TIMESTAMP,1)
			PRINT 'Registro Completado'
		END
	ELSE
		BEGIN
			PRINT 'El email ya existe'
		END
GO

CREATE PROCEDURE LOGON(@E NVARCHAR(255),@P TEXT)
AS
	SELECT ID_ROL,NAME_USER,PASSWORD_USER,SURNAME_USER,EMAIL_USER FROM USERS 
	WHERE EMAIL_USER = @E
	AND STATUS_USER = 2
GO

--GO
--CREATE TRIGGER ADD_PLAYER_OR_CLIENT ON USERS 
--AFTER INSERT  
--AS
	--DECLARE @ROL INT
	--DECLARE @ID INT
	--SELECT @ID = ID_USER,@ROL = ID_ROL FROM INSERTED
	--IF( @ROL = 1 )
		--BEGIN
			--INSERT INTO CLIENTS VALUES(@ID,NULL,NULL,NULL,NULL)
		--END
	--ELSE
		--BEGIN
			--INSERT INTO PLAYERS VALUES(@ID,NULL,NULL,NULL,NULL,0,0,0,1)
		--END
--GO
select * from tokens
select * from users
delete from players
delete from users

select * from tokens where VALUE_TOKEN like '$2a$12$93Qp.FAIjQDAsrNE1x7DTuJ6geh3bH4UOXb2ml1ycDe5DHt2rzMOu'
select * from users where id_user = 3 and STATUS_USER = 1