use HOSPITAL
GO
CREATE PROCEDURE DOCTORESPECIALIDAD(@ESP NVARCHAR(40))
AS
	SELECT DOCTOR_NO,APELLIDO,ESPECIALIDAD,HOSPITAL.NOMBRE AS HOSPITAL,SALARIO FROM DOCTOR  
    INNER JOIN HOSPITAL ON HOSPITAL.HOSPITAL_COD = DOCTOR.HOSPITAL_COD 
    WHERE ESPECIALIDAD = @ESP
GO
CREATE PROCEDURE MODIFICARDOCTOR(@ID INT,@A NVARCHAR(40),@H NVARCHAR(40),@E NVARCHAR(40),@S INT)
AS
	DECLARE @COD_H INT;
	SELECT @COD_H=HOSPITAL_COD FROM HOSPITAL WHERE NOMBRE = @H;
	UPDATE DOCTOR SET HOSPITAL_COD = @COD_H,APELLIDO = @A,ESPECIALIDAD = @E,SALARIO = @S
	WHERE DOCTOR_NO = @ID;
GO
CREATE PROCEDURE INSERTARDOCTOR(@A NVARCHAR(40),@H NVARCHAR(40),@E NVARCHAR(40),@S INT)
AS
	DECLARE @COD_H INT;
	SELECT @COD_H=HOSPITAL_COD FROM HOSPITAL WHERE NOMBRE = @H;
	DECLARE @COD_D INT;
	SELECT @COD_D = MAX(DOCTOR_NO) + 1 FROM DOCTOR
	INSERT INTO DOCTOR VALUES (@COD_H,@COD_D,@A,@E,@S)
GO
