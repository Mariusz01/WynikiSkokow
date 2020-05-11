CREATE TABLE [dbo].[Skoczek] (
    [ID]       INT             IDENTITY (1, 1) NOT NULL,
    [Imie]     NVARCHAR (MAX)  NOT NULL,
    [Nazwisko] NVARCHAR (MAX)  NOT NULL,
    [Kraj]     NVARCHAR (MAX)  NOT NULL,
    [Skok1]    DECIMAL (18, 2) NULL,
    [Skok2]    DECIMAL (18, 2) NULL,
    [Punkty]   DECIMAL (18, 2) NULL,
    [Miejsce]  INT             NULL,
    CONSTRAINT [PK_Skoczek] PRIMARY KEY CLUSTERED ([ID] ASC)
);

