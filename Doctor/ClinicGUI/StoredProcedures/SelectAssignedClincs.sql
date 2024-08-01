SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SelectAssignedClinics
@DUsername  varchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Clinic_name ,Day,Start_time,End_time FROM clinic ,Doctor_Availability WHERE Clinic_ID=ID AND DUsername=DUsername ;
END
GO