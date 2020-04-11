declare @department table(id int, name varchar(500), location varchar(200))
insert into @department values(1, 'IT', 'karachi')
insert into @department values(2, 'Finance', 'karachi')
insert into @department values(3, 'Marketing', 'karachi')
insert into @department values(4, 'HR', 'karachi')
insert into @department values(5, 'Accounts', 'karachi')

select * from @department

declare @emplyee table(id int, name varchar(500), departmentId int, gender varchar(200))
insert into @emplyee values(1, 'John', 1, 'male') --IT
insert into @emplyee values(2, 'Carter', 1, 'male') --IT

insert into @emplyee values(3, 'Joan', 2, 'male') --Finance
insert into @emplyee values(4, 'Scott', 2, 'male') --Finance

insert into @emplyee values(5, 'Andrew', 3, 'male') --Marketing
insert into @emplyee values(6, 'Dave', 3, 'male') --Marketing

insert into @emplyee values(7, 'Jason', 5, 'male') --Accounts
insert into @emplyee values(8, 'Mike', 5, 'male') --Accounts
insert into @emplyee values(9, 'Benn', 5, 'male') --Accounts

insert into @emplyee values(10, 'aamir', 7, 'male') --No Department

select * from @emplyee

--inner join
select e.id , e.name, e.departmentId, d.name from @department d
inner join @emplyee e on e.departmentId = d.id

--left outer join
select d.id as departmentId, d.name as departmentName, e.id employeeId, e.name employeeName from @department d
left outer join @emplyee e on e.departmentId = d.id

--right outer join
select e.id employeeId, e.name employeeName, d.id as departmentId, d.name as departmentName from @emplyee e
left outer join @department d on e.departmentId = d.id