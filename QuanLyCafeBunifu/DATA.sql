create database QuanLyCafe
go

use QuanLyCafe
go 

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill 
-- Billinfo

create table TableFood
(
	id int identity primary key,
	name nvarchar(100) NOT NULL default N'Bàn chưa có tên',
	status nvarchar(100) NOT NULL default N'Trống'   -- Trống || Có người
) 
go

create table Account
(
	
	
	UserName nvarchar(100) primary key,
	DisplayName nvarchar(100) NOT NULL default N'Duy đẹp trai',
	PassWord nvarchar(1000) NOT NULL default 0,
	Type int NOT NULL default 0 --1: admin && 0:staff
)
go	

CREATE TABLE FoodCategory
(
	id int identity primary key,
	name nvarchar(100) NOT NULL default N'Chưa đặt tên'
)
go

create table Food
(
	id int identity primary key,
	name nvarchar(100) Not Null default N'Chưa đặt tên',
	idCategory int Not Null,
	price float NOT NULL default 0

	foreign key (idCategory) references dbo.FoodCategory(id)
)
go

drop table Bill

create table Bill
(
	id int identity primary key,
	DateCheckIn date NOT NULL default getdate(),
	DateCheckOut date ,
	idTable int NOT NULL,
	status int NOT NULL default 0 -- 1: đã thanh toán && 0: chưa thanh toán

	foreign key (idTable) references dbo.TableFood(id)
)
go



create table BillInfo
(
		id int identity primary key,
		idBill int not null,
		idFood int not null,
		count int not null  default 0

		foreign key (idBill) references dbo.Bill(id),
		foreign key (idFood) references dbo.Food(id)
)
go

insert into dbo.Account
		(UserName,
		DisplayName,
		PassWord,
		Type
		)
values ( N'K9111', -- UserName - nvachar(100)
		N'RongK9', -- DisplayName - nvarchar(100)
		N'1', --PassWord - nvarchar(1000)
		1  -- Type - int
		)

go

insert into dbo.Account
		(UserName,
		DisplayName,
		PassWord,
		Type
		)
values ( N'Staff111', -- UserName - nvachar(100)
		N'Staff', -- DisplayName - nvarchar(100)
		N'1', --PassWord - nvarchar(1000)
		0  -- Type - int
		)
go


create proc USP_GetAccountByUserName
@userName nvarchar(100)
as
begin
	select * from dbo.Account where UserName = @userName
end
go

EXEC dbo.USP_GetAccountByUserName @userName = N'K9' --nvachar(100)
--select * from dbo.Account
--go


select * from dbo.Account where UserName = N'K9' and PassWord = N'1'

create proc USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
as
begin
	select * from dbo.Account where UserName = @userName and PassWord = @passWord
end
go

declare @i int = 0

while  @i <= 10
begin
	insert dbo.TableFood ( name ) values ( N'Bàn ' + CAST(@i as nvarchar(100)) )
	set @i = @i + 1
end

insert  dbo.TableFood(name, status) values ( N'Bàn 1', N'trống')

select * from dbo.TableFood

create proc USP_GetTableList
as select * from dbo.TableFood
go

exec dbo.USP_GetTableList

update dbo.TableFood set status = N'Có người' where id = 9

--thêm category
insert FoodCategory (name) values (N'Hải sản') 
insert FoodCategory (name) values (N'Nông sản') 
insert FoodCategory (name) values (N'Lâm sản') 
insert FoodCategory (name) values (N'Nước') 

--Thêm món ăn
insert Food (name, idCategory, price) values (N'Mực 1 nắng',1,120000)
insert Food (name, idCategory, price) values (N'Nghêu hấp xả',1,50000)
insert Food (name, idCategory, price) values (N'Dê nướng',2,120000)
insert Food (name, idCategory, price) values (N'Heo rừng nướng',3,120000)
insert Food (name, idCategory, price) values (N'Nước cam',4,15000)

--Thêm Bill
insert Bill (DateCheckIn,DateCheckOut,idTable,status) values (GETDATE(),null,3,0)
insert Bill (DateCheckIn,DateCheckOut,idTable,status) values (GETDATE(),null,4,0)
insert Bill (DateCheckIn,DateCheckOut,idTable,status) values (GETDATE(),GETDATE(),5,1)

--delete from Bill where (idTable <10)

--Thêm Bill info
insert BillInfo (idBill,idFood,count) values (10,1,2)
insert BillInfo (idBill,idFood,count) values (11,3,4)
insert BillInfo (idBill,idFood,count) values (12,5,1)
insert BillInfo (idBill,idFood,count) values (10,1,2)
insert BillInfo (idBill,idFood,count) values (11,6,2)
insert BillInfo (idBill,idFood,count) values (12,5,2)

insert BillInfo (count) values (2)

go
delete from BillInfo

select f.name, bi.count ,f.price, f.price*bi.count as totalPrice from dbo.BillInfo as bi, dbo.Bill as b, dbo.Food  as f where bi.idBill = b.id and bi.idFood = f.id and b.status = 0  and b.idTable = 5

select * from Bill
select * from BillInfo
select * from TableFood
select * from Food

select * from FoodCategory

create proc USP_InsertBill
@idTable int
as
begin
insert Bill (DateCheckIn,DateCheckOut,idTable,status) values (GETDATE(), null,@idTable,0)
end
go

alter proc USP_InsertBillInfo
@idBill int , @idFood int , @count int
as
begin

	declare @isExitsBillInfo int
	declare @foodCount int = 1

	select @isExitsBillInfo = id, @foodCount = b.count  
	from BillInfo as b  where idBill = @idBill and	idFood = @idFood	

	if ( @isExitsBillInfo > 0)
	begin
		declare @newCount int = @foodCount + @count
		if( @newCount > 0)
			update BillInfo set count = @foodCount + @count where idFood=@idFood
		else
			delete BillInfo where idBill=@idBill and idFood = @idFood
	end
	else
	begin
	insert BillInfo (idBill,idFood,count) values (@idBill,@idFood,@count)
	end
end
go
	




insert BillInfo (idBill,idFood,count) values (@idBill,@idFood,@count)
end
go

select max(id) from Bill

