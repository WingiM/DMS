create table settlement_order
(
    operation_id serial primary key,
    resident_id int references residents,
    room_number varchar(10) references rooms,
    order_date date not null,
    description text
);