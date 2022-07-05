use master
go

drop database if exists DB_TarotReader;
go

create database DB_TarotReader;
go

use DB_TarotReader;
go

Begin Transaction
create table Card(
	id int identity(1,1),
	name nvarchar (250) NOT NULL,
	arcana nvarchar(20) NOT Null,

	Constraint [UQ_name] unique ([name]),
	Constraint[PK_card_id] primary key ([id])
	);
GO

create table Spread(
	id int identity(1,1),
	name nvarchar (100) NOT NULL,
	card_amount int,

	Constraint[PK_spread_id] primary key([id])
	);
GO

create table card_spread(
	spread_id int,
	card_id int,
	deck_id int NOT NULL,
	card_placement int,

	Constraint[PK_card_spread] primary key ([spread_id], [card_id]),
	
	Constraint[FK_spread_id] foreign key ([spread_id]) references Spread([id]),
	Constraint[FK_card_id] foreign key ([card_id]) references Card([id])
	
	);
Go

Insert into Card( name, arcana)
Values('The Fool', 'Major');

Insert into Card( name, arcana)
Values('The Magician', 'Major');

Insert into Card( name, arcana)
Values('The High Priestess','Major');

Insert into Card( name, arcana)
Values('The Empress','Major');

Insert into Card( name, arcana)
Values('The Emperor','Major');

Insert into Card(name, arcana)
Values('The Hierophant','Major');

Insert into Card(name, arcana)
Values('The Lovers','Major');

Insert into Card(name, arcana)
Values('The Chariot','Major');

Insert into Card(name, arcana)
Values('Strength','Major');

Insert into Card(name, arcana)
Values('The Hermit','Major');

Insert into Card(name, arcana)
Values('Wheel Of Fortune','Major');

Insert into Card(name, arcana)
Values('Justice','Major');

Insert into Card(name, arcana)
Values('The Hanged Man','Major');

Insert into Card(name, arcana)
Values('Death','Major');

Insert into Card(name, arcana)
Values('Temperance','Major');

Insert into Card(name, arcana)
Values('The Devil','Major');

Insert into Card(name, arcana)
Values('The Tower','Major');

Insert into Card(name, arcana)
Values('The Star','Major');

Insert into Card(name, arcana)
Values('The Moon','Major');

Insert into Card(name, arcana)
Values('The Sun','Major');

Insert into Card(name, arcana)
Values('Judgement','Major');

Insert into Card(name, arcana)
Values('The World','Major');
------------------------------------------------------------------------
------------------------------------------------------------------------

Insert into Card(name, arcana)
Values('Ace Of Cups','Minor');

Insert into Card(name, arcana)
Values('Two Of Cups','Minor');

Insert into Card(name, arcana)
Values('Three Of Cups','Minor');

Insert into Card(name, arcana)
Values('Four Of Cups','Minor');

Insert into Card(name, arcana)
Values('Five Of Cups','Minor');

Insert into Card(name, arcana)
Values('Six Of Cups','Minor');

Insert into Card(name, arcana)
Values('Seven Of Cups','Minor');

Insert into Card(name, arcana)
Values('Eight Of Cups','Minor');

Insert into Card(name, arcana)
Values('Nine Of Cups','Minor');

Insert into Card(name, arcana)
Values('Ten Of Cups','Minor');

Insert into Card(name, arcana)
Values('Page Of Cups','Minor');

Insert into Card(name, arcana)
Values('Knight Of Cups','Minor');

Insert into Card(name, arcana)
Values('Queen Of Cups','Minor');

Insert into Card(name, arcana)
Values('King Of Cups','Minor');
-------------------------------------------------------
Insert into Card(name, arcana)
Values('Ace Of Swords','Minor');

Insert into Card(name, arcana)
Values('Two Of Swords','Minor');

Insert into Card(name, arcana)
Values('Three Of Swords','Minor');

Insert into Card(name, arcana)
Values('Four Of Swords','Minor');

Insert into Card(name, arcana)
Values('Five Of Swords','Minor');

Insert into Card(name, arcana)
Values('Six Of Swords','Minor');

Insert into Card(name, arcana)
Values('Seven Of Swords','Minor');

Insert into Card(name, arcana)
Values('Eight Of Swords','Minor');

Insert into Card(name, arcana)
Values('Nine Of Swords','Minor');

Insert into Card(name, arcana)
Values('Ten Of Swords','Minor');

Insert into Card(name, arcana)
Values('Page Of Swords','Minor');

Insert into Card(name, arcana)
Values('Knight Of Swords','Minor');

Insert into Card(name, arcana)
Values('Queen Of Swords','Minor');

Insert into Card(name, arcana)
Values('King Of Swords','Minor');
----------------------------------------------------------

Insert into Card(name, arcana)
Values('Ace Of Pentacles','Minor');

Insert into Card(name, arcana)
Values('Two Of Pentacles','Minor');

Insert into Card(name, arcana)
Values('Three Of Pentacles','Minor');

Insert into Card(name, arcana)
Values('Four Of Pentacles','Minor');

Insert into Card(name, arcana)
Values('Five Of Pentacles','Minor');

Insert into Card(name, arcana)
Values('Six Of Pentacles','Minor');

Insert into Card(name, arcana)
Values('Seven Of Pentacles','Minor');

Insert into Card(name, arcana)
Values('Eight Of Pentacles','Minor');

Insert into Card(name, arcana)
Values('Nine Of Pentacles','Minor');

Insert into Card(name, arcana)
Values('Ten Of Pentacles','Minor');

Insert into Card(name, arcana)
Values('Page Of Pentacles','Minor');

Insert into Card(name, arcana)
Values('Knight Of Pentacles','Minor');

Insert into Card(name, arcana)
Values('Queen Of Pentacles','Minor');

Insert into Card(name, arcana)
Values('King Of Pentacles','Minor');
-----------------------------------------------------------------------
Insert into Card(name, arcana)
Values('Ace Of Wands','Minor');

Insert into Card(name, arcana)
Values('Two Of Wands','Minor');

Insert into Card(name, arcana)
Values('Three Of Wands','Minor');

Insert into Card(name, arcana)
Values('Four Of Wands','Minor');

Insert into Card(name, arcana)
Values('Five Of Wands','Minor');

Insert into Card(name, arcana)
Values('Six Of Wands','Minor');

Insert into Card(name, arcana)
Values('Seven Of Wands','Minor');

Insert into Card(name, arcana)
Values('Eight Of Wands','Minor');

Insert into Card(name, arcana)
Values('Nine Of Wands','Minor');

Insert into Card(name, arcana)
Values('Ten Of Wands','Minor');

Insert into Card(name, arcana)
Values('Page Of Wands','Minor');

Insert into Card(name, arcana)
Values('Knight Of Wands','Minor');

Insert into Card(name, arcana)
Values('Queen Of Wands','Minor');

Insert into Card(name, arcana)
Values('King Of Wands','Minor');

GO

Insert into Spread(name, card_amount)
Values('Three Card Spread', 3);

GO




Commit Transaction