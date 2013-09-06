CREATE VIEW [payroll].[payroll_denomination_info]
AS
SELECT     payroll.payroll_denomination.denom_record_id, payroll.payroll_denomination.employee_id, payroll.payroll_denomination.net_pay, payroll.payroll_denomination.note100, 
                      payroll.payroll_denomination.note50, payroll.payroll_denomination.note10, payroll.payroll_denomination.note5, payroll.payroll_denomination.note1, 
                      payroll.payroll_denomination.cent50, payroll.payroll_denomination.cent25, payroll.payroll_denomination.cent10, payroll.payroll_denomination.cent5, 
                      payroll.payroll_denomination.cent1, payroll.payroll_denomination.data_version
FROM         payroll.payroll_denomination INNER JOIN
                      hrm.employee ON payroll.payroll_denomination.employee_id = hrm.employee.employee_id
WHERE     (hrm.employee.deleted = 0)