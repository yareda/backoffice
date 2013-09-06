Create FUNCTION [fixedasset].[get_current_bookvalue](@id as int)
RETURNS decimal(18,2)
BEGIN
	Declare @value as decimal(18,2)
	select @value = Min(fixedasset.depreciation.book_value_at_end_of_year)
	from fixedasset.depreciation
	group by fixedasset.depreciation.asset_id
	having fixedasset.depreciation.asset_id = @id
	return @value
END