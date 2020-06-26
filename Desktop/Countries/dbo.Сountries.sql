CREATE TABLE [dbo].[Сountries] (
    [Id]         INT        IDENTITY (1, 1) NOT NULL,
    [Название]   NCHAR (30) NULL,
    [Код_страны] NCHAR (10) NULL,
    [Столица]    NCHAR (30) NULL,
    [Площадь]    FLOAT (53) NULL,
    [Население]  INT        NULL,
    [Регион]     NCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

