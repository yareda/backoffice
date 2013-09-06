/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
delete wms.lookup_item
go

delete wms.lookup

go

/*Add Wms Looup categories*/
insert into wms.lookup(lookup_id,name,description) values(1,'CustomerType',null)
insert into wms.lookup(lookup_id,name,description) values(2,'ContractType',null)
insert into wms.lookup(lookup_id,name,description) values(3,'EquipmentCategory',null)
insert into wms.lookup(lookup_id,name,description) values(4,'EquipmentStatus',null)
insert into wms.lookup(lookup_id,name,description) values(5,'Company',null)
insert into wms.lookup(lookup_id,name,description) values(6,'Make',null)
insert into wms.lookup(lookup_id,name,description) values(7,'Model',null)
insert into wms.lookup(lookup_id,name,description) values(8,'InsuranceCompany',null)
insert into wms.lookup(lookup_id,name,description) values(9,'Schedule',null)
insert into wms.lookup(lookup_id,name,description) values(10,'ExpirationType',null)
insert into wms.lookup(lookup_id,name,description) values(11,'WorkorderStatus',null)
insert into wms.lookup(lookup_id,name,description) values(12,'WorkorderPriority',null)
insert into wms.lookup(lookup_id,name,description) values(13,'Services',null)
insert into wms.lookup(lookup_id,name,description) values(14,'PmServiceType',null)
insert into wms.lookup(lookup_id,name,description) values(15,'Payment Terms',null)
insert into wms.lookup(lookup_id,name,description) values(16,'VendorType',null)
insert into wms.lookup(lookup_id,name,description) values(20,'PaymentMethod',null)
insert into wms.lookup(lookup_id,name,description) values(21,'InvoiceStatus',null)

-- Customer Type
insert into wms.lookup_item(item_id,lookup_id,name,code,[description]) values(1,1,'Governement','GOV','')
insert into wms.lookup_item(item_id,lookup_id,name,code,[description]) values(2,1,'NGO','NGO','')
insert into wms.lookup_item(item_id,lookup_id,name,code,[description]) values(3,1,'Private Company','PVT','')
insert into wms.lookup_item(item_id,lookup_id,name,code,[description]) values(4,1,'Other','OTH','')

-- Payment Method
insert into wms.lookup_item(item_id,lookup_id,name,code,[description]) values(5,20,'Cash','CASH','')
insert into wms.lookup_item(item_id,lookup_id,name,code,[description]) values(6,20,'Cheque','CHQE','')
insert into wms.lookup_item(item_id,lookup_id,name,code,[description]) values(7,20,'Bank Transfer','BANK','')
insert into wms.lookup_item(item_id,lookup_id,name,code,[description]) values(8,20,'Other','OTHER','')

-- Model
insert into wms.lookup_item(item_id,lookup_id,name,code,[description]) values(9,7,'Generator','','')
insert into wms.lookup_item(item_id,lookup_id,name,code,[description]) values(10,7,'Air Conditioner','','')
insert into wms.lookup_item(item_id,lookup_id,name,code,[description]) values(11,7,'Compressor','','')
insert into wms.lookup_item(item_id,lookup_id,name,code,[description]) values(12,7,'Air Conditioner','','')

--Invoice Status
insert into wms.lookup_item(item_id,lookup_id,name,code,[description]) values(13,21,'Out Standing','','')
insert into wms.lookup_item(item_id,lookup_id,name,code,[description]) values(14,21,'Paid In Full','','')

