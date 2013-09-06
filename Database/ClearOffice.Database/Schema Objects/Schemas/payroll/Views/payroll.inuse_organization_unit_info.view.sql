CREATE VIEW payroll.inuse_organization_unit_info
AS
SELECT     node_id, node_name
FROM         hrm.organization
WHERE     (node_id IN
                          (SELECT DISTINCT node_id
                            FROM          hrm.employee))