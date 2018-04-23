CREATE TABLE [dbo].[Horoscope]
(
[ID] [int] NOT NULL IDENTITY(1, 1),
[daily] [nvarchar] (1024) COLLATE Latin1_General_CI_AI NULL,
[language] [nvarchar] (8) COLLATE Latin1_General_CI_AI NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Horoscope] ADD CONSTRAINT [PK__Horoscop__3214EC2784448727] PRIMARY KEY CLUSTERED  ([ID]) ON [PRIMARY]
GO
