-- =============================================
-- Script Template
-- =============================================

-- Stock status table
delete stock.lookup_item
go


delete stock.[lookup]
go

-- Reset identity column
dbcc checkident('stock.lookup_item',RESEED,0)
go

delete stock.transaction_status
go

insert into stock.transaction_status(status_id,name) values(0,'Pending')
insert into stock.transaction_status(status_id,name) values(1,'Approved')
insert into stock.transaction_status(status_id,name) values(2,'Rejected')
insert into stock.transaction_status(status_id,name) values(3,'Posted')
insert into stock.transaction_status(status_id,name) values(4,'Closed')
insert into stock.transaction_status(status_id,name) values(5,'Unknown')

delete stock.transaction_type
go

-- Transaction Type
insert into stock.transaction_type(transaction_type_id,name)values(1,'Receiving')
insert into stock.transaction_type(transaction_type_id,name)values(2,'Issue')
insert into stock.transaction_type(transaction_type_id,name)values(3,'Return')
insert into stock.transaction_type(transaction_type_id,name)values(4,'Transfer')
insert into stock.transaction_type(transaction_type_id,name)values(5,'Adjustment')
insert into stock.transaction_type(transaction_type_id,name)values(6,'Opening Balance')

delete stock.sequence_counter
go
-- sequence conunter table
insert into stock.sequence_counter(record_id,grn,issue_no,transfer_no,return_no,adjustment_no)
values(1,'GRN-000001','GIN-000001','TRN-000001','SRN-000001','AJN-000001')


insert into stock.Lo(lookup_id,lookup_name) values(1,'Warehouse')
insert into stock.lookup(lookup_id,lookup_name) values(2,'Supplier')
insert into stock.lookup(lookup_id,lookup_name) values(3,'MeasurmentUnit')

insert into stock.lookup_item(lookup_id,item_name) values(1,'Warehouseone')
insert into stock.lookup_item(lookup_id,item_name) values(1,'Warehousetwo')
insert into stock.lookup_item(lookup_id,item_name) values(1,'Warehousethree')

insert into stock.lookup_item(lookup_id,item_name) values(2,'EBG')
insert into stock.lookup_item(lookup_id,item_name) values(2,'SIGMA')
insert into stock.lookup_item(lookup_id,item_name) values(2,'MOENCO')

insert into stock.lookup_item(lookup_id,item_name) values(3,'Meter')
insert into stock.lookup_item(lookup_id,item_name) values(1,'Kilo gram')
insert into stock.lookup_item(lookup_id,item_name) values(1,'Ton')