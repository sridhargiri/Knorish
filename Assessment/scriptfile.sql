create database BoatDtabase
go
Create table BoatDetails
(
BoatId int primary key identity(1,1),
BoatName varchar(50),
HourlyRate INT NOT NULL
)
go
Create table BoatCustomerRent
(
BoatId int primary key FOREIGN KEY REFERENCES BoatDetails(BoatID),
CustomerName varchar(50),
IsRented BIT not null default(0)
)
go
select * from BoatDetails
select * from BoatCustomerRent
--Update BoatDetails set BoatName='Boat1' where boatid=1