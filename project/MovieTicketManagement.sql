create database MovieTicketManagement

create table movieCategory(
catID int primary key not null,
catName nvarchar(50) not null)

create table movie(
movieId int primary key not null,
movieName nvarchar(50) not null,
movieLength int not null,
movieOpeningDay date not null,
catID int not null,
foreign key (catID) references movieCategory(catID),
status bit not null)

drop table movie

create table movieDetail(
movieDetailId int primary key not null,
movieId int not null,
foreign key (movieId) references movie(movieId),
releasedYear int not null,
country nvarchar(50) not null,
directorName nvarchar(50) not null,
imagePoster image not null,
limitAge int not null,
movieDescription nvarchar(500),
)

create table memberAccount(
memAccId int primary key not null,
memUserName varchar(50) not null,
password varchar(50) not null,
memName nvarchar(50) not null,
birthday date not null,
phone varchar(10) not null,
status bit not null
)

create table  employeeAccount(
empAccId int primary key not null,
empUserName varchar(50) not null,
password varchar(50) not null,
empName nvarchar(50) not null,
phone varchar(10) not null,
role varchar(10) not null,
status bit not null
)

create table movieSchedule(
movieScheId varchar(20) primary key not null,
timeSlot varchar(50) not null,

)

create table movieRoom(
movieRoomID int primary key not null,
movieRoomName nvarchar(50) not null,
sitPlaceTotal int not null,
status bit not null

)

create table moviewScheduleDetail(
movSDId int primary key not null,
movieRoomID int not null,
movieScheId varchar(20) not null,
movieId int not null,
foreign key (movieRoomID) references movieRoom(movieRoomID),
foreign key (movieScheId) references movieSchedule(movieScheId),
foreign key (movieId) references movie(movieId),
[date] date not null,
emptySlot varchar(250) not null

)

create table movieTicket(
ticketId int primary key not null,
movSDId int,
foreign key (movSDId) references moviewScheduleDetail(movSDId),
memAccId int,
foreign key (memAccId) references memberAccount(memAccId),
ticketDate date not null,
quantity int not null,
totalTicketPrice money not null,
sitDetail varchar(10) not null

)