--select * from Students
--insert into Students 
--Values
--('Malak','Mansimova','m@code.edu.az',20),
--('Benovshe','Aydinli','b@code.edu.az',21),
--('Senan','Shahmammadov','s@code.edu.az',19)

--select * from Students
--Update Students set Age=21 where Id=4

Create table StudentInfos(
Id int primary key identity,
Email varchar(255) unique,
Phone varchar(30) ,
StudentId int references Students(Id),
--StudentId int foreign key references Students(Id),
 --primary  key (Id)
 --foreign key StudentId references Students(Id)
)



--Create table Countries(
--Id int primary key identity,
--Name nvarchar(255) unique,
--Population int ,
--Area decimal(8,2)
--)
--Create table Cities(
--Id int primary key identity,
--Name nvarchar(255) unique,
--Population int ,
--Area decimal(8,2),
--CountryId int references Countries(Id)
--)

--inner join
--Select ct.Name As 'Country',
--from Countries AS ct
--Inner Join Cities As cs
--on ct.Id=cs.CountryId

Select ct.Name 'Country',cs.Name 'City'
from Countries  ct
Inner Join Cities  cs
on ct.Id=cs.CountryId


--left outer join
Select ct.Name 'Country',cs.Name 'City'
from Countries  ct
Left Join Cities  cs
on ct.Id=cs.CountryId

--right outer join
Select ct.Name 'Country',cs.Name 'City'
from Countries  ct
Right Join Cities  cs
on ct.Id=cs.CountryId

--Full outer join
Select ct.Name 'Country',cs.Name 'City'
from Countries  ct
Full Join Cities  cs
on ct.Id=cs.CountryId



--self join
 create table Positions(
 Id int primary key identity,
 Role nvarchar(50) unique,
 Dependon int 
 )

 Select p1.Role 'Role',p2.Role 'DependOn' from Positions p1
 left join Positions p2
  on p1.Dependon=p2.Id


  --cross join

  create table Products(
  Id int primary key identity,
  Name nvarchar(255)

  )
    create table Sizes(
  Id int primary key identity,
  Size nvarchar(10)
  )

  --select * from Products
  --Cross join Sizes

    select * from Products,Sizes

--non-equals join

Alter Table Students 
Add Point int check (Point>=0and Point<=100)

Create table Grades(
Id int primary key identity,
Letter varchar(5) unique,
MinimumGrade int check(MinimumGrade>=0and MinimumGrade<=100),
MaximumGrade int check(MaximumGrade>=0and MaximumGrade<=100)

)

--Select s.Name,s.Surname,g.Letter,s.Point from Students s
--join Grades g

--on s.Point>=g.MinimumGrade and s.Point <= g.MaximumGrade

Select s.Name,s.Surname,g.Letter,s.Point from Students s
join Grades g

on s.Point Between MinimumGrade and MaximumGrade
