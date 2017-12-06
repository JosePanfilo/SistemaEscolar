ALTER PROCEDURE [dbo].[SP_InsertCuatrimestre]
	-- Add the parameters for the stored procedure here
	@IDCuatrimestre int out,
	@Periodo nvarchar(50),
	@A�o int,
	@Activo nvarchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert Into Cuatrimestre
	Values (@Periodo, @A�o, @Activo)

	set @IDCuatrimestre = @@IDENTITY
END