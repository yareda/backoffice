
create FUNCTION [wms].[get_payment_method_text] 
(
	@val as int
)
RETURNS nvarchar(50)
AS
BEGIN
	if @val = 1
		return 'cash'
	if @val = 2
		return 'check'
	if @val = 3
		return 'bank transfer'
	return 'other'
END