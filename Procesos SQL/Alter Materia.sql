ALTER PROCEDURE [dbo].[SP_InsertMateria]
	-- Add the parameters for the stored procedure here
	@IDMateria int out,
	@NomMateria nvarchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert Into Materia
	Values (@NomMateria)

	set @IDMateria = @@IDENTITY
END