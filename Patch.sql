USE LocalizationTest
GO

IF EXISTS(SELECT TOP 1 1 FROM INFORMATION_SCHEMA.TABLES a WHERE a.TABLE_NAME = 'Horoscope')
BEGIN
   DROP TABLE Horoscope	
END
GO

IF NOT EXISTS(SELECT TOP 1 1 FROM INFORMATION_SCHEMA.TABLES a WHERE a.TABLE_NAME = 'Horoscope')
BEGIN
	CREATE TABLE [dbo].[Horoscope](
		[ID] [INT] IDENTITY(1,1) NOT NULL,
		[daily] [NVARCHAR](1024) NULL,
		[language] [NVARCHAR](8) NULL,
	PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
	
	SET IDENTITY_INSERT [dbo].[Horoscope] ON 
	INSERT [dbo].[Horoscope] ([ID], [daily], [language]) VALUES (1, N'You speak English? It is your lucky day!', N'en-US')
	INSERT [dbo].[Horoscope] ([ID], [daily], [language]) VALUES (2, N'There is no German translation yet. But you will win one gajiliion dollars!', N'de-DE')
	SET IDENTITY_INSERT [dbo].[Horoscope] OFF

END