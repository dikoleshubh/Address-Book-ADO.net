create database AddressBook;
create table AddressBookProfiles
(FirstName varchar(50) not null,
LastName varchar(50),
Address varchar(200) not null,
City varchar(50) not null,
State varchar(50) not null,
Zip int not null,
PhoneNo int not null,
Email varchar(150) not null
);
use AddressBook;
create table AddressBookProfiles
(FirstName varchar(50) not null,
LastName varchar(50),
Address varchar(200) not null,
City varchar(50) not null,
State varchar(50) not null,
Zip int not null,
PhoneNo int not null,
Email varchar(150) not null
);

select * from AddressBookProfiles;
insert into AddressBookProfiles(FirstName,LastName,Address,City,State,Zip,PhoneNo,Email)
values
('Nrk', 'Champ','Ethe','Tkyo', 'MH', 86656,96213866, 'Nrk@gmail.com'),
 ('Awaw', 'ASdfa', 'jgii', 'Takli', 'MH', 85225, 89635332, 'conan@gmail.com');
 select * from AddressBookProfiles;
