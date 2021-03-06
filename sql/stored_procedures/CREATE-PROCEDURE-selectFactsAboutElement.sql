USE [Expert]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[selectFactsAboutElement]
	@elementId UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON;

    SELECT
		 f.Id AS [FactId],
		 f.Name AS [FactName],
		 fae.Value AS [Value]
	FROM Fact AS f WITH(NOLOCK)
	JOIN FactAboutElement AS fae WITH(NOLOCK) ON f.Id = fae.FactId
	WHERE fae.ElementId = @elementId;
END