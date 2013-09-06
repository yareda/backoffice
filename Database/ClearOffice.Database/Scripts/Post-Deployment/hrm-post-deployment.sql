-- =============================================
-- Drop all existing rows from hrm.lookup table
-- =============================================
/*  */
delete hrm.lookup

go

/* Add HRM Lookup categories  */
insert into hrm.lookup(lookup_id,name,description) values(1,'Sex',null)
insert into hrm.lookup(lookup_id,name,description) values(2,'Religion',null)
insert into hrm.lookup(lookup_id,name,description) values(3,'Nationality',null)
insert into hrm.lookup(lookup_id,name,description) values(4,'Ethnicity',null)
insert into hrm.lookup(lookup_id,name,description) values(5,'JobType',null)
insert into hrm.lookup(lookup_id,name,description) values(6,'EmployeeType',null)
insert into hrm.lookup(lookup_id,name,description) values(7,'EducationType',null)
insert into hrm.lookup(lookup_id,name,description) values(8,'DependentType',null)
insert into hrm.lookup(lookup_id,name,description) values(9,'MeasureType',null)
insert into hrm.lookup(lookup_id,name,description) values(10,'MeasureType',null)
insert into hrm.lookup(lookup_id,name,description) values(11,'LeaveType',null)
insert into hrm.lookup(lookup_id,name,description) values(12,'EmployeeStatus',null)
insert into hrm.lookup(lookup_id,name,description) values(13,'Country',null)
insert into hrm.lookup(lookup_id,name,description) values(14,'MaritalStatus',null)
insert into hrm.lookup(lookup_id,name,description) values(15,'JobGrade',null)
insert into hrm.lookup(lookup_id,name,description) values(16,'BenefitType',null)
insert into hrm.lookup(lookup_id,name,description) values(17,'Country',null)
insert into hrm.lookup(lookup_id,name,description) values(18,'TerminationReasons',null)