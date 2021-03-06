USE [Expert]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[selectRules]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT
		 r.Id AS [RuleId],
		 r.Name AS [RuleName],
		 r.QuestionId AS [RuleQuestionId],
		 r.CreatingFactId AS [RuleCreatingFactId]
	FROM [Rule] AS r WITH(NOLOCK);
END