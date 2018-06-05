CREATE DATABASE Parking

create table TB_User
(
UserID int  not null identity,
UserName nvarchar(15),
UserPassword nvarchar(15),
UserRole nvarchar(25),
--Pic nvarchar (50),
constraint pk_UserID primary key (UserID)
)

create table Member_Detail
(
MID int  not null identity,
Licence nvarchar (20),
LicenceName nvarchar (20) not null,
BName nvarchar(50) ,
Model nvarchar(20),
Machine_Number nvarchar(20),
Color nvarchar(30),
Name nvarchar(20),
LName nvarchar(30),
CardID nvarchar (20),
Adress nvarchar(30),
Tel nvarchar(20),
Email nvarchar(20),
constraint pk_MID primary key (MID)

)
create table Genral_Client
(
GID bigint not null identity,
--P_ID char(5) not null,
Licence nvarchar (20),
LicenName nvarchar (20),
GDate date ,
Gtime time,
Price nvarchar (20),
constraint Pk primary key (GID),
--constraint fk_Packageid foreign key (P_ID) references Package,

)
create table Package
(
P_ID char(5) not null,
P_Name nvarchar (50),
P_Detail nvarchar(150),
P_Price nvarchar(15)
constraint FK_P_ID primary key (P_ID)
)

create table Sell_BillMember
(
S_ID bigint not null identity,
MID int  not null ,
P_ID char(5) not null,
S_Date date,
S_Time time,
constraint pk_SID primary key (S_ID),
constraint fk_MID foreign key(MID) references Member_Detail,
constraint fk_PID foreign key (P_ID) references Package,
)
alter table TB_User alter column UserID int not null identity;
drop table TB_User

