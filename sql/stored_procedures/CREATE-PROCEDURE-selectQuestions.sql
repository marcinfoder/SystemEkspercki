USE [Expert]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[selectQuestions]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT
		 q.Id AS [QuestionId],
		 q.Name AS [QuestionName],
		 q.Content AS [QuestionContent],
		 q.RuleId AS [QuestionRuleId]
	FROM Question AS q WITH(NOLOCK);
END