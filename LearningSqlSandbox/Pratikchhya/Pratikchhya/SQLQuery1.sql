use pratikchhya;
drop table if exists person;
create table person (
	id int identity(1,1) primary key, 
	fullname nvarchar(20) not null,
	phone varchar(20) null
);
insert into person (fullname, phone) values ('Pratikchhya Shrestha', '19367553366');
insert into person (fullname) values ('Niranjan Shrestha'), ('Prakriti Shrestha'), ('Anjan Shrestha');
select * from person;