create table transactions (
    operation_id serial primary key,
    resident_id int not null references residents,
    sum int not null
);