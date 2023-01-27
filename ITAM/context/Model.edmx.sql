
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/27/2023 09:19:52
-- Generated from EDMX file: C:\Users\werne\source\repos\Asset-Management\ITAM\context\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [itam];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_asset_asset_type]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[asset] DROP CONSTRAINT [FK_asset_asset_type];
GO
IF OBJECT_ID(N'[dbo].[FK_asset_order]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[asset] DROP CONSTRAINT [FK_asset_order];
GO
IF OBJECT_ID(N'[dbo].[FK_asset_status]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[asset] DROP CONSTRAINT [FK_asset_status];
GO
IF OBJECT_ID(N'[dbo].[FK_assign_asset]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[assign] DROP CONSTRAINT [FK_assign_asset];
GO
IF OBJECT_ID(N'[dbo].[FK_assign_status]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[assign] DROP CONSTRAINT [FK_assign_status];
GO
IF OBJECT_ID(N'[dbo].[FK_assign_technician]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[assign] DROP CONSTRAINT [FK_assign_technician];
GO
IF OBJECT_ID(N'[dbo].[FK_item_order]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[item] DROP CONSTRAINT [FK_item_order];
GO
IF OBJECT_ID(N'[dbo].[FK_location_asset]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[location] DROP CONSTRAINT [FK_location_asset];
GO
IF OBJECT_ID(N'[itamModelStoreContainer].[FK_return_asset_asset]', 'F') IS NOT NULL
    ALTER TABLE [itamModelStoreContainer].[return_asset] DROP CONSTRAINT [FK_return_asset_asset];
GO
IF OBJECT_ID(N'[itamModelStoreContainer].[FK_return_asset_asset_type]', 'F') IS NOT NULL
    ALTER TABLE [itamModelStoreContainer].[return_asset] DROP CONSTRAINT [FK_return_asset_asset_type];
GO
IF OBJECT_ID(N'[itamModelStoreContainer].[FK_return_asset_status]', 'F') IS NOT NULL
    ALTER TABLE [itamModelStoreContainer].[return_asset] DROP CONSTRAINT [FK_return_asset_status];
GO
IF OBJECT_ID(N'[dbo].[FK_stock_order]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[stock] DROP CONSTRAINT [FK_stock_order];
GO
IF OBJECT_ID(N'[dbo].[FK_stock_status]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[stock] DROP CONSTRAINT [FK_stock_status];
GO
IF OBJECT_ID(N'[dbo].[FK_technical_room_asset]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[technical_room] DROP CONSTRAINT [FK_technical_room_asset];
GO
IF OBJECT_ID(N'[dbo].[FK_technical_room_status]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[technical_room] DROP CONSTRAINT [FK_technical_room_status];
GO
IF OBJECT_ID(N'[dbo].[FK_technical_room_technician]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[technical_room] DROP CONSTRAINT [FK_technical_room_technician];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[asset]', 'U') IS NOT NULL
    DROP TABLE [dbo].[asset];
GO
IF OBJECT_ID(N'[dbo].[asset_type]', 'U') IS NOT NULL
    DROP TABLE [dbo].[asset_type];
GO
IF OBJECT_ID(N'[dbo].[assign]', 'U') IS NOT NULL
    DROP TABLE [dbo].[assign];
GO
IF OBJECT_ID(N'[dbo].[item]', 'U') IS NOT NULL
    DROP TABLE [dbo].[item];
GO
IF OBJECT_ID(N'[dbo].[location]', 'U') IS NOT NULL
    DROP TABLE [dbo].[location];
GO
IF OBJECT_ID(N'[dbo].[notification]', 'U') IS NOT NULL
    DROP TABLE [dbo].[notification];
GO
IF OBJECT_ID(N'[dbo].[order]', 'U') IS NOT NULL
    DROP TABLE [dbo].[order];
GO
IF OBJECT_ID(N'[dbo].[requester]', 'U') IS NOT NULL
    DROP TABLE [dbo].[requester];
GO
IF OBJECT_ID(N'[dbo].[status]', 'U') IS NOT NULL
    DROP TABLE [dbo].[status];
GO
IF OBJECT_ID(N'[dbo].[stock]', 'U') IS NOT NULL
    DROP TABLE [dbo].[stock];
GO
IF OBJECT_ID(N'[dbo].[technical_room]', 'U') IS NOT NULL
    DROP TABLE [dbo].[technical_room];
GO
IF OBJECT_ID(N'[dbo].[technician]', 'U') IS NOT NULL
    DROP TABLE [dbo].[technician];
GO
IF OBJECT_ID(N'[dbo].[trial]', 'U') IS NOT NULL
    DROP TABLE [dbo].[trial];
GO
IF OBJECT_ID(N'[itamModelStoreContainer].[return_asset]', 'U') IS NOT NULL
    DROP TABLE [itamModelStoreContainer].[return_asset];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'assets'
CREATE TABLE [dbo].[assets] (
    [asset_id] int IDENTITY(1,1) NOT NULL,
    [model] varchar(20)  NOT NULL,
    [po_number] varchar(20)  NOT NULL,
    [manufacture] varchar(20)  NOT NULL,
    [serial_number] varchar(20)  NULL,
    [description] varchar(50)  NOT NULL,
    [warranty_date] datetime  NOT NULL,
    [status_id] int  NOT NULL,
    [order_id] int  NOT NULL,
    [asset_type_id] int  NOT NULL
);
GO

-- Creating table 'asset_type'
CREATE TABLE [dbo].[asset_type] (
    [type_id] int IDENTITY(1,1) NOT NULL,
    [asset_type1] varchar(20)  NOT NULL
);
GO

-- Creating table 'assigns'
CREATE TABLE [dbo].[assigns] (
    [assign_id] int IDENTITY(1,1) NOT NULL,
    [assign_name] varchar(20)  NOT NULL,
    [department] varchar(20)  NOT NULL,
    [icf] nvarchar(max)  NOT NULL,
    [asset_id] int  NOT NULL,
    [status_id] int  NOT NULL,
    [technician_id] int  NOT NULL
);
GO

-- Creating table 'items'
CREATE TABLE [dbo].[items] (
    [item_id] int IDENTITY(1,1) NOT NULL,
    [item_name] varchar(50)  NOT NULL,
    [description] varchar(50)  NOT NULL,
    [quantity] int  NOT NULL,
    [manufacture] varchar(20)  NOT NULL,
    [order_id] int  NULL
);
GO

-- Creating table 'locations'
CREATE TABLE [dbo].[locations] (
    [location_id] int IDENTITY(1,1) NOT NULL,
    [serial_number] varchar(20)  NOT NULL,
    [location1] varchar(20)  NOT NULL,
    [asset_id] int  NOT NULL
);
GO

-- Creating table 'notifications'
CREATE TABLE [dbo].[notifications] (
    [notify_id] int IDENTITY(1,1) NOT NULL,
    [message] varchar(50)  NOT NULL,
    [requester_id] int  NOT NULL
);
GO

-- Creating table 'orders'
CREATE TABLE [dbo].[orders] (
    [order_id] int IDENTITY(1,1) NOT NULL,
    [order_number] varchar(50)  NOT NULL,
    [order_date] datetime  NULL,
    [eta] datetime  NULL,
    [invoice_number] varchar(50)  NOT NULL
);
GO

-- Creating table 'requesters'
CREATE TABLE [dbo].[requesters] (
    [requester_id] int  NOT NULL,
    [requester_name] varchar(20)  NOT NULL,
    [requester_email_address] varchar(20)  NOT NULL,
    [requester_contact_number] varchar(12)  NOT NULL
);
GO

-- Creating table 'status'
CREATE TABLE [dbo].[status] (
    [status_id] int IDENTITY(1,1) NOT NULL,
    [status_name] varchar(20)  NOT NULL,
    [description] varchar(30)  NOT NULL
);
GO

-- Creating table 'stocks'
CREATE TABLE [dbo].[stocks] (
    [stock_id] int IDENTITY(1,1) NOT NULL,
    [quantity] nchar(10)  NOT NULL,
    [model] varchar(20)  NULL,
    [order_id] int  NOT NULL,
    [status_id] int  NOT NULL
);
GO

-- Creating table 'technical_room'
CREATE TABLE [dbo].[technical_room] (
    [technical_id] int  NOT NULL,
    [upload_icf] nchar(10)  NOT NULL,
    [status_id] int  NOT NULL,
    [asset_id] int  NOT NULL,
    [technician_id] int  NOT NULL
);
GO

-- Creating table 'technicians'
CREATE TABLE [dbo].[technicians] (
    [technician_id] int  NOT NULL,
    [technician_name] varchar(20)  NOT NULL
);
GO

-- Creating table 'trials'
CREATE TABLE [dbo].[trials] (
    [order_stock] int IDENTITY(1,1) NOT NULL,
    [model1] varchar(20)  NULL,
    [model2] varchar(20)  NULL,
    [model3] varchar(20)  NULL,
    [quantity1] varchar(10)  NULL,
    [quantity2] varchar(10)  NULL,
    [quantity3] varchar(10)  NULL,
    [invoice_number] varchar(15)  NULL,
    [date] datetime  NULL,
    [description] varchar(70)  NULL,
    [eta] varchar(20)  NULL
);
GO

-- Creating table 'return_asset'
CREATE TABLE [dbo].[return_asset] (
    [return_id] int IDENTITY(1,1) NOT NULL,
    [serial_number] varchar(20)  NOT NULL,
    [return_date] datetime  NOT NULL,
    [manufacture] varchar(20)  NOT NULL,
    [warranty_date] datetime  NOT NULL,
    [report] nvarchar(max)  NULL,
    [asset_id] int  NOT NULL,
    [asset_type_id] int  NOT NULL,
    [status_id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [asset_id] in table 'assets'
ALTER TABLE [dbo].[assets]
ADD CONSTRAINT [PK_assets]
    PRIMARY KEY CLUSTERED ([asset_id] ASC);
GO

-- Creating primary key on [type_id] in table 'asset_type'
ALTER TABLE [dbo].[asset_type]
ADD CONSTRAINT [PK_asset_type]
    PRIMARY KEY CLUSTERED ([type_id] ASC);
GO

-- Creating primary key on [assign_id] in table 'assigns'
ALTER TABLE [dbo].[assigns]
ADD CONSTRAINT [PK_assigns]
    PRIMARY KEY CLUSTERED ([assign_id] ASC);
GO

-- Creating primary key on [item_id] in table 'items'
ALTER TABLE [dbo].[items]
ADD CONSTRAINT [PK_items]
    PRIMARY KEY CLUSTERED ([item_id] ASC);
GO

-- Creating primary key on [location_id] in table 'locations'
ALTER TABLE [dbo].[locations]
ADD CONSTRAINT [PK_locations]
    PRIMARY KEY CLUSTERED ([location_id] ASC);
GO

-- Creating primary key on [notify_id] in table 'notifications'
ALTER TABLE [dbo].[notifications]
ADD CONSTRAINT [PK_notifications]
    PRIMARY KEY CLUSTERED ([notify_id] ASC);
GO

-- Creating primary key on [order_id] in table 'orders'
ALTER TABLE [dbo].[orders]
ADD CONSTRAINT [PK_orders]
    PRIMARY KEY CLUSTERED ([order_id] ASC);
GO

-- Creating primary key on [requester_id] in table 'requesters'
ALTER TABLE [dbo].[requesters]
ADD CONSTRAINT [PK_requesters]
    PRIMARY KEY CLUSTERED ([requester_id] ASC);
GO

-- Creating primary key on [status_id] in table 'status'
ALTER TABLE [dbo].[status]
ADD CONSTRAINT [PK_status]
    PRIMARY KEY CLUSTERED ([status_id] ASC);
GO

-- Creating primary key on [stock_id] in table 'stocks'
ALTER TABLE [dbo].[stocks]
ADD CONSTRAINT [PK_stocks]
    PRIMARY KEY CLUSTERED ([stock_id] ASC);
GO

-- Creating primary key on [technical_id] in table 'technical_room'
ALTER TABLE [dbo].[technical_room]
ADD CONSTRAINT [PK_technical_room]
    PRIMARY KEY CLUSTERED ([technical_id] ASC);
GO

-- Creating primary key on [technician_id] in table 'technicians'
ALTER TABLE [dbo].[technicians]
ADD CONSTRAINT [PK_technicians]
    PRIMARY KEY CLUSTERED ([technician_id] ASC);
GO

-- Creating primary key on [order_stock] in table 'trials'
ALTER TABLE [dbo].[trials]
ADD CONSTRAINT [PK_trials]
    PRIMARY KEY CLUSTERED ([order_stock] ASC);
GO

-- Creating primary key on [return_id], [serial_number], [return_date], [manufacture], [warranty_date], [asset_id], [asset_type_id], [status_id] in table 'return_asset'
ALTER TABLE [dbo].[return_asset]
ADD CONSTRAINT [PK_return_asset]
    PRIMARY KEY CLUSTERED ([return_id], [serial_number], [return_date], [manufacture], [warranty_date], [asset_id], [asset_type_id], [status_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [asset_id] in table 'assets'
ALTER TABLE [dbo].[assets]
ADD CONSTRAINT [FK_asset_asset_type]
    FOREIGN KEY ([asset_id])
    REFERENCES [dbo].[assets]
        ([asset_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [order_id] in table 'assets'
ALTER TABLE [dbo].[assets]
ADD CONSTRAINT [FK_asset_order]
    FOREIGN KEY ([order_id])
    REFERENCES [dbo].[orders]
        ([order_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_asset_order'
CREATE INDEX [IX_FK_asset_order]
ON [dbo].[assets]
    ([order_id]);
GO

-- Creating foreign key on [status_id] in table 'assets'
ALTER TABLE [dbo].[assets]
ADD CONSTRAINT [FK_asset_status]
    FOREIGN KEY ([status_id])
    REFERENCES [dbo].[status]
        ([status_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_asset_status'
CREATE INDEX [IX_FK_asset_status]
ON [dbo].[assets]
    ([status_id]);
GO

-- Creating foreign key on [asset_id] in table 'assigns'
ALTER TABLE [dbo].[assigns]
ADD CONSTRAINT [FK_assign_asset]
    FOREIGN KEY ([asset_id])
    REFERENCES [dbo].[assets]
        ([asset_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_assign_asset'
CREATE INDEX [IX_FK_assign_asset]
ON [dbo].[assigns]
    ([asset_id]);
GO

-- Creating foreign key on [asset_id] in table 'locations'
ALTER TABLE [dbo].[locations]
ADD CONSTRAINT [FK_location_asset]
    FOREIGN KEY ([asset_id])
    REFERENCES [dbo].[assets]
        ([asset_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_location_asset'
CREATE INDEX [IX_FK_location_asset]
ON [dbo].[locations]
    ([asset_id]);
GO

-- Creating foreign key on [asset_id] in table 'return_asset'
ALTER TABLE [dbo].[return_asset]
ADD CONSTRAINT [FK_return_asset_asset]
    FOREIGN KEY ([asset_id])
    REFERENCES [dbo].[assets]
        ([asset_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_return_asset_asset'
CREATE INDEX [IX_FK_return_asset_asset]
ON [dbo].[return_asset]
    ([asset_id]);
GO

-- Creating foreign key on [asset_id] in table 'technical_room'
ALTER TABLE [dbo].[technical_room]
ADD CONSTRAINT [FK_technical_room_asset]
    FOREIGN KEY ([asset_id])
    REFERENCES [dbo].[assets]
        ([asset_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_technical_room_asset'
CREATE INDEX [IX_FK_technical_room_asset]
ON [dbo].[technical_room]
    ([asset_id]);
GO

-- Creating foreign key on [asset_type_id] in table 'return_asset'
ALTER TABLE [dbo].[return_asset]
ADD CONSTRAINT [FK_return_asset_asset_type]
    FOREIGN KEY ([asset_type_id])
    REFERENCES [dbo].[asset_type]
        ([type_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_return_asset_asset_type'
CREATE INDEX [IX_FK_return_asset_asset_type]
ON [dbo].[return_asset]
    ([asset_type_id]);
GO

-- Creating foreign key on [status_id] in table 'assigns'
ALTER TABLE [dbo].[assigns]
ADD CONSTRAINT [FK_assign_status]
    FOREIGN KEY ([status_id])
    REFERENCES [dbo].[status]
        ([status_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_assign_status'
CREATE INDEX [IX_FK_assign_status]
ON [dbo].[assigns]
    ([status_id]);
GO

-- Creating foreign key on [technician_id] in table 'assigns'
ALTER TABLE [dbo].[assigns]
ADD CONSTRAINT [FK_assign_technician]
    FOREIGN KEY ([technician_id])
    REFERENCES [dbo].[technicians]
        ([technician_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_assign_technician'
CREATE INDEX [IX_FK_assign_technician]
ON [dbo].[assigns]
    ([technician_id]);
GO

-- Creating foreign key on [order_id] in table 'items'
ALTER TABLE [dbo].[items]
ADD CONSTRAINT [FK_item_order]
    FOREIGN KEY ([order_id])
    REFERENCES [dbo].[orders]
        ([order_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_item_order'
CREATE INDEX [IX_FK_item_order]
ON [dbo].[items]
    ([order_id]);
GO

-- Creating foreign key on [order_id] in table 'stocks'
ALTER TABLE [dbo].[stocks]
ADD CONSTRAINT [FK_stock_order]
    FOREIGN KEY ([order_id])
    REFERENCES [dbo].[orders]
        ([order_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_stock_order'
CREATE INDEX [IX_FK_stock_order]
ON [dbo].[stocks]
    ([order_id]);
GO

-- Creating foreign key on [status_id] in table 'return_asset'
ALTER TABLE [dbo].[return_asset]
ADD CONSTRAINT [FK_return_asset_status]
    FOREIGN KEY ([status_id])
    REFERENCES [dbo].[status]
        ([status_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_return_asset_status'
CREATE INDEX [IX_FK_return_asset_status]
ON [dbo].[return_asset]
    ([status_id]);
GO

-- Creating foreign key on [status_id] in table 'stocks'
ALTER TABLE [dbo].[stocks]
ADD CONSTRAINT [FK_stock_status]
    FOREIGN KEY ([status_id])
    REFERENCES [dbo].[status]
        ([status_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_stock_status'
CREATE INDEX [IX_FK_stock_status]
ON [dbo].[stocks]
    ([status_id]);
GO

-- Creating foreign key on [status_id] in table 'technical_room'
ALTER TABLE [dbo].[technical_room]
ADD CONSTRAINT [FK_technical_room_status]
    FOREIGN KEY ([status_id])
    REFERENCES [dbo].[status]
        ([status_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_technical_room_status'
CREATE INDEX [IX_FK_technical_room_status]
ON [dbo].[technical_room]
    ([status_id]);
GO

-- Creating foreign key on [technician_id] in table 'technical_room'
ALTER TABLE [dbo].[technical_room]
ADD CONSTRAINT [FK_technical_room_technician]
    FOREIGN KEY ([technician_id])
    REFERENCES [dbo].[technicians]
        ([technician_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_technical_room_technician'
CREATE INDEX [IX_FK_technical_room_technician]
ON [dbo].[technical_room]
    ([technician_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------