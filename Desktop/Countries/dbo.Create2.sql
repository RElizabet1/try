CREATE PROCEDURE [dbo].[Create2]
    @Название   NCHAR (30),    
    @Id int out

AS
    INSERT INTO Regions (Название)
    VALUES (@Название)
  
    SET @Id=SCOPE_IDENTITY()