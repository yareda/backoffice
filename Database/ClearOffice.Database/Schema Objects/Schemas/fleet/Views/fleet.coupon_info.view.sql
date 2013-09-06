CREATE VIEW fleet.coupon_info
AS
SELECT     fleet.coupon.coupon_id, fleet.coupon.coupon_label, fleet.coupon.purchased_from, fleet.coupon.date_purchased, fleet.coupon.cash_value, 
                      SUM(fleet.coupon_transaction.cash_amount) AS consumed_cash_amount, SUM(fleet.coupon_transaction.value_amount) AS consumed_value_amount, 
                      fleet.coupon.cash_value - SUM(fleet.coupon_transaction.value_amount) AS remaining_amount
FROM         fleet.coupon LEFT OUTER JOIN
                      fleet.coupon_transaction ON fleet.coupon.coupon_id = fleet.coupon_transaction.coupon_id
GROUP BY fleet.coupon.coupon_id, fleet.coupon.coupon_label, fleet.coupon.purchased_from, fleet.coupon.date_purchased, fleet.coupon.cash_value