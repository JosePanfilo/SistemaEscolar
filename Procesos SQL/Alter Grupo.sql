ALTER PROCEDURE [dbo].[SP_InsertGrupo]
	-- Add the parameters for the stored procedure here
	@IDGrupo int out,
	@NomGrupo nvarchar(50),
	@Activo nvarchar(50),
	@IDCuatrimestre int 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert Into dbo.Grupo
	Values (@NomGrupo, @Activo, @IDCuatrimestre)

	set @IDGrupo = @@IDENTITY
END