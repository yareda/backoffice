-- =============================================
-- Script Template
-- =============================================
delete fixedasset.lookup_item
go


delete fixedasset.[lookup]
go

insert into fixedasset.lookup(lookup_id,name,visible) values(1,'Depreciation Methods','False')
insert into fixedasset.lookup(lookup_id,name,visible) values(2,'Asset Group','True')
insert into fixedasset.lookup(lookup_id,name,visible) values(3,'Location','True')
insert into fixedasset.lookup(lookup_id,name,visible) values(4,'Cost Center','True')
insert into fixedasset.lookup(lookup_id,name,visible) values(5,'Asset Category','False')
insert into fixedasset.lookup(lookup_id,name,visible) values(6,'Adjustment Types','True')
insert into fixedasset.lookup(lookup_id,name,visible) values(7,'Custody Status','False')
insert into fixedasset.lookup(lookup_id,name,visible) values(8,'Department','True')
insert into fixedasset.lookup(lookup_id,name,visible) values(9,'Disposal Type','False')
insert into fixedasset.lookup(lookup_id,name,visible) values(10,'Fiscal Period Status','False')
insert into fixedasset.lookup(lookup_id,name,visible) values(11,'Physical Condition','True')
insert into fixedasset.lookup(lookup_id,name,visible) values(12,'Custody Assignment Status','False')
insert into fixedasset.lookup(lookup_id,name,visible) values(13,'AssetStatus','False')
insert into fixedasset.lookup(lookup_id,name,visible) values(14,'AdjustementStatus','False')
insert into fixedasset.lookup(lookup_id,name,visible) values(15,'Vendors','True')

-- Depreciation Methods
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(1,1,'Straight Line','')
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(2,1,'Declining Balance','')
--Custody Status
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(4,7,'Active','A')
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(5,7,'Inactive','R')
--Department
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(6,8,'Finance','FIN')
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(7,8,'Human Resource','HRM')
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(8,8,'Work Shop','WS')
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(9,8,'General Service','GS')
--Custody Assignment Status
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(10,12,'Assigned','A')
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(11,12,'Returned','R')
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(12,12,'Transfered','T')
-- Adjustement Status
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(22,14,'Pending','')
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(23,14,'Posted','')
---Asset Status
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(16,13,'Active','')
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(17,13,'Disposed','')

-- Disposal Type
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(24,9,'Distroyed','')
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(25,9,'Sold','')
--Asset Group
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(26,2,'Material','')
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(27,2,'Management','')
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(28,2,'Financial','')
--Cost Center
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(29,4,'Material Resource','')
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(30,4,'Management Resorce','')
insert into fixedasset.lookup_item(lookup_item_id,lookup_id,item_name,description) values(31,4,'Financial Management','')
--Vendors

--
