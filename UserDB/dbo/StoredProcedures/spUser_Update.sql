CREATE PROCEDURE [dbo].[spUser_Update]
	@Id int,
	@FIrstName nvarchar(50),
	@LastName nvarchar(50)
AS
begin
	update dbo.[User]
	set FirstName = @FIrstName, LastName = @LastName
	where Id = @Id;
end
