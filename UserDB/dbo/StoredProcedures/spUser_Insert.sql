CREATE PROCEDURE [dbo].[spUser_Insert]
	@FIrstName nvarchar(50),
	@LastName nvarchar(50)
AS
begin

 insert into db.[User](FirstName, LastName)
 values(@FIrstName, @LastName)

end
