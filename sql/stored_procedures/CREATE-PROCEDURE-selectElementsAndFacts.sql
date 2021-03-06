USE [Expert]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[selectElementsAndFacts]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT
		 f.Id AS [FactId],
		 f.Name AS [FactName],
		 e.Id AS [ElementId],
		 e.Name AS [ElementName],
		 fae.Value AS [Value]
	FROM Fact AS f WITH(NOLOCK)
	JOIN FactAboutElement AS fae WITH(NOLOCK) ON f.Id = fae.FactId
	JOIN Element AS e WITH(NOLOCK) ON e.Id = fae.ElementId;
END