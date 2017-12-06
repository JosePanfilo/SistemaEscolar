ALTER PROCEDURE [dbo].[P_InsertProfesor]
	-- Add the parameters for the stored procedure here
	@NoControl int out,
	@Nombre nvarchar(50),
	@ApellidoPaterno nvarchar(50),
	@ApellidoMaterno nvarchar(50),
	@Correo nvarchar(50),
	@Telefono nvarchar(50) 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert Into Profesor
	Values (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Correo, @Telefono)

	set @NoControl = @@IDENTITY
END