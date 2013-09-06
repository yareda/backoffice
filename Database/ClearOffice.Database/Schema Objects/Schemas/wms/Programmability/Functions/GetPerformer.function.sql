Create FUNCTION [wms].GetPerformer 
(
	@performedBy as int,
	@performerId as int
)
RETURNS nvarchar(50)
AS
BEGIN
	Declare @performer as nvarchar(200)
	if @performedBy = 1
	begin
		select @performer = wms.workshop_employees_info.full_name
		from wms.workshop_employees_info
		where wms.workshop_employees_info.employee_id = @performerId
	end
	if @performedBy = 2
	begin
		select @performer = wms.vendor.name
		from wms.vendor
		where wms.vendor.vendor_id = @performerId
	end
	
	return @performer
END