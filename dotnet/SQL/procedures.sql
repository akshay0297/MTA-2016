--A stored procedure is a precompiled object stored in the database
--Stored procedures can invoke the Data Definition Language (DDL) and Data
--Manipulation Language (DML) statements and can return values. If you need to assign
--values to the variables declared in the procedures at run time, you can pass parameters
--while executing them. You can also execute a procedure from another procedure.

CREATE PROCEDURE prcEmployee
AS
BEGIN
SELECT * FROM Employee;
END
 

--you can view the code of the procedure by using
--the sp_helptext statement.


sp_helptext prcEmployee;


--executing a procedure
 exec prcEmployee;



 --drop procedure

 drop procedure prcEmployee;
 go

  --procedure can be altered using the ALTER PROCEDURE statement

  alter procedure prcEmployee @EID int
  as
  begin
  select * from employee where EmpID=@EID
  end

  execute prcEmployee 40;

  or

  execute prcEmployee @EID=14;

  --************************************************************************************************************************


  select  * from employee;
  go

  create procedure proc_data @EID int, 
  @nm varchar(40) output,@desig varchar(40) output
  as
  begin
  select @nm=Ename,@desig=Designation from Employee 
  where EmpID=@EID
  return 0;
  end;

  Begin
  Declare @ret int
  Declare @n varchar(40)
  Declare @d varchar(40)
  exec @ret=proc_data 40, @n output,@d output
  print @ret
  print @n
  print @d
  end


