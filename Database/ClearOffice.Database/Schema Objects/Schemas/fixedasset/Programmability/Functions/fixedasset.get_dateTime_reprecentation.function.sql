CREATE FUNCTION [fixedasset].[get_dateTime_reprecentation](@year as int,@month as int)
RETURNS date
BEGIN
	declare @m as nvarchar(10)
	declare @d as nvarchar(200)
	declare @val as date
	if @month < 10
	begin
		set @m = cast(0 as nvarchar(10))+ cast(@month as nvarchar(10))
	end
	else
		set @m = cast(@month as nvarchar(10))
	set @d = CAST(@year AS nvarchar(10))+@m+'01'
	set @val = CONVERT(date,@d)
	return @val;
END