--use [master]
--go

--create database [PRN_PRJ]
--go

use [PRN_PRJ]
go

create table [Users](
	[ID] [int] identity(1,1) not null,
	[Username] [nvarchar](40) not null,
	[Password] [nvarchar](40) not null, 
	[FullName] [nvarchar](40) not null,
	[Phone] [varchar](10) not null,
	[Role] [bit] not null,
	constraint PK_USERS primary key ([ID] asc) 
)
go

create table [Genre](
	[ID] [int] identity(1,1) not null,
	[Name] [nvarchar](40) not null,
	constraint PK_GENRE primary key ([ID] asc) 
)
go

create table [Movies](
	[ID] [int] identity(1,1) not null,
	[Title] [nvarchar](40) not null,
	[Description] [nvarchar](80) not null,
	[Duration] [time] not null,
	[GenreID] [int] not null,
	constraint PK_MOVIES primary key ([ID] asc) 
)
go

create table [Showtime](
	[ID] [int] identity(1,1) not null,
	[StartTime] [timestamp] not null,
	[EndTime] [timestamp] not null,
	constraint PK_SHOWTIME primary key ([ID] asc) 
)
go

create table [Theaters](
	[ID] [int] identity(1,1) not null,
	[Name] [nvarchar](40) not null,
	[Email] [nvarchar](40) not null,
	[Address] [nvarchar](40) not null,
	[Phone] [nvarchar](40) not null,
	constraint PK_THEATERS primary key ([ID] asc) 
)
go

create table [Rooms](
	[ID] [int] identity(1,1) not null,
	[RoomNumber] [int] not null,
	[NumberOfSeat] [int] not null,
	[TheaterID] [int] not null,
	constraint PK_ROOMS primary key ([ID] asc) 
)
go

create table [Tickets](
	[ID] [int] identity(1,1) not null,
	[Status] [bit] not null,
	[Price] [money] not null,
	[SeatID] [int] not null,
	[BuyTime] [timestamp] not null,
	[RoomID] [int] not null,
	[NovieID] [int] not null,
	[UserID] [int] not null,
	[ShowtimeID] [int] not null
)
go

--alter table [Tickets] add constraint [DF_Tickets]
--default (GETDATE()) for [BuyTime];
--go
--alter table [Rooms] add constraint []
--default ()