--A view is a virtual table, which provides access to a subset of columns from one or more
--tables. It is a query stored as an object in the database, which does not have its own data.
--A view can derive its data from one or more tables, called the base tables or underlying
--tables.


select * from employee;
go

create view view1 
as select EmpID, Designation
from employee;
go


select * from view1;

--using views it is possible to update the underlying base table

update view1 set EmpID=40 where EmpID=12;

select * from employee;
go


--views can be altered
alter view view1
as select EmpID,Ename,Dept from employee where designation<>'Intern'
go

select * from view1;

--renaming views
sp_rename view1, emp_view;
select * from emp_view;

drop view emp_view;






