create table rating_change_category
(
    category_id serial primary key,
    name        varchar(20) not null
);

insert into rating_change_category(name)
VALUES ('Докладная');