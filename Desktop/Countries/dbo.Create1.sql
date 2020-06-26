CREATE PROCEDURE [dbo].[Create1]
	@Название   NCHAR (30),    
    @Id int out

AS
    INSERT INTO Cities(Название)
    VALUES (@Название)
  
    SET @Id=SCOPE_IDENTITY()