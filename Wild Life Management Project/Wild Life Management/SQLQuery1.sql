create database wildlife_management;
use wildlife_management;

create table photo
(
	pid integer not null identity(1,1),
	link varchar(100) not null,
	primary key(pid)
);

create table animal
(
	aid integer not null identity(1,1),
	cname varchar(20) not null,
	sname varchar(20) not null,
	tcount integer,
	status varchar(20),
	info varchar(500),
	pid integer,
	primary key(aid),
	foreign key(pid) references photo(pid) on update cascade
);

create table member
(
	mid integer not null identity(1,1),
	mname varchar(30) not null,
	dob datetime,
	age integer,
	interest varchar(20),
	city varchar(20),
	contact varchar(20),
	aid integer,
	pid integer,
	primary key(mid),
	foreign key(aid) references animal(aid) on update cascade on delete set null,
	foreign key(pid) references photo(pid) on update no action
);

create table habitat
(
	hid integer not null identity(1,1),
	hname varchar(20) not null,
	info varchar(100),
	primary key(hid)
);

create table lives_in
(
	aid integer,
	hid integer,
	primary key(aid,hid),
	foreign key(aid) references animal(aid) on delete cascade on update cascade,
	foreign key(hid) references habitat(hid) on delete cascade on update cascade
);

create table sighting
(
	sid integer not null identity(1,1),
	sname varchar(30) not null,
	place varchar(50) not null,
	info varchar(100),
	date_time datetime,
	aid integer,
	hid integer,
	mid integer,
	pid integer,
	primary key(sid),
	foreign key(aid) references animal(aid) on delete no action on update cascade,
	foreign key(hid) references habitat(hid) on delete no action on update cascade,
	foreign key(mid) references member(mid) on delete no action on update no action,
	foreign key(pid) references photo(pid) on delete no action on update no action
);

create table log_in
(
	uname varchar(20) not null,
	pword varchar(20) not null,
	mtype char(1) not null,
	primary key(uname)
);

create table register
(
	uname varchar(20) not null,
	pword varchar(20) not null,
	contact varchar(20) not null,
	unique(uname)
);

select * from member;
select * from habitat;
select * from animal;
select * from lives_in;
select * from sighting;
select * from log_in;
select * from photo;

insert into member (mname) values('admin');
select mname,mname,'M' from member;
update log_in set mtype='A' where uname='admin';

create trigger insert_on_member on member after insert
as
declare @uname varchar(20), @pword varchar(20), @contact varchar(20)
select @uname=mname from inserted;
select @pword=pword,@contact=contact from register where uname=@uname;
begin
	insert into log_in (uname,pword,mtype) values (@uname,@pword,'M');
	delete from register where uname=@uname;
end

create trigger delete_on_member on member after delete
as
begin
	delete from log_in where uname=(select mname from deleted);
end
