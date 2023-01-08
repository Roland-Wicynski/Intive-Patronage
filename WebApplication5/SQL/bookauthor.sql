USE [Book]
GO

/****** Object:  Table [dbo].[BookAuthor]    Script Date: 1/8/2023 11:19:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BookAuthor](
	[BookId] [int] NOT NULL,
	[AuthorId] [int] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[BookAuthor]  WITH CHECK ADD  CONSTRAINT [FK_BookAuthor_Book] FOREIGN KEY([BookId])
REFERENCES [dbo].[Book] ([Id])
GO

ALTER TABLE [dbo].[BookAuthor] CHECK CONSTRAINT [FK_BookAuthor_Book]
GO

ALTER TABLE [dbo].[BookAuthor]  WITH CHECK ADD  CONSTRAINT [Intermediate table Author] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Author] ([Id])
GO

ALTER TABLE [dbo].[BookAuthor] CHECK CONSTRAINT [Intermediate table Author]
GO


