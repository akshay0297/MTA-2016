use empdata;

drop table student;


--alter table statements

create table student(SID int constraint pk2
primary key, 
Name varchar(30));

--alter an existing column

alter table student alter column Name varchar(40);

--alter to add a new column

alter table student add rollno int;

--alter to drop a column

alter table student drop column rollno;

--alter to remove the primary key

alter table student drop constraint pk2;

--************************************************************************************************************************************
drop table student2;

--this table has a primary key defined without the constraint keyword
create table student2 (SID int, Name varchar(30),
primary key(SID));

--in such a case, a constraint or a key can be deleted either programmatically
--or by accessing the Keys or Constraints collection of the table in the object explorer and pressing delete


--*************************************************************************************************************
create table Courses(CourseID varchar(20),
CourseName varchar(30),CourseType varchar(40),
constraint chkcr_name check 
(CourseName in ('C','C++','Java','C#')),
constraint chkcr_type check(CourseType in ('Short Term','Long Term')));


--removing a specific constaint
alter table Courses drop constraint chkcr_name;



--alter to remove the constraints applied on a table

--between constraint
create table Marksheet(SID int,Aggregate int 
check(Aggregate between 0 and 100),
Grade char(2) check (Grade between 'A' and 'D'));

--to remove the all check constraints
alter table Marksheet nocheck constraint all;

--should all be allowed
insert into Marksheet values(100,101,'A');
insert into Marksheet values(100,99,'K');

--***************************************************************************************************************************


create table Employee
(EmpID int,Ename varchar(40),Dept varchar(20),
Designation varchar(20));

--alter table to add constraints
alter table Employee alter column EmpID int not null;

alter table Employee add constraint pk1 primary key(EmpID);

alter table Employee add constraint 
chk check(Dept in ('Sales','HR','IT','Admin'));


--*****************************************************************************************************

--renaming a table

sp_rename Employee, Employee_Details;


--**************************************************************************************************

--Various forms of the Insert statement

create table Employee
(EmpID int,Ename varchar(40),Dept varchar(20),
Designation varchar(20));

--into is optional

insert Employee values(1,'John','Sales','Exec');

--inserting sparse data

insert Employee(EmpID,Dept)values(2,'HR');

--when column names specified, sequence is not important

insert Employee(Designation,Dept,EmpID,Ename)values('Intern','Marketing',14,'Sammy')

select * from employee;

--copying data from an existing table into a new table

select * into Employee_Backup From Employee;

--copy the values from an existing table to another existing table

Insert into Employee 
select * from Employee_Backup;

select * from employee;



--***********************************************************************************************************************

--updating data in a table
update employee set designation='Manager',
Ename='Smith' where empid=2;

select * from employee;


--deleting data/records from a table

delete from employee where dept='sales';

--deleting all the records

delete  employee;
