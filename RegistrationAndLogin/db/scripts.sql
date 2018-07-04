CREATE TABLE [dbo].[Users] (
    [Id]              INT              IDENTITY (1, 1) NOT NULL,
    [FirstName]       NVARCHAR (50)    NOT NULL,
    [LastName]        NVARCHAR (50)    NOT NULL,
    [EmailID]         NVARCHAR (255)   NOT NULL,
    [DateOfBirth]     DATETIME         NULL,
    [Password]        NVARCHAR (MAX)   NOT NULL,
    [IsEmailVerified] BIT              NOT NULL,
    [ActivationCode]  UNIQUEIDENTIFIER NOT NULL,
    [ResetPassword]   NVARCHAR (100)   NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);
