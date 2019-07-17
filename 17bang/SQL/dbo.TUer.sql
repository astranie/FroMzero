CREATE TABLE [dbo].[TUer] (
    [Id]              INT        NOT NULL,
    [UserName]        NCHAR (20) NOT NULL,
    [Password]        NCHAR (20) NOT NULL,
    [CorrectPassword] NCHAR (20) NOT NULL,
    [CreatTime]       DATETIME   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

