USE [Expert]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[selectFacts]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT
		 f.Id AS [FactId],
		 f.Name AS [FactName]
	FROM Fact AS f WITH(NOLOCK);
END