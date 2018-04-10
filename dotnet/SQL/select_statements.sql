use AdventureWorks

--display the entire data from a table
select * from HumanResources.Employee;

--retrieving specific columns but all rows

select EmployeeID, ContactID, Title,BirthDate from 
HumanResources.Employee;

--customizing the display 

select * from HumanResources.Department;

--using the AS clause
select DepartmentID as 'Department Number', Name as 'Department Name' from HumanResources.Department;

--using the =operator
select 'Department Number'=DepartmentID,'Department Name'=Name from HumanResources.Department;

--without any operator
select DepartmentID 'Department Number', Name 'Department Name' from HumanResources.Department;


--concatenating data

select 'Database Programming'+'Using'+'MS SQL Server' as Title;


Select Name+' department is part of '+GroupName+' group' from HumanResources.Department as 'Information';

--applying calculations by using operators like + - * / %

select * from HumanResources.EmployeePayHistory;

select EmployeeID,Rate as 'Hourly Rate',8*Rate as 'Per Day Rate' from HumanResources.EmployeePayHistory;


--getting specific rows

select * from humanresources.Department;

select * from humanresources.Department where groupname='Manufacturing';

select DepartmentID,Name from HumanResources.Department where GroupName='Manufacturing';

--using comparison operators (= != <> > >= < <= )

select * from HumanResources.Employee;

select EmployeeID,LoginID from HumanResources.Employee where ManagerID=16;

select EmployeeID,LoginID from HumanResources.Employee where ManagerID<>16;

--not less than operator (!<) [evaluates to greater than or equal to]

select * from HumanResources.Employee where VacationHours !<40;

--not greater than (!>, evaluates to less than equal to)
select * from HumanResources.Employee where VacationHours !>40;

--logical operators

select * from HumanResources.Employee;

select * from HumanResources.Employee where 
VacationHours>=50 and sickleavehours<=30;


select * from HumanResources.Employee where 
VacationHours>=50 OR sickleavehours<=30;

select * from HumanResources.Employee where 
NOT Title='Design Engineer';

--between and not between

select * from HumanResources.Employee where VacationHours 
between 20 and 30;


select * from HumanResources.Employee where VacationHours 
not between 20 and 30;

--in and not in, matching any value from a given set
select * from HumanResources.Employee where title in ('Marketing Assistant','Tool Designer');

select * from HumanResources.Employee where title not in ('Marketing Assistant','Tool Designer');

--matching a pattern


--% matches any string of zero or more characters
select * from HumanResources.Employee where 
title like 'Production%';

--underscore (-) represents a single character

select * from HumanResources.Department where Name like '______ing';

select * from Production.Product;

select * from Production.Product where Name like '[BL]L%';

select * from Production.Product where Name like '[^BL]L%';


select * from Production.Product where Name like '[B-L]L%';

select * from Production.Product where Name like '[^B-L]L%';

--null and not null
select * from Production.Product where Color is null;

select * from Production.Product where Color is not null;

--displying records in a squence

select * from HumanResources.Department;

select Name,GroupName from HumanResources.Department order by groupname;

select Name,GroupName from HumanResources.Department order by groupname desc;

select Name,GroupName from HumanResources.Department order by groupname,name;

--aggregate functions

select * from HumanResources.Employee;

select count(*) as 'total rows' from HumanResources.Employee;

select max(vacationhours), min(vacationhours),avg(vacationhours),sum(sickleavehours)
 from HumanResources.Employee;

 --group by for summaarization of data

 select title,count(title) as 'Count' from humanresources.Employee group by title;

 select title,count(title) as 'Count' from humanresources.Employee where title not in ('Tool Designer','Design Engineer')
 group by title;

 select title,count(title) as 'Count' from humanresources.Employee where title not in ('Tool Designer','Design Engineer')
 group by title having count(title)>=5;

