SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE CountPatients
@DR_UserName VARCHAR(50)

AS
BEGIN
	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT COUNT(Patient_UserName) FROM Appointment WHERE DR_UserName=@DR_UserName;
END
GO