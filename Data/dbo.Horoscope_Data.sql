SET IDENTITY_INSERT [dbo].[Horoscope] ON
INSERT INTO [dbo].[Horoscope] ([ID], [daily], [language]) VALUES (1, N'You are lucky today', N'en-US')
INSERT INTO [dbo].[Horoscope] ([ID], [daily], [language]) VALUES (2, N'I dont know German', N'de-DE')
INSERT INTO [dbo].[Horoscope] ([ID], [daily], [language]) VALUES (3, N'I dont know Korean too', N'ko-KR')
SET IDENTITY_INSERT [dbo].[Horoscope] OFF
