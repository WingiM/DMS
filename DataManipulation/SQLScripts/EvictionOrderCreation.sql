create table eviction_order
(
    order_id serial primary key,
    resident_id int references residents,
    description text
);