ALTER PROCEDURE [dbo].[SP_InsertAlumno]
	-- Add the parameters for the stored procedure here
	@Matricula int out,
	@Nombre nvarchar(50),
	@ApellidoPaterno nvarchar(50),
	@ApellidoMaterno nvarchar(50),
	@Correo nvarchar(50),
	@Telefono nvarchar(50),
	@IDGrupo int 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert Into Alumno
	Values (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Correo, @Telefono, @IDGrupo)

	set @Matricula = @@IDENTITY
END