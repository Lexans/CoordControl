drop table if exists cross

    drop table if exists cross_plan

    drop table if exists pass

    drop table if exists plan

    drop table if exists road

    drop table if exists route

    drop table if exists hibernate_unique_key

    PRAGMA foreign_keys = ON

    create table cross (
        id_cross BIGINT not null,
       street_name TEXT,
       road_left BIGINT unique,
       road_right BIGINT unique,
       pass_left BIGINT unique,
       pass_right BIGINT unique,
       pass_top BIGINT unique,
       pass_bottom BIGINT unique,
       route BIGINT,
       position INT,
       primary key (id_cross),
       constraint FKD0EBBE31B5E81671 foreign key (road_left) references road,
       constraint FKD0EBBE315B192411 foreign key (road_right) references road,
       constraint FKD0EBBE31288C0E1D foreign key (pass_left) references pass,
       constraint FKD0EBBE31DC8E96ED foreign key (pass_right) references pass,
       constraint FKD0EBBE31D4AA9E40 foreign key (pass_top) references pass,
       constraint FKD0EBBE31D476908A foreign key (pass_bottom) references pass,
       constraint FKD0EBBE313032BA66 foreign key (route) references route
    )

    create table cross_plan (
        plan BIGINT not null,
       cross BIGINT not null,
       p1_main_interval INT,
       p1_mediate_interval INT,
       p2_main_interval INT,
       p2_mediate_interval INT,
       phase_offset INT,
       primary key (plan, cross),
       constraint FKB417C85C4D22B62C foreign key (plan) references plan,
       constraint FKB417C85CA2045E9E foreign key (cross) references cross
    )

    create table pass (
        id_pass BIGINT not null,
       intensity INT,
       lines_count INT,
       line_width DOUBLE,
       left_part INT,
       direct_part INT,
       right_part INT,
       primary key (id_pass)
    )

    create table plan (
        id_plan BIGINT not null,
       title TEXT,
       cycle INT,
       route BIGINT not null unique,
       primary key (id_plan),
       constraint FK5E22EEF53032BA66 foreign key (route) references route
    )

    create table road (
        id_road BIGINT not null,
       length INT,
       speed INT,
       primary key (id_road)
    )

    create table route (
        id_route BIGINT not null,
       street_name TEXT,
       cross_count INT,
       primary key (id_route)
    )

    create table hibernate_unique_key (
         next_hi BIGINT 
    )