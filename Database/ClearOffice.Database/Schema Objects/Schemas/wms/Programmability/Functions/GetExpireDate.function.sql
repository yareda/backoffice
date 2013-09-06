
Create FUNCTION [wms].[GetExpireDate] 
(
	@startDate as date,
	@duration as int
)
RETURNS date
AS
BEGIN
	Declare @r as date
	set @r = DateAdd("month",@duration,@startDate)
	return @r
END