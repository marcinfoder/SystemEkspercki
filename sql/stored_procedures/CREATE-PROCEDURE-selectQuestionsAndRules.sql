USE [Expert]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[selectQuestionsAndRules]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT
		 q.Id AS [QuestionId],
		 q.Name AS [QuestionName],
		 q.Content AS [QuestionContent],
		 r.Id AS [RuleId],
		 r.Name AS [RuleName],
		 r.CreatingFactId AS [RuleCreatingFactId]
	FROM Question AS q WITH(NOLOCK)
	JOIN [Rule] AS r WITH(NOLOCK) ON q.RuleId = r.Id;
END