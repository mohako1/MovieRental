/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     18/05/2025 00:59:53                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ADDRESS') and o.name = 'FK_ADDRESS_HAS2_CLIENT')
alter table ADDRESS
   drop constraint FK_ADDRESS_HAS2_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ADMIN') and o.name = 'FK_ADMIN_ADD_ADMIN')
alter table ADMIN
   drop constraint FK_ADMIN_ADD_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ENROLL') and o.name = 'FK_ENROLL_ENROLL_CLIENT')
alter table ENROLL
   drop constraint FK_ENROLL_ENROLL_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ENROLL') and o.name = 'FK_ENROLL_ENROLL2_MOVIE')
alter table ENROLL
   drop constraint FK_ENROLL_ENROLL2_MOVIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MANAGE') and o.name = 'FK_MANAGE_MANAGE_RENTAL_D')
alter table MANAGE
   drop constraint FK_MANAGE_MANAGE_RENTAL_D
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MANAGE') and o.name = 'FK_MANAGE_MANAGE2_ADMIN')
alter table MANAGE
   drop constraint FK_MANAGE_MANAGE2_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MOVIE') and o.name = 'FK_MOVIE_ADD_M_ADMIN')
alter table MOVIE
   drop constraint FK_MOVIE_ADD_M_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MOVIE') and o.name = 'FK_MOVIE_SUPPLIES_SUPPLIER')
alter table MOVIE
   drop constraint FK_MOVIE_SUPPLIES_SUPPLIER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RENTAL_DETAIL') and o.name = 'FK_RENTAL_D_DETAILS_CLIENT')
alter table RENTAL_DETAIL
   drop constraint FK_RENTAL_D_DETAILS_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RENTAL_DETAIL') and o.name = 'FK_RENTAL_D_RENT_MOVIE')
alter table RENTAL_DETAIL
   drop constraint FK_RENTAL_D_RENT_MOVIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SUPPLIER') and o.name = 'FK_SUPPLIER_ADD_S_ADMIN')
alter table SUPPLIER
   drop constraint FK_SUPPLIER_ADD_S_ADMIN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ADDRESS')
            and   name  = 'HAS2_FK'
            and   indid > 0
            and   indid < 255)
   drop index ADDRESS.HAS2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADDRESS')
            and   type = 'U')
   drop table ADDRESS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ADMIN')
            and   name  = 'ADD_FK'
            and   indid > 0
            and   indid < 255)
   drop index ADMIN.ADD_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENT')
            and   type = 'U')
   drop table CLIENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ENROLL')
            and   name  = 'ENROLL2_FK'
            and   indid > 0
            and   indid < 255)
   drop index ENROLL.ENROLL2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ENROLL')
            and   name  = 'ENROLL_FK'
            and   indid > 0
            and   indid < 255)
   drop index ENROLL.ENROLL_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ENROLL')
            and   type = 'U')
   drop table ENROLL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MANAGE')
            and   name  = 'MANAGE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index MANAGE.MANAGE2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MANAGE')
            and   name  = 'MANAGE_FK'
            and   indid > 0
            and   indid < 255)
   drop index MANAGE.MANAGE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MANAGE')
            and   type = 'U')
   drop table MANAGE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MOVIE')
            and   name  = 'ADD_M_FK'
            and   indid > 0
            and   indid < 255)
   drop index MOVIE.ADD_M_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MOVIE')
            and   name  = 'SUPPLIES_FK'
            and   indid > 0
            and   indid < 255)
   drop index MOVIE.SUPPLIES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MOVIE')
            and   type = 'U')
   drop table MOVIE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RENTAL_DETAIL')
            and   name  = 'RENT_FK'
            and   indid > 0
            and   indid < 255)
   drop index RENTAL_DETAIL.RENT_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RENTAL_DETAIL')
            and   name  = 'DETAILS_FK'
            and   indid > 0
            and   indid < 255)
   drop index RENTAL_DETAIL.DETAILS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RENTAL_DETAIL')
            and   type = 'U')
   drop table RENTAL_DETAIL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SUPPLIER')
            and   name  = 'ADD_S_FK'
            and   indid > 0
            and   indid < 255)
   drop index SUPPLIER.ADD_S_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SUPPLIER')
            and   type = 'U')
   drop table SUPPLIER
go

/*==============================================================*/
/* Table: ADDRESS                                               */
/*==============================================================*/
create table ADDRESS (
   RESID_ADRS           varchar(50)          not null,
   BUSS_ADRS            varchar(50)          not null,
   BILLING_ADRS         varchar(50)          not null,
   CLIENT_ID            int                  not null,
   constraint PK_ADDRESS primary key nonclustered (RESID_ADRS, BUSS_ADRS, BILLING_ADRS)
)
go

/*==============================================================*/
/* Index: HAS2_FK                                               */
/*==============================================================*/
create index HAS2_FK on ADDRESS (
CLIENT_ID ASC
)
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   NAME                 varchar(30)          not null,
   ADMIN_ID             int                  not null,
   PASSWORD             varchar(50)          not null,
   ADM_ADMIN_ID         int                  null,
   ROLE                 varchar(30)          not null,
   EMAIL                varchar(50)          not null,
   constraint PK_ADMIN primary key nonclustered (ADMIN_ID)
)
go

/*==============================================================*/
/* Index: ADD_FK                                                */
/*==============================================================*/
create index ADD_FK on ADMIN (
ADM_ADMIN_ID ASC
)
go

/*==============================================================*/
/* Table: CLIENT                                                */
/*==============================================================*/
create table CLIENT (
   CLIENT_ID            int                  not null,
   NAME                 varchar(30)          not null,
   PASSWORD             varchar(50)          not null,
   PHONE                varchar(30)          null,
   CREDIT_CARD          varchar(30)          not null,
   constraint PK_CLIENT primary key nonclustered (CLIENT_ID)
)
go

