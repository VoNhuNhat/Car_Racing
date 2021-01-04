create database DB_Car_Racing
go

use DB_Car_Racing
go

create table Player(
	Id int identity primary key,
	Name nvarchar(50),
	Score int
)
go

create proc GetPlayers
as
begin
	select top(5) * from Player order by Score desc
end
go

create proc GetLowestScore
	@Score int
as
begin
	select * from Player where Score > @Score order by Score desc offset 4 rows fetch next 1 rows only
end
go

create proc SaveHighScore
	@Name nvarchar(50),
	@Score int
as
begin
	insert into Player values (@Name, @Score)
end
go