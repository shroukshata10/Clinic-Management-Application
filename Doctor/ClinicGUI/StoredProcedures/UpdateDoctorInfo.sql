SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE UpdateDoctorInfo
@DName VARCHAR (30),
@D_Address  VARCHAR(50),
@Dphone_number char(11),
@Fees real,
@Password Varchar(30),
@DUser_Name  varchar(50),
@User_name  varchar(50)

AS
BEGIN
	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Update  Doctor SET DName=@DName , D_Address=@D_Address , Dphone_number=@Dphone_number , Fees =@Fees WHERE DUser_Name=@DUser_Name;
	Update Account SET Password=@Password WHERE  User_name=@User_name;
END
GO