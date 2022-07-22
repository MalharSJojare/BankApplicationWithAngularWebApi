Create database "AngularBank"
use AngularBank
Create table TblBank(
	BankId int identity primary key,
	Name varchar(10) not null,
	Area varchar(30), 
	City varchar(30),
	State varchar(30),
	ZipCode varchar(6),
	CreatedDate datetime,
	ModifiedDate datetime
);
Create table TblUser(
	UserId int identity primary key,
	FirstName varchar(10) not null,
	LastName varchar(10) not null,
	Area varchar(30), 
	City varchar(30),
	State varchar(30),
	ZipCode varchar(6),
	CreatedDate datetime,
	ModifiedDate datetime
);
select * from TblBank
Create table TblAccount(
	AccountId int identity primary key,
	UserId int not null,
	BankId int not null,
	Balance int not null,
	CreatedDate datetime,
	ModifiedDate datetime,
	foreign key(UserId) references TblUser(UserId),
	foreign key(BankId) references TblBank(BankId)
);
Create table TblAdmin(
	AdminId int identity primary key,
	BankId int not null,
 	Name varchar(10) not null,
	Area varchar(30), 
	City varchar(30),
	State varchar(30),
	ZipCode varchar(6),
	CreatedDate datetime,
	ModifiedDate datetime,
	foreign key(BankId) references TblBank(BankId)
);
Create table TblTransaction(
	TransactionId int identity primary key,
	BankId int not null,
	AccountId int not null,
	DepositAmt int not null,
	WithdrawAmt int not null,
	CreatedDate datetime,
	ModifiedDate datetime,
	foreign key(BankId) references TblBank(BankId),
	foreign key(AccountId) references TblAccount(AccountId)
);

