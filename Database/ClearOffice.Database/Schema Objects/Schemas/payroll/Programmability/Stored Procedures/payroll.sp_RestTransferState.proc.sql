CREATE PROCEDURE [payroll].[sp_RestTransferState]
 
 AS 
 
 UPDATE payroll_current
 SET istransfer = 0