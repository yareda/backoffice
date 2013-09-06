CREATE VIEW stock.issue_info
AS
SELECT     stock.issue.issue_id, stock.issue.status_id, stock.issue.warehouse_id, stock.issue.issue_no, stock.issue.issue_date, stock.issue.issued_by, 
                      stock.issue.posted_date, stock.issue.posted_by, stock.issue.remark, stock.issue.issued_to, stock.warehouse.name AS warehouse_name, 
                      stock.transaction_status.name AS status_name
FROM         stock.issue INNER JOIN
                      stock.warehouse ON stock.issue.warehouse_id = stock.warehouse.warehouse_id INNER JOIN
                      stock.transaction_status ON stock.issue.status_id = stock.transaction_status.status_id