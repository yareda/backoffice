-- =============================================
-- Script Template
-- =============================================

delete fleet.lookup_item
go


delete fleet.[lookup]
go

-- Reset identity column
dbcc checkident('fleet.lookup_item',RESEED,0)
go

insert into fleet.lookup(lookup_id,lookup_name) values(1,'Body Color Type')
insert into fleet.lookup(lookup_id,lookup_name) values(2,'Fuel Type')
insert into fleet.lookup(lookup_id,lookup_name) values(3,'Maintenance Activity Type')
insert into fleet.lookup(lookup_id,lookup_name) values(4,'Payment Type')
insert into fleet.lookup(lookup_id,lookup_name) values(5,'Service Type')
insert into fleet.lookup(lookup_id,lookup_name) values(6,'Vehicle Type')
insert into fleet.lookup(lookup_id,lookup_name) values(7,'Vehicle Make')
insert into fleet.lookup(lookup_id,lookup_name) values(8,'Vehicle Ownership')
insert into fleet.lookup(lookup_id,lookup_name) values(9,'Tire Type')
insert into fleet.lookup(lookup_id,lookup_name) values(10,'Fuel Stations')
insert into fleet.lookup(lookup_id,lookup_name) values(11,'Insurance Policty Type')
insert into fleet.lookup(lookup_id,lookup_name) values(12,'Insurance Company')

go

-- Vehicle Type
insert into fleet.lookup_item(lookup_id,item_name) values(6,'Automobile')
insert into fleet.lookup_item(lookup_id,item_name) values(6,'Pickup')
insert into fleet.lookup_item(lookup_id,item_name) values(6,'4x4')
insert into fleet.lookup_item(lookup_id,item_name) values(6,'Bus')
insert into fleet.lookup_item(lookup_id,item_name) values(6,'Truck')

-- Vehicle Make
insert into fleet.lookup_item(lookup_id,item_name) values(7,'Toyota')
insert into fleet.lookup_item(lookup_id,item_name) values(7,'Holland Car')
insert into fleet.lookup_item(lookup_id,item_name) values(7,'JAC')
insert into fleet.lookup_item(lookup_id,item_name) values(7,'Lifan')

-- Vehicle Ownership
insert into fleet.lookup_item(lookup_id,item_name) values(8,'Purchased')
insert into fleet.lookup_item(lookup_id,item_name) values(8,'Rented/Leased')

-- Fuel Types
insert into fleet.lookup_item(lookup_id,item_name) values(2,'Petrol')
insert into fleet.lookup_item(lookup_id,item_name) values(2,'Disele')

-- Insurance Policy Type
insert into fleet.lookup_item(lookup_id,item_name) values(11,'Comprehensive')
insert into fleet.lookup_item(lookup_id,item_name) values(11,'Third Party')

-- Payment Type
insert into fleet.lookup_item(lookup_id,item_name) values(4,'Parking')
insert into fleet.lookup_item(lookup_id,item_name) values(4,'Car Wash and Lube')
insert into fleet.lookup_item(lookup_id,item_name) values(4,'Traffic Fine')
insert into fleet.lookup_item(lookup_id,item_name) values(4,'Lubricant')
insert into fleet.lookup_item(lookup_id,item_name) values(4,'Annual Inspection')
insert into fleet.lookup_item(lookup_id,item_name) values(4,'Other')

-- Insurance Company
insert into fleet.lookup_item(lookup_id,item_name) values(12,'Awash Insurance Company')
insert into fleet.lookup_item(lookup_id,item_name) values(12,'Lion Insurance Company')
insert into fleet.lookup_item(lookup_id,item_name) values(12,'UNITED Insurance Company')
insert into fleet.lookup_item(lookup_id,item_name) values(12,'Ethiopian Insurance Corporation')
insert into fleet.lookup_item(lookup_id,item_name) values(12,'NIB Insurance')
insert into fleet.lookup_item(lookup_id,item_name) values(12,'Nyala Insurance Company')
insert into fleet.lookup_item(lookup_id,item_name) values(12,'NICE Insurance')

-- Service Type
insert into fleet.lookup_item(lookup_id,item_name) values(5,'Emergency/Corrective Service')
insert into fleet.lookup_item(lookup_id,item_name) values(5,'Schedule On Site Service')
insert into fleet.lookup_item(lookup_id,item_name) values(5,'Engine Overhaul')

-- Maintenance Activity Types
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check handbrake for operation and travel')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check operation of exterior lights')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check horn')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check seatbelts')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check ABS warning lights for correct operation')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check heater plug indicator (Diesel)')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check for correct clutch operation')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Top up battery if applicable and check security')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check and top up brake and clutch fluid')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check windscreen wipers')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check windscreen washer operations and top up')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check / top-up power steering reservoir where applicable')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check coolant and antifreeze strength and top up')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check condition and tension of fan / alternator belt. Adjust if necessary')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check condition, tension and adjust as required auxiliary drive belts (excluding timing/cam belt)')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Replace oil filter')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Drain engine oil and refill (special or synthetic oils subject to additional charge)')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check and top up gearbox oil where applicable')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check and top up axle oil where applicable')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check and top up automatic transmission fluids where applicable')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check for general oil leaks')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check wheel bearings for play or noise')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check steering / suspension components for wear and corrosion')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check steering rack gaitors if applicable')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check shock absorbers for operation')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Remove front wheels and check discs / drums for wear, cracks, corrosion and scoring')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check brake pads for wear or damage')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check calipers for leaks and operation')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Remove rear wheels and check drums / discs for wear, cracks, corrosion and scoring')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check brake shoes for wear or damage')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Inspect wheel cylinders for leaks and operation')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Visually check brake hydraulic system, pipes and hoses for leaks, chafing and corrosion')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check security of hand brake linkages, lubricate if applicable')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Adjust handbrake if required')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check propshaft / drive shaft and joints')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check drive shaft gaiters for security and leaks')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Inspect exhaust system for leaks security and noise')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check tyre condition, tread depth and record readings (including spare)')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check and adjust tyre pressures (including spare)')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check wheels for correct balance (including spare)')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Set wheel nut torque to manufacturer’s settings')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Reset vehicle service light where applicable')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Carry out battery test')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check condition of fuel lines')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Visual inspection of HT lead')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Visual inspection of distributor cap')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Visual inspection of rotor arm if applicable')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Replace Spark plugs if applicable (platinum, long life or multi electrode plugs subject to extra charge)')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Replace air filter element')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Replace diesel fuel filter')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check smoke emissions visually (Diesel)')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Lubricate throttle linkage if applicable')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check radiator for leaks')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check condition of radiator cap')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check coolant hoses for leaks and condition')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check expansion bottle and cap for leak')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check electric cooling fan for operation where applicable')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Test and report brake fluid boiling point (if applicable)')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Lubricate bonnet catch')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Lubricate accessible door / hinges if required')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Grease steering / suspension and propshaft if applicable')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check fuel cap condition')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check tyres for indications of steering misalignment')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check security of handbrake linkages and travel, lubricate and adjust if required')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check windscreen condition')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check mirror condition. Exterior')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check mirror condition. Interior')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check number plates')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check for timing / cam belt replacement (report if due)')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Check for cabin / pollen filter replacement (report if due)')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Replace brake fluid and bleed system')
insert into fleet.lookup_item(lookup_id,item_name) values(3,'Replace petrol fuel filter')

go

delete fleet.workflow_status

go

-- Workflow Status 
insert into fleet.workflow_status(status_id,status_name) values(1,'Open')
insert into fleet.workflow_status(status_id,status_name) values(2,'Completed')
insert into fleet.workflow_status(status_id,status_name) values(3,'Canceled')
