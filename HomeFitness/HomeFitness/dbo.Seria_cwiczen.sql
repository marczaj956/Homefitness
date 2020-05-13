CREATE TABLE [dbo].[Seria_cwiczen] (
    [Nr_Serii]        INT       NOT NULL IDENTITY,
    [Nazwa_serii]     CHAR (32) NULL,
    [Cwiczona_partia] CHAR (32) NULL,
    CONSTRAINT [Seria_cwiczen_PK] PRIMARY KEY CLUSTERED ([Nr_Serii] ASC)
);

