create table rooms
(
    room_number varchar(10) not null primary key,
    capacity smallint,
    gender char not null,
    "floor_number" char generated always as (left(room_number, 1)) STORED
);

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

create table rating_change_category
(
    category_id serial primary key,
    name varchar(20) not null
);

insert into rating_change_category(name) VALUES ('Докладная');

create table rating_operations (
    operation_id serial primary key,
    resident_id int not null references residents,
    category_id int not null references rating_change_category,
    change_value int not null,
    order_date date not null,
    description text
);

create table transactions (
    operation_id serial primary key,
    resident_id int not null references residents,
    sum int not null
);

create table settlement_order
(
    operation_id serial primary key,
    resident_id int references residents,
    room_number varchar(10) references rooms,
    order_date date not null,
    description text
);

create table eviction_order
(
    order_id serial primary key,
    resident_id int references residents,
    description text
);