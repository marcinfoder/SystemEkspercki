USE [Expert]
GO
/****** Object:  StoredProcedure [dbo].[selectRulesAndQuestions]    Script Date: 2015-11-05 18:57:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[selectRulesAndQuestions]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT
		 r.Id AS [RuleId],
		 r.Name AS [RuleName],
		 q.Id AS [QuestionId],
		 q.Name AS [QuestionName],
		 q.Content AS [QuestionContent],
		 r.CreatingFactId AS [RuleCreatingFactId],
		 f.Name AS [RuleCreatingFactName],
		 ra.FactId AS [RuleArgument],
		 ra.RequiredValue AS [ArgumentRequiredValue]
	FROM Question AS q WITH(NOLOCK)
	JOIN [Rule] AS r WITH(NOLOCK) ON q.RuleId = r.Id
	JOIN RuleArguments AS ra WITH(NOLOCK) ON ra.RuleId = r.Id
	JOIN Fact AS f WITH(NOLOCK) ON f.Id = r.CreatingFactId;
END