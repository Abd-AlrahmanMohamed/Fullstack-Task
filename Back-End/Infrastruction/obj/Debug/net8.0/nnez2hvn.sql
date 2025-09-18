IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Carts] (
    [Id] int NOT NULL IDENTITY,
    [Custom] nvarchar(max) NOT NULL,
    [Size] nvarchar(max) NOT NULL,
    [Quantity] int NOT NULL,
    [ProductId] int NOT NULL,
    [OrderId] int NOT NULL,
    CONSTRAINT [PK_Carts] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [CustomProducts] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [Image] nvarchar(max) NOT NULL,
    [Cost] float NOT NULL,
    [UserUploadId] int NOT NULL,
    CONSTRAINT [PK_CustomProducts] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Products] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(500) NOT NULL,
    [Images] nvarchar(max) NOT NULL,
    [Brand] nvarchar(max) NOT NULL,
    [Colors] nvarchar(max) NOT NULL,
    [Price] float NOT NULL,
    [CartId] int NOT NULL,
    [CategoryId] int NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Orders] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Address] nvarchar(max) NOT NULL,
    [City] nvarchar(max) NOT NULL,
    [State] nvarchar(max) NOT NULL,
    [ZipCode] int NOT NULL,
    [Contact] int NOT NULL,
    [CartId] int NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Orders_Carts_CartId] FOREIGN KEY ([CartId]) REFERENCES [Carts] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [UserUploads] (
    [Id] int NOT NULL IDENTITY,
    [Image] nvarchar(max) NOT NULL,
    [CustomProductId] int NOT NULL,
    CONSTRAINT [PK_UserUploads] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_UserUploads_CustomProducts_CustomProductId] FOREIGN KEY ([CustomProductId]) REFERENCES [CustomProducts] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [CartProduct] (
    [CartsId] int NOT NULL,
    [ProductsId] int NOT NULL,
    CONSTRAINT [PK_CartProduct] PRIMARY KEY ([CartsId], [ProductsId]),
    CONSTRAINT [FK_CartProduct_Carts_CartsId] FOREIGN KEY ([CartsId]) REFERENCES [Carts] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_CartProduct_Products_ProductsId] FOREIGN KEY ([ProductsId]) REFERENCES [Products] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [CartProducts] (
    [CartId] int NOT NULL,
    [ProductId] int NOT NULL,
    CONSTRAINT [PK_CartProducts] PRIMARY KEY ([CartId], [ProductId]),
    CONSTRAINT [FK_CartProducts_Carts_CartId] FOREIGN KEY ([CartId]) REFERENCES [Carts] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_CartProducts_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Categories] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Description] nvarchar(500) NOT NULL,
    [ProductId] int NOT NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Categories_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_CartProduct_ProductsId] ON [CartProduct] ([ProductsId]);
GO

CREATE INDEX [IX_CartProducts_ProductId] ON [CartProducts] ([ProductId]);
GO

CREATE INDEX [IX_Categories_ProductId] ON [Categories] ([ProductId]);
GO

CREATE INDEX [IX_Orders_CartId] ON [Orders] ([CartId]);
GO

CREATE INDEX [IX_UserUploads_CustomProductId] ON [UserUploads] ([CustomProductId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241231172325_AddMarketPlaceTables', N'8.0.10');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DROP TABLE [CartProduct];
GO

DROP TABLE [CartProducts];
GO

DROP TABLE [Categories];
GO

DROP TABLE [Orders];
GO

DROP TABLE [UserUploads];
GO

DROP TABLE [Products];
GO

DROP TABLE [Carts];
GO

DROP TABLE [CustomProducts];
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241231173539_AddJWT', N'8.0.10');
GO

COMMIT;
GO

