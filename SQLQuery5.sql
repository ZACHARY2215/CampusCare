create table administrator(
	admin_id int primary key identity(1,1),
	username varchar(100) not null,
	pass_word varchar(100) not null
)

insert into administrator(username,pass_word)
values
('admin','@dmin123')