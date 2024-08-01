SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE EnterDiagnosis
@Scientific_Name VARCHAR(20)


AS
BEGIN
	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Disease_Diagnosis(Scientific_Name) Values(@Scientific_Name);
	
END
GO