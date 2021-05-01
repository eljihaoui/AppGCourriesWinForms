/*==============================================================*/
/* Nom de SGBD :  Microsoft SQL Server 2017                     */
/* Date de création :  15/05/2020 17:36:15                      */
/*==============================================================*/



/*==============================================================*/
/* Table : ARRIVEE                                              */
/*==============================================================*/
create table ARRIVEE (
   IDARRIVEE            int       identity(1,1)   not null,
   IDCATEG              int                  not null,
   IDUSER               int                  not null,
   IDENTITE             int                  not null,
   ANNEE                int                  not null,
   NUMORDRE             int                  not null,
   DATEORDRE            datetime             not null,
   NUMCOURRIER          varchar(50)          null,
   DATECOURRIER         datetime             null,
   SUJET                varchar(255)         not null,
   REMARQUES            varchar(255)         null,
   constraint PK_ARRIVEE primary key (IDARRIVEE)
)
go

/*==============================================================*/
/* Index : AVOIR_FK                                             */
/*==============================================================*/




create nonclustered index AVOIR_FK on ARRIVEE (IDCATEG ASC)
go

/*==============================================================*/
/* Index : SAISIR_FK                                            */
/*==============================================================*/




create nonclustered index SAISIR_FK on ARRIVEE (IDUSER ASC)
go

/*==============================================================*/
/* Index : ENVOYER_FK                                           */
/*==============================================================*/




create nonclustered index ENVOYER_FK on ARRIVEE (IDENTITE ASC)
go

/*==============================================================*/
/* Table : ARRIVEEDOCS                                          */
/*==============================================================*/
create table ARRIVEEDOCS (
   IDARRIVEEDOCS        int  identity(1,1)    not null,
   IDARRIVEE            int                  not null,
   TYPEDOCARRIVEE       varchar(100)         not null,
   CONTENUFILEARRIVEE   varbinary(MAX)        not null,
   constraint PK_ARRIVEEDOCS primary key (IDARRIVEEDOCS)
)
go

/*==============================================================*/
/* Index : AVOIR_PJ_FK                                          */
/*==============================================================*/




create nonclustered index AVOIR_PJ_FK on ARRIVEEDOCS (IDARRIVEE ASC)
go

/*==============================================================*/
/* Table : CATEGORIE                                            */
/*==============================================================*/
create table CATEGORIE (
   IDCATEG              int                  not null,
   LIBCATEG             varchar(100)         not null,
   constraint PK_CATEGORIE primary key (IDCATEG)
)
go

/*==============================================================*/
/* Table : DEPART                                               */
/*==============================================================*/
create table DEPART (
   IDDEPART             int    identity(1,1)  not null,
   IDCATEG              int                  not null,
   IDUSER               int                  not null,
   ANNEE                int                  not null,
   NUMORDRE             int                  not null,
   DATEORDRE            datetime             not null,
   SUJET                varchar(255)         not null,
   REMARQUES            varchar(255)         null,
   constraint PK_DEPART primary key (IDDEPART)
)
go

/*==============================================================*/
/* Index : CLASSER_FK                                           */
/*==============================================================*/




create nonclustered index CLASSER_FK on DEPART (IDCATEG ASC)
go

/*==============================================================*/
/* Index : ENREGISTRER_FK                                       */
/*==============================================================*/




create nonclustered index ENREGISTRER_FK on DEPART (IDUSER ASC)
go

/*==============================================================*/
/* Table : DEPARTDOCS                                           */
/*==============================================================*/
create table DEPARTDOCS (
   IDDCODEPART          int identity(1,1)    not null,
   IDDEPART             int                  not null,
   TYPEDOCDEPART        varchar(100)         not null,
   CONTENUFILEDEPART    varbinary(MAX)       not null,
   constraint PK_DEPARTDOCS primary key (IDDCODEPART)
)
go

/*==============================================================*/
/* Index : AVOIR_DOCS_FK                                        */
/*==============================================================*/




create nonclustered index AVOIR_DOCS_FK on DEPARTDOCS (IDDEPART ASC)
go

/*==============================================================*/
/* Table : DESTINER                                             */
/*==============================================================*/
create table DESTINER (
   IDDEPART             int                  not null,
   IDENTITE             int                  not null,
   constraint PK_DESTINER primary key (IDDEPART, IDENTITE)
)
go

/*==============================================================*/
/* Index : DESTINER2_FK                                         */
/*==============================================================*/




create nonclustered index DESTINER2_FK on DESTINER (IDDEPART ASC)
go

/*==============================================================*/
/* Index : DESTINER_FK                                          */
/*==============================================================*/




create nonclustered index DESTINER_FK on DESTINER (IDENTITE ASC)
go

/*==============================================================*/
/* Table : ENTITES                                              */
/*==============================================================*/
create table ENTITES (
   IDENTITE             int                  not null,
   LIBENTITE            varchar(200)         not null,
   constraint PK_ENTITES primary key (IDENTITE)
)
go

/*==============================================================*/
/* Table : TUSERS                                               */
/*==============================================================*/
create table TUSERS (
   IDUSER               int                  not null,
   LOGIN                varchar(30)          not null,
   PASSE                varchar(30)          not null,
   NOMUSER              varchar(100)         not null,
   constraint PK_TUSERS primary key (IDUSER)
)
go

alter table ARRIVEE
   add constraint FK_ARRIVEE_AVOIR_CATEGORI foreign key (IDCATEG)
      references CATEGORIE (IDCATEG)
go

alter table ARRIVEE
   add constraint FK_ARRIVEE_ENVOYER_ENTITES foreign key (IDENTITE)
      references ENTITES (IDENTITE)
go

alter table ARRIVEE
   add constraint FK_ARRIVEE_SAISIR_TUSERS foreign key (IDUSER)
      references TUSERS (IDUSER)
go

alter table ARRIVEEDOCS
   add constraint FK_ARRIVEED_AVOIR_PJ_ARRIVEE foreign key (IDARRIVEE)
      references ARRIVEE (IDARRIVEE)
go

alter table DEPART
   add constraint FK_DEPART_CLASSER_CATEGORI foreign key (IDCATEG)
      references CATEGORIE (IDCATEG)
go

alter table DEPART
   add constraint FK_DEPART_ENREGISTR_TUSERS foreign key (IDUSER)
      references TUSERS (IDUSER)
go

alter table DEPARTDOCS
   add constraint FK_DEPARTDO_AVOIR_DOC_DEPART foreign key (IDDEPART)
      references DEPART (IDDEPART)
go

alter table DESTINER
   add constraint FK_DESTINER_DESTINER_ENTITES foreign key (IDENTITE)
      references ENTITES (IDENTITE)
go

alter table DESTINER
   add constraint FK_DESTINER_DESTINER2_DEPART foreign key (IDDEPART)
      references DEPART (IDDEPART)
go

