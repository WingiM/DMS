create table rooms
(
    room_number varchar(10) not null primary key,
    capacity smallint,
    gender char not null,
    "floor_number" char generated always as (left(room_number, 1)) STORED
);