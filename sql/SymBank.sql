CREATE DATABASE SymBank
GO

USE SymBank
GO

CREATE TABLE Accounts (
	ID INT NOT NULL,
	Name NVARCHAR(30) NOT NULL,
	Balance MONEY NOT NULL)
GO

ALTER TABLE Accounts
	ADD CONSTRAINT PK_Accounts
	PRIMARY KEY (ID)
GO

ALTER TABLE Accounts
	ADD CONSTRAINT CK_Accounts_Name
	CHECK (LEN(Name) > 0)
GO

ALTER TABLE Accounts
	ADD CONSTRAINT CK_Accounts_Balance
	CHECK (Balance >= 0)
GO


CREATE PROCEDURE Transfer(@Source INT, @Target INT, @Amount MONEY) AS
	IF @Source = @Target BEGIN -- cannot transfer to same account
		RAISERROR('Cannot transfer to same account!',16,1)
		RETURN -1
	END
	IF @Amount <= 0 BEGIN -- amount cannot be less than 0
		RAISERROR('Invalid transfer amount!',16,1)
		RETURN -2
	END
	BEGIN TRANSACTION
	UPDATE Accounts SET Balance=Balance-@Amount WHERE ID = @Source
	IF @@ROWCOUNT = 0 BEGIN
		ROLLBACK TRANSACTION
		RAISERROR('Invalid source account!',16,1)
		RETURN -3
	END
	UPDATE Accounts SET Balance=Balance+@AMOUNT WHERE ID = @Target
	IF @@ROWCOUNT = 0 BEGIN
		ROLLBACK TRANSACTION
		RAISERROR('Invalid target account!',16,1)
		RETURN -4
	END
	COMMIT TRANSACTION