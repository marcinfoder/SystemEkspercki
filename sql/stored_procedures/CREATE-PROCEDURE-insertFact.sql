USE [Expert]
GO
 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
CREATE PROCEDURE insertFact 
	@Name NVARCHAR(128),
	@Guid UNIQUEIDENTIFIER = NULL OUTPUT
AS
BEGIN
	SET NOCOUNT ON;

	SET @Guid = NEWID();

    INSERT INTO Fact (Id, Name)
	VALUES (@Guid, @Name);
END;
GO