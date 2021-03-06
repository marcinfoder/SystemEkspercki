USE [Expert]
GO
/****** Object:  StoredProcedure [dbo].[insertRule]    Script Date: 2015-11-08 17:07:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[insertRule] 
	@RuleName NVARCHAR(32),
	@QuestionContent NVARCHAR(128),
	@CreatingFactGuid UNIQUEIDENTIFIER,
	@RuleArgs AS [dbo].[RuleArgument] READONLY,
	@RuleId UNIQUEIDENTIFIER OUTPUT,
	@QuestionId UNIQUEIDENTIFIER OUTPUT
AS
BEGIN
	SET NOCOUNT ON;

    SET @RuleId = NEWID();
	SET @QuestionId = NEWID();

	INSERT INTO Question (Id, RuleId, Content)
	VALUES (@QuestionId, @RuleId, @QuestionContent);

	INSERT INTO [Rule] (Id, QuestionId, CreatingFactId, Name)
	VALUES (@RuleId, @QuestionId, @CreatingFactGuid, @RuleName);

	INSERT INTO RuleArguments
	SELECT NEWID() AS [Id], ra.FactId AS [FactId], @RuleId AS [RuleId], ra.Value AS [RequiredValue]
	FROM @RuleArgs AS ra;
END
