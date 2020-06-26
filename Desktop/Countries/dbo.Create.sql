CREATE PROCEDURE [dbo].[Create]
    @Название   NCHAR (30),
    @Код_страны NCHAR (10),
    @Столица    NCHAR (30),
    @Площадь    FLOAT (53),
    @Население  INT,
    @Регион    NCHAR (30),
    @Id int out

AS
    INSERT INTO Сountries (Название, Код_страны, Столица, Площадь, Население, Регион)
    VALUES (@Название, @Код_страны, @Столица, @Площадь, @Население, @Регион)
  
    SET @Id=SCOPE_IDENTITY()