create table residents (
    resident_id serial primary key,
    last_name varchar(50) not null,
    first_name varchar(30) not null,
    patronymic varchar(30),
    gender char not null,
    birth_date date not null,
    passport_information varchar(10),
    tin varchar(12),
    room_number varchar(10) references rooms
);