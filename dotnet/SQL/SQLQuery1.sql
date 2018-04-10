--create a database

create database TestData;

--get info about a database

sp_helpdb TestData;

--renaming a database

sp_renamedb TestData, EmpData;


--dropping a database
drop database EmpData;


--select the desired database
use EmpData;

--creating a table
create table Employee
(EmpID int,Ename varchar(40),Dept varchar(20),
Designation varchar(20));

--viewing a table structure using the stored procedure

sp_help Employee;

--try inserting a record
insert into Employee values
(1,'Mike','Sales','Manager');

--another one

insert into Employee values(2,'John','HR',null);

--check the records inserted

select * from Employee;


--use of identity and not null constraints
create table Emp(EmpCode int identity(100,1),
EmpName varchar(25) not null,Dept varchar(10) not null);

--check the structure
sp_help Emp;

--error, you can not explicitly insert value for an identity column
insert into Emp values(1,'John','Sales');

--null not allowed, error
insert into Emp values('Tom',null);

--this will be done
insert into Emp values('Mike','HR');
insert into Emp values('Amy','Sales');


--check the record inserted

select * from Emp;

drop table Emp;


--the unique constraint
--no repeating values allowed under the column
--null is allowed only once

create table Emp1 (EID int unique,Ename varchar(20));

--insert records
insert into Emp1 values(10,'abc');
insert into Emp1 values(null,'abc');

--error, can not insert null more than once
insert into Emp1 values(null,'def');

--error, no duplicate value allowed
insert into Emp1 values(10,'xxx');

drop table Emp1;

--another syntax to apply unique constriant

create table Emp1 
(EID int constraint unk unique,Ename varchar(20));


--********************************************************************************************************************

--Applying constraints to maintain data integrity
--constaints are applied with Create table or alter table statements


create table student(SID int constraint pk1 
primary key, 
Name varchar(30));

drop table student;

create table student (SID int primary key, 
Name varchar(30));

drop table student;

create table student (SID int, Name varchar(30),
primary key(SID));

--insert the records
insert into student values(1,'A');
insert into student values(2,'B');
insert into student values(1,'C');
insert into student values(null,'A');

drop table student;

--composite primary key
create table student 
(SID int, RollNo int, Name varchar(30),
primary key(SID,RollNo));

insert into student values(10,1,'ABC');
insert into student values(10,2,'ABC');
insert into student values(11,1,'ABC');

--error, combination can not be repeated
insert into student values(10,1,'ABC');

drop table student;

--******************************************************************************************************************************

--foreign key constraints
create table Dept(DeptNo int primary key,DeptName varchar(20))

create table Emp_Details(EmpCode varchar(10) primary key,
EmpName varchar(10),
DeptNo int constraint fk1 foreign key references Dept(DeptNo));

--records will be first inserted in the parent table and then the matching record will be allowed in the child
insert into Dept values(10,'Sales');
insert into Emp_Details values('E001','Sam',10);

--error, no matching record exists in the parent table

insert into Emp_Details values('E002','Sammy',11);

--deletion from related records
--no orphaned record is allowed in the child table, so deletion should happen first from the child table

--error
delete from dept where deptno=10;

--so delete from child first
delete from emp_details where empcode='E001';

--then from parent
delete from dept where deptno=10;

--similarly, if required the child table needs to be deleted before the parent table
drop table emp_details;

drop table dept;

--********************************************************************************************************************

--the foreign key constraints with ON DELETE and ON UPDATE clauses
--these clauses specify the what action to perform if an attempt is made to delete or update a primary key record

create table Dept(DeptNo int primary key,DeptName varchar(20))

create table Emp_Details(DeptNo int,EmpCode varchar(10) primary key,
EmpName varchar(10),foreign key(DeptNo) references Dept(DeptNo)
ON UPDATE CASCADE ON DELETE NO ACTION);


insert into Dept values(10,'Sales');

insert into Emp_Details values(10,'E001','Sam');

--view the inserted records
select * from Dept;

select * from Emp_Details;

--lets try updating the parent record, and then view the records again

update Dept set DeptNo=100 where DeptNo=10;

--same for delete

delete from Dept where DeptNo=100;

--************************************************************************************
drop table Emp_Details;

drop table Dept;

--*******************************************************************************

--check constraints to implement domain integrity
--it can be applied by using the arithmetic operators and relational operators, or keywords,
--such as IN, LIKE, and BETWEEN.

create table Project(ProjectID varchar(20),
StartDate datetime, Enddate datetime,
Constraint chkDate CHECK (StartDate < EndDate))

insert into Project values('P001','2016-05-01','2016-8-31');

--following is an error
insert into Project values('P001','2016-08-01','2016-5-31');

create table Courses(CourseID varchar(20),
CourseName varchar(30),
constraint chkcr_name check 
(CourseName in ('C','C++','Java','C#')));

--same can be done without using the constraint keyword
--and an explicit constraint name
create table Courses1(CourseID varchar(20),
CourseName varchar(30),
check 
(CourseName in ('C','C++','Java','C#')));

insert into Courses values('C001','c');
--error
insert into Courses values('C001','cpp');



create table stud(SID varchar(10) 
check(SID like 'S00[0-5][A-M]'));

--error, at the fourth position should be a number between 0 and 5
insert into stud values('S009A');

insert into stud values('S005X');

insert into stud values('S05A');

--this is fine
insert into stud values('S005B');

--between constraint
create table Marksheet(SID int,
Aggregate int check(Aggregate between 0 and 100),
Grade char(2) check (Grade between 'A' and 'D'));

--should not be allowed
insert into Marksheet values(100,101,'A');
insert into Marksheet values(100,99,'K');

--this should work
insert into Marksheet values(100,99,'A');

--default constraint
drop table Course;

Create table Course(CourseID int, coursename varchar(30),
CourseType varchar(20) default 'Long term'); 

insert into Course values(1,'C',default);
insert into Course (CourseID,coursename) values(2,'C++');
insert into Course values(3,'C++','Short Term');
select * from course;

--*********************************************************************************************************************

--creating rules for data integrity

--closes the previous batch
go

CREATE RULE rule_Marks
AS @mrks between 0 and 100
go

create table marks1(RollNo int, Sub1 int,Sub2 int);
go

sp_bindrule 'rule_Marks','dbo.marks1.Sub1';
go

sp_bindrule 'rule_Marks','dbo.marks1.Sub2';
go

sp_unbindrule 'dbo.marks1.Sub1';
go

--you can not drop a rule as long as it is bound to some column
drop rule rule_Marks;









