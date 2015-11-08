USE [Expert]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE insertElement
	@ElementName NVARCHAR(128),
	@ElementId UNIQUEIDENTIFIER OUTPUT,
	@FactsAboutElement AS [dbo].[RuleArgument] READONLY
AS
BEGIN
	SET NOCOUNT ON;

	SET @ElementId = NEWID();

    INSERT INTO Element (Id, Name)
	VALUES (@ElementId, @ElementName);

	INSERT INTO FactAboutElement
	SELECT NEWID(), fae.FactId, @ElementId, fae.Value
	FROM @FactsAboutElement AS fae;
END
GO
