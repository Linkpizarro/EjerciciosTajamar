USE HOSPITAL
GO
CREATE VIEW EMPLEADOS
AS
	SELECT E.EMP_NO AS NUMERO,E.APELLIDO,E.SALARIO,E.OFICIO,
	D.DNOMBRE AS DEPARTAMENTO FROM EMP E
	INNER JOIN DEPT D
	ON D.DEPT_NO = E.DEPT_NO
GO
CREATE PROCEDURE MOSTRAR_EMPLEADOS(@P NVARCHAR(40))
AS
	SELECT * FROM EMPLEADOS WHERE UPPER(DEPARTAMENTO) = UPPER(@P)
GO
CREATE PROCEDURE DATOS_DEPARTAMENTOS(@P NVARCHAR(40))
AS
	SELECT COUNT(NUMERO) AS PERSONAS, SUM(SALARIO) AS TOTAL
	FROM EMPLEADOS WHERE UPPER(DEPARTAMENTO) = UPPER(@P)
	GROUP BY UPPER(DEPARTAMENTO)
GO
CREATE PROCEDURE MOSTRAR_DATOS_EMPLEADOS(@P NVARCHAR(40),@X NVARCHAR(40))
AS
	SELECT * FROM EMPLEADOS WHERE UPPER(DEPARTAMENTO) = UPPER(@P)
	AND UPPER(APELLIDO) = UPPER(@X)
GO
CREATE PROCEDURE ACTUALIZAR_DATOS_EMPLEADOS(@P NVARCHAR(40),@X NVARCHAR(40),@S NVARCHAR(40),@O NVARCHAR(40),@D NVARCHAR(40))
AS
	UPDATE EMP SET SALARIO = @S,OFICIO = UPPER(@O),DEPT_NO = (SELECT DEPT_NO FROM DEPT WHERE DNOMBRE = @D)
	WHERE DEPT_NO = (SELECT DEPT_NO FROM DEPT WHERE DNOMBRE = @P) AND APELLIDO = @X
GO
CREATE PROCEDURE ELIMINAR_EMPLEADO(@P NVARCHAR(40),@X NVARCHAR(40))
AS
	DELETE FROM EMP WHERE DEPT_NO =  (SELECT DEPT_NO FROM DEPT WHERE DNOMBRE = @P)
	AND APELLIDO = @X
GO