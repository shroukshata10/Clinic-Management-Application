SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE EnterMedicine
@Mname VARCHAR(20)

AS
BEGIN
	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO  Medicine (Mname) VALUES (@Mname);
END
GO