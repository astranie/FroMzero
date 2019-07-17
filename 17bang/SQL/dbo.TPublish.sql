CREATE TABLE [dbo].[TPublish]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Title] NTEXT NOT NULL, 
    [Description] NTEXT NULL, 
    [Keyword] NCHAR(30) NULL, 
    [HelperName] NCHAR(10) NULL, 
    [Money] INT NULL
)
