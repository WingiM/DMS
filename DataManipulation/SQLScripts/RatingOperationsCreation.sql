create table rating_operations (
    operation_id serial primary key,
    resident_id int not null references residents,
    category_id int not null references rating_change_category,
    change_value int not null,
    order_date date not null,
    description text
);