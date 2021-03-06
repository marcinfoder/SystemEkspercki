USE [Expert]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[selectElements]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT
		 e.Id AS [ElementId],
		 e.Name AS [ElementName]
	FROM Element AS e WITH(NOLOCK);
END