CREATE DATABASE QuanLyCafe
GO
USE QuanLyCafe
GO
CREATE TABLE TableFood
(
	id INT PRIMARY KEY DEFAULT 0,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- Trống || Có người
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Kter',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO

CREATE TABLE FoodCategory
(
	id INT PRIMARY KEY DEFAULT 0,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT PRIMARY KEY DEFAULT 0,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0,
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT PRIMARY KEY DEFAULT 0,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0, -- 1: đã thanh toán && 0: chưa thanh toán
	discount INT DEFAULT 0 ,
	totalPrice FLOAT ,
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)

GO

CREATE TABLE BillInfo
(
	id INT PRIMARY KEY DEFAULT 0,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO

INSERT INTO dbo.Account
        ( UserName ,
          DisplayName ,
          PassWord ,
          Type
        )
VALUES  ( N'WayciQ' , -- UserName - nvarchar(100)
          N'WAYCI' , -- DisplayName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(1000)
          1  -- Type - int
        )
INSERT INTO dbo.Account
        ( UserName ,
          DisplayName ,
          PassWord ,
          Type
        )
VALUES  ( N'staff1' , -- UserName - nvarchar(100)
          N'staff1' , -- DisplayName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(1000)
          0  -- Type - int
        )
GO

CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO

CREATE TRIGGER TRIG_ID_FOOD ON Food
FOR INSERT
AS 
BEGIN
    DECLARE @PRE_ID int, @CUR_ID int
	SELECT @CUR_ID=id FROM INSERTED
	IF(SELECT COUNT(id) FROM dbo.Food)=0
		BEGIN
			UPDATE dbo.Food
			SET id=1
			WHERE id=@CUR_ID
		END
	ELSE
		BEGIN
			SELECT @PRE_ID = MAX(id) FROM dbo.Food
			SET @PRE_ID = @PRE_ID + 1
			UPDATE dbo.Food
			SET id =@PRE_ID
			WHERE id=@CUR_ID
		END
END
GO

CREATE TRIGGER TRIG_ID_Bill ON Bill
FOR INSERT
AS 
BEGIN
    DECLARE @PRE_ID int, @CUR_ID int
	SELECT @CUR_ID=id FROM INSERTED
	IF(SELECT COUNT(id) FROM dbo.Bill)=0
		BEGIN
			UPDATE dbo.Bill
			SET id=1
			WHERE id=@CUR_ID
		END
	ELSE
		BEGIN
			SELECT @PRE_ID = MAX(id) FROM dbo.Bill
			SET @PRE_ID = @PRE_ID + 1
			UPDATE dbo.Bill
			SET id =@PRE_ID
			WHERE id=@CUR_ID
		END
END
GO

CREATE TRIGGER TRIG_ID_BillInfo ON BillInfo
FOR INSERT
AS 
BEGIN
    DECLARE @PRE_ID int, @CUR_ID int
	SELECT @CUR_ID=id FROM INSERTED
	IF(SELECT COUNT(id) FROM dbo.BillInfo)=0
		BEGIN
			UPDATE dbo.BillInfo
			SET id=1
			WHERE id=@CUR_ID
		END
	ELSE
		BEGIN
			SELECT @PRE_ID = MAX(id) FROM dbo.BillInfo
			SET @PRE_ID = @PRE_ID + 1
			UPDATE dbo.BillInfo
			SET id =@PRE_ID
			WHERE id=@CUR_ID
		END
END
GO

CREATE TRIGGER TRIG_ID_CAGETORY ON FoodCategory
FOR INSERT
AS 
BEGIN
    DECLARE @PRE_ID int, @CUR_ID int
	SELECT @CUR_ID=id FROM INSERTED
	IF(SELECT COUNT(id) FROM dbo.FoodCategory)=0
		BEGIN
			UPDATE dbo.FoodCategory
			SET id=001
			WHERE id=@CUR_ID
		END
	ELSE
		BEGIN
			SELECT @PRE_ID = MAX(id) FROM dbo.FoodCategory
			SET @PRE_ID = @PRE_ID + 1
			UPDATE dbo.FoodCategory
			SET id =@PRE_ID
			WHERE id=@CUR_ID
		END
END
GO
CREATE TRIGGER TRIG_ID_Table ON TableFood
FOR INSERT
AS 
BEGIN
    DECLARE @PRE_ID int, @CUR_ID int
	SELECT @CUR_ID=id FROM INSERTED
	IF(SELECT COUNT(id) FROM dbo.TableFood)=0
		BEGIN
			UPDATE dbo.TableFood
			SET id=001
			WHERE id=@CUR_ID
		END
	ELSE
		BEGIN
			SELECT @PRE_ID = MAX(id) FROM dbo.TableFood
			SET @PRE_ID = @PRE_ID + 1
			UPDATE dbo.TableFood
			SET id =@PRE_ID
			WHERE id=@CUR_ID
		END
END
GO
create proc USP_GETBILL
@idBill int
as 
BEGIN
	select f.name as [ITEM], bf.count as [QTY], f.price as [PRICE], t.name as [TABLE], totalPrice as [SUBTOTAL], bf.id as [STTFood], b.id as[idBill], b.discount as [discount] from  Bill as b 
	inner join TableFood as t on b.idTable = t.id
	inner join BillInfo as bf on bf.idBill = b.id
	inner join Food as f on f.id = bf.idFood
	where b.id = @idBill
END
GO
CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood
GO

CREATE PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT dbo.Bill 
	        ( DateCheckIn ,
	          DateCheckOut ,
	          idTable ,
	          status,
	          discount
	        )
	VALUES  ( GETDATE() , -- DateCheckIn - date
	          NULL , -- DateCheckOut - date
	          @idTable , -- idTable - int
	          0,  -- status - int
	          0
	        )
END
GO

CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	
	SELECT @isExitsBillInfo = id, @foodCount = b.count 
	FROM dbo.BillInfo AS b 
	WHERE idBill = @idBill AND idFood = @idFood

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.BillInfo	SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT	dbo.BillInfo
        ( idBill, idFood, count )
		VALUES  ( @idBill, -- idBill - int
          @idFood, -- idFood - int
          @count  -- count - int
          )
	END
END
GO


CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = idBill FROM Inserted
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0	
	
	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill
	
	IF (@count > 0)
	BEGIN
	
		PRINT @idTable
		PRINT @idBill
		PRINT @count
		
		UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable		
		
	END		
	ELSE
	BEGIN
	PRINT @idTable
		PRINT @idBill
		PRINT @count
	UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable	
	end
	
END
GO


CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = id FROM Inserted	
	
	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0
	
	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

CREATE PROC USP_SwitchTable
@idTable1 INT, @idTable2 int
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	
	SELECT @idSeconrdBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idFirstBill IS NULL)
	BEGIN
		PRINT '0000001'
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable1 , -- idTable - int
		          0  -- status - int
		        )
		        
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
		
	END
	
	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idSeconrdBill IS NULL)
	BEGIN
		PRINT '0000002'
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable2 , -- idTable - int
		          0  -- status - int
		        )
		SELECT @idSeconrdBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
		
	END
	
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'

	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	UPDATE dbo.BillInfo SET idBill = @idSeconrdBill WHERE idBill = @idFirstBill
	
	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable
	
	IF (@isFirstTablEmty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable2
		
	IF (@isSecondTablEmty= 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1
END
GO
CREATE PROC USP_GetListBillByDate
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount AS [Giảm giá]
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END
GO

CREATE PROC USP_UpdateAccount
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE USERName = @userName AND PassWord = @password
	
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UserName = @userName
		END		
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
	end
END
GO
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
go


--insert values
insert FoodCategory(name) values(N'Cafe')
insert FoodCategory(name) values(N'Ice Blended')
insert FoodCategory(name) values(N'Non-Cafe')
insert FoodCategory(name) values(N'Enjoy Tea')
insert FoodCategory(name) values(N'Special Café')
insert FoodCategory(name) values(N'Fruit Tea')
insert FoodCategory(name) values(N'Other')

insert Food(name,idCategory,price) values(N'Café Đen',1,29000) 
insert Food(name,idCategory,price) values(N'Café sữa',1,32000)
insert Food(name,idCategory,price) values(N'Bạc xỉu',1,35000)
insert Food(name,idCategory,price) values(N'Espresso',1,32000)
insert Food(name,idCategory,price) values(N'Cappuccino',1,49000)

insert Food(name,idCategory,price) values(N'Cookies blueberry',2,55000)
insert Food(name,idCategory,price) values(N'Mocha Coffee',2,55000)
insert Food(name,idCategory,price) values(N'Matcha',2,55000)
insert Food(name,idCategory,price) values(N'Chocolate',2,55000)

insert Food(name,idCategory,price) values(N'Chocolate',3,49000)
insert Food(name,idCategory,price) values(N'Matcha latte',3,49000)

insert Food(name,idCategory,price) values(N'Laveder mint',4,69000)
insert Food(name,idCategory,price) values(N'Hibicus Tea',4,69000)

insert Food(name,idCategory,price) values(N'Café Trứng',5,59000)
insert Food(name,idCategory,price) values(N'Café nước cốt dừa',5,49000)
insert Food(name,idCategory,price) values(N'Café sữa váng dừa',5,39000)

insert Food(name,idCategory,price) values(N'Candy crush',6,49000)
insert Food(name,idCategory,price) values(N'Trà đào cam sả',6,49000)
insert Food(name,idCategory,price) values(N'Trà hoa hồng vải',6,49000)
insert Food(name,idCategory,price) values(N'Trà đậu biếc hạt chia',6,49000)
insert Food(name,idCategory,price) values(N'Trà gạo rang váng sữa',6,49000)
insert Food(name,idCategory,price) values(N'Trà hoa quế váng sữa',6,49000)

insert Food(name,idCategory,price) values(N'Ham & cheese sandwich',7,35000)
insert Food(name,idCategory,price) values(N'Bánh mì cá ngừ',7,49000)
insert Food(name,idCategory,price) values(N'Bánh mì xíu mại',7,49000)
-- thêm bàn
GO

DECLARE @i INT = 0

WHILE @i <= 10
BEGIN
	INSERT dbo.TableFood (name)VALUES  ( N'Bàn ' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END
GO

insert Bill(DateCheckIn, DateCheckOut, status, idTable,discount,totalPrice) values('2019-12-17 02:57:06.593','2019-12-17 03:57:06.593',1, 1, 0, 96000)
insert Bill(DateCheckIn, DateCheckOut, status, idTable,discount,totalPrice) values('2019-12-17 02:55:06.593','2019-12-17 04:57:06.593',1, 2, 0, 81000)
insert Bill(DateCheckIn, DateCheckOut, status, idTable,discount,totalPrice) values('2019-12-17 01:57:06.593','2019-12-17 03:57:06.593',1, 3, 0, 173000)
insert Bill(DateCheckIn, DateCheckOut, status, idTable,discount,totalPrice) values('2019-10-2 02:57:06.593','2019-10-17 03:57:06.593',1, 1, 0, 64000)
insert Bill(DateCheckIn, DateCheckOut, status, idTable,discount,totalPrice) values('2019-9-3 02:57:06.593','2019-9-17 03:57:06.593',1, 1, 0, 81000)
insert Bill(DateCheckIn, DateCheckOut, status, idTable,discount,totalPrice) values('2019-11-17 02:57:06.593','2019-11-17 03:57:06.593',1, 1, 0,87000)
insert Bill(DateCheckIn, DateCheckOut, status, idTable,discount,totalPrice) values('2019-11-17 02:57:06.593','2019-11-17 03:57:06.593',1, 1, 0, 81000)
insert Bill(DateCheckIn, DateCheckOut, status, idTable,discount,totalPrice) values('2019-10-17 02:57:06.593','2019-10-17 03:57:06.593',1, 1, 0, 110000)
insert Bill(DateCheckIn, DateCheckOut, status, idTable,discount,totalPrice) values('2019-12-16 02:57:06.593','2019-12-16 03:57:06.593',1, 1, 0, 196000)

insert BillInfo(idBill, idFood, count) values (1,2,1)
insert BillInfo(idBill, idFood, count) values (1,1,1)
insert BillInfo(idBill, idFood, count) values (1,3,1)
insert BillInfo(idBill, idFood, count) values (1,3,4)
insert BillInfo(idBill, idFood, count) values (2,2,1)
insert BillInfo(idBill, idFood, count) values (2,5,1)
insert BillInfo(idBill, idFood, count) values (3,12,1)
insert BillInfo(idBill, idFood, count) values (3,11,1)
insert BillInfo(idBill, idFood, count) values (3,7,1)
insert BillInfo(idBill, idFood, count) values (4,4,1)
insert BillInfo(idBill, idFood, count) values (4,2,1)
insert BillInfo(idBill, idFood, count) values (5,2,1)
insert BillInfo(idBill, idFood, count) values (5,22,1)
insert BillInfo(idBill, idFood, count) values (6,2,1)
insert BillInfo(idBill, idFood, count) values (6,6,1)
insert BillInfo(idBill, idFood, count) values (7,2,1)
insert BillInfo(idBill, idFood, count) values (7,24,1)
insert BillInfo(idBill, idFood, count) values (8,24,1)
insert BillInfo(idBill, idFood, count) values (8,1,1)
insert BillInfo(idBill, idFood, count) values (8,4,1)
insert BillInfo(idBill, idFood, count) values (9,24,4)
 