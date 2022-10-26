-- Active: 1666715598134@@SG-kiwi-myrtle-9554-6832-mysql-master.servers.mongodirector.com@3306@stuff

create Table
    if not exists jobs(
        id int not null AUTO_INCREMENT primary KEY,
        company VARCHAR(255) not NULL,
        jobTitle VARCHAR(255) not null,
        hours int not null check (hours > 0),
        rate decimal(10, 2) not null check (rate >= 7.25),
        description VARCHAR(255) not null
    );

insert into
    jobs(
        company,
        jobTitle,
        hours,
        rate,
        description
    )
values (
        "Patrick Industries",
        "Worker",
        "40",
        "7.25",
        "It's not much but it's honest work."
    );

select * from jobs;