ALTER PROCEDURE [dbo].[SP_InsertMaterial]
	-- Add the parameters for the stored procedure here
	@IDMaterial int out,
	@NomMaterial nvarchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert Into Material
	Values (@NomMaterial)

	set @IDMaterial = @@IDENTITY
END