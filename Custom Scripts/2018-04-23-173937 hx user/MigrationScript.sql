/*
This migration script replaces uncommitted changes made to these objects:
Horoscope

Use this script to make necessary schema and data changes for these objects only. Schema changes to any other objects won't be deployed.

Schema changes and migration scripts are deployed in the order they're committed.

Migration scripts must not reference static data. When you deploy migration scripts alongside static data 
changes, the migration scripts will run first. This can cause the deployment to fail. 
Read more at https://documentation.red-gate.com/display/SOC6/Static+data+and+migrations.
*/

SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
PRINT N'Rebuilding [dbo].[Horoscope]'
GO
CREATE TABLE [dbo].[RG_Recovery_1_Horoscope]
(
[ID] [int] NOT NULL IDENTITY(1, 1),
[daily] [nvarchar] (1024) COLLATE Latin1_General_CI_AI NULL,
[language] [nvarchar] (8) COLLATE Latin1_General_CI_AI NULL
) ON [PRIMARY]
GO
INSERT INTO [dbo].[RG_Recovery_1_Horoscope]([daily], [language]) SELECT [daily], [language] FROM [dbo].[Horoscope]
GO
DROP TABLE [dbo].[Horoscope]
GO
EXEC sp_rename N'[dbo].[RG_Recovery_1_Horoscope]', N'Horoscope', N'OBJECT'
GO
PRINT N'Creating primary key [PK__Horoscop__3214EC2784448727] on [dbo].[Horoscope]'
GO
ALTER TABLE [dbo].[Horoscope] ADD CONSTRAINT [PK__Horoscop__3214EC2784448727] PRIMARY KEY CLUSTERED  ([ID]) ON [PRIMARY]
GO

