SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GetMyPatient
@DR_UserName VARCHAR(50)

AS
BEGIN
	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT PName,Patient_UserName FROM Patient ,Appointment WHERE DR_UserName=@DR_UserName AND Patient_UserName=PUser_Name;
END