
if OBJECT_ID('Instructor','U') is not NULL
	drop table Instructor;
	
create table Instructor
(
	insid varchar(20),
	ifname varchar(20),
	ilname varchar(20),
	iroom int,
	primary key(insid)
)

if OBJECT_ID('Student','U') is not NULL
	drop table Student;
	
create table Student
(
	sid varchar(20),
	insid varchar(20),
	sfname varchar(20),
	slname varchar(20),
	ccomp int,
	cgpa float,
	primary key(sid),
)


if OBJECT_ID('Course','U') is not NULL
	drop table Course;
	
create table Course
(
	cid varchar(20),
	cname varchar(20),
	crdt int,
	primary key(cid)
)

if OBJECT_ID('C_completed','U') is not NULL
	drop table C_completed;
	
create table C_completed
(
	sid varchar(20),
	cid varchar(20),
	primary key(sid,cid)
)

if OBJECT_ID('C_taken','U') is not NULL
	drop table C_taken;
	
create table C_taken
(
	sid varchar(20),
	cid varchar(20),
	primary key(sid,cid)
)

if OBJECT_ID('P_req','U') is not NULL
	drop table P_req;
	
create table P_req
(
	cid varchar(20),
	pid varchar(20),
	primary key(cid,pid)
)

