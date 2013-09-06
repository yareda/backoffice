Create FUNCTION [fixedasset].[get_depericiation_to_date](@id as int)
RETURNS decimal(18,2)
BEGIN
	Declare @value as decimal(18,2)
	select @value = sum(fixedasset.depreciation.deprecation_expense)
	from fixedasset.depreciation
	group by fixedasset.depreciation.asset_id
	having fixedasset.depreciation.asset_id = @id
	return @value
END