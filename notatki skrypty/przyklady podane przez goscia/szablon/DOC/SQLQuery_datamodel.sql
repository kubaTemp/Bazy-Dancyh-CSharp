USE [proba]
GO
/****** Object:  Table [dbo].[Table2]    Script Date: 04/18/2011 15:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table2](
	[id] [smallint] IDENTITY(2,1) NOT NULL,
	[typ] [nchar](5) NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Table2] PRIMARY KEY NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table1]    Script Date: 04/18/2011 15:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table1](
	[nr] [smallint] IDENTITY(12,1) NOT NULL,
	[name] [nvarchar](10) NULL,
	[id] [smallint] NULL,
 CONSTRAINT [PK_Table1] PRIMARY KEY CLUSTERED 
(
	[nr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Table1_Table2]    Script Date: 04/18/2011 15:52:06 ******/
ALTER TABLE [dbo].[Table1]  WITH CHECK ADD  CONSTRAINT [FK_Table1_Table2] FOREIGN KEY([id])
REFERENCES [dbo].[Table2] ([id])
GO
ALTER TABLE [dbo].[Table1] CHECK CONSTRAINT [FK_Table1_Table2]
GO