/*==============================================================*/
/* Table: ENROLL                                                */
/*==============================================================*/
create table ENROLL (
   CLIENT_ID            int                  not null,
   MOVIE_ID             int                  not null,
   constraint PK_ENROLL primary key nonclustered (CLIENT_ID, MOVIE_ID)
)
go

/*==============================================================*/
/* Index: ENROLL_FK                                             */
/*==============================================================*/
create index ENROLL_FK on ENROLL (
CLIENT_ID ASC
)
go

/*==============================================================*/
/* Index: ENROLL2_FK                                            */
/*==============================================================*/
create index ENROLL2_FK on ENROLL (
MOVIE_ID ASC
)
go

/*==============================================================*/
/* Table: MANAGE                                                */
/*==============================================================*/
create table MANAGE (
   RENTAL_ID            int                  not null,
   ADMIN_ID             int                  not null,
   constraint PK_MANAGE primary key nonclustered (RENTAL_ID, ADMIN_ID)
)
go

/*==============================================================*/
/* Index: MANAGE_FK                                             */
/*==============================================================*/
create index MANAGE_FK on MANAGE (
RENTAL_ID ASC
)
go

/*==============================================================*/
/* Index: MANAGE2_FK                                            */
/*==============================================================*/
create index MANAGE2_FK on MANAGE (
ADMIN_ID ASC
)
go

/*==============================================================*/
/* Table: MOVIE                                                 */
/*==============================================================*/
create table MOVIE (
   MOVIE_ID             int                  not null,
   ADMIN_ID             int                  not null,
   SUPPLIER_ID          int                  not null,
   NAME                 varchar(30)          not null,
   TYPE                 varchar(30)          null,
   PRICE                float                not null,
   LEAD_ACTOR           varchar(30)          null,
   YEAR                 int                  null,
   AGE_RESTRIECTION     int                  null,
   ADDING_YEAR          datetime             not null,
   constraint PK_MOVIE primary key nonclustered (MOVIE_ID)
)
go

/*==============================================================*/
/* Index: SUPPLIES_FK                                           */
/*==============================================================*/
create index SUPPLIES_FK on MOVIE (
SUPPLIER_ID ASC
)
go

/*==============================================================*/
/* Index: ADD_M_FK                                              */
/*==============================================================*/
create index ADD_M_FK on MOVIE (
ADMIN_ID ASC
)
go

/*==============================================================*/
/* Table: RENTAL_DETAIL                                         */
/*==============================================================*/
create table RENTAL_DETAIL (
   RENTAL_ID            int                  not null,
   MOVIE_ID             int                  not null,
   CLIENT_ID            int                  not null,
   RENTAL_DATE          datetime             not null,
   PRICE                float                not null,
   RETURN_DATE          datetime             null,
   constraint PK_RENTAL_DETAIL primary key nonclustered (RENTAL_ID)
)
go

/*==============================================================*/
/* Index: DETAILS_FK                                            */
/*==============================================================*/
create index DETAILS_FK on RENTAL_DETAIL (
CLIENT_ID ASC
)
go

/*==============================================================*/
/* Index: RENT_FK                                               */
/*==============================================================*/
create index RENT_FK on RENTAL_DETAIL (
MOVIE_ID ASC
)
go

/*==============================================================*/
/* Table: SUPPLIER                                              */
/*==============================================================*/
create table SUPPLIER (
   SUPPLIER_ID          int                  not null,
   ADMIN_ID             int                  not null,
   NAME                 varchar(30)          not null,
   CONTACT_INFO         varchar(50)          not null,
   constraint PK_SUPPLIER primary key nonclustered (SUPPLIER_ID)
)
go

/*==============================================================*/
/* Index: ADD_S_FK                                              */
/*==============================================================*/
create index ADD_S_FK on SUPPLIER (
ADMIN_ID ASC
)
go

alter table ADDRESS
   add constraint FK_ADDRESS_HAS2_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go

alter table ADMIN
   add constraint FK_ADMIN_ADD_ADMIN foreign key (ADM_ADMIN_ID)
      references ADMIN (ADMIN_ID)
go

alter table ENROLL
   add constraint FK_ENROLL_ENROLL_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go

alter table ENROLL
   add constraint FK_ENROLL_ENROLL2_MOVIE foreign key (MOVIE_ID)
      references MOVIE (MOVIE_ID)
go

alter table MANAGE
   add constraint FK_MANAGE_MANAGE_RENTAL_D foreign key (RENTAL_ID)
      references RENTAL_DETAIL (RENTAL_ID)
go

alter table MANAGE
   add constraint FK_MANAGE_MANAGE2_ADMIN foreign key (ADMIN_ID)
      references ADMIN (ADMIN_ID)
go

alter table MOVIE
   add constraint FK_MOVIE_ADD_M_ADMIN foreign key (ADMIN_ID)
      references ADMIN (ADMIN_ID)
go

alter table MOVIE
   add constraint FK_MOVIE_SUPPLIES_SUPPLIER foreign key (SUPPLIER_ID)
      references SUPPLIER (SUPPLIER_ID)
go

alter table RENTAL_DETAIL
   add constraint FK_RENTAL_D_DETAILS_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go

alter table RENTAL_DETAIL
   add constraint FK_RENTAL_D_RENT_MOVIE foreign key (MOVIE_ID)
      references MOVIE (MOVIE_ID)
go

alter table SUPPLIER
   add constraint FK_SUPPLIER_ADD_S_ADMIN foreign key (ADMIN_ID)
      references ADMIN (ADMIN_ID)
go

