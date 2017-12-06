Alter PROCEDURE [dbo].[SP_InsertUbicacion]
	-- Add the parameters for the stored procedure here
	@IDUbicacion int out,
	@NomUbicacion nvarchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert Into Ubicacion
	Values (@NomUbicacion)

	set @IDUbicacion = @@IDENTITY
END