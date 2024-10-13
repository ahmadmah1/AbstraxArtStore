SET IDENTITY_INSERT [dbo].[Product] ON
INSERT INTO [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [ProductPrice], [ProductDesc], [ImageName]) VALUES (2, 1, N'Bird Painting', CAST(34.99 AS Decimal(7, 2)), N'A Bird Painting', N'bird-3342446_1280242716191.jpg')
INSERT INTO [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [ProductPrice], [ProductDesc], [ImageName]) VALUES (3, 1, N'Avocado Collage Painting', CAST(14.99 AS Decimal(7, 2)), N'Vibrant painting featuring a bunch of avocados on a black background.', N'avocados-3513048_1280242840496.jpg')
INSERT INTO [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [ProductPrice], [ProductDesc], [ImageName]) VALUES (4, 3, N'Backyard Painting', CAST(159.99 AS Decimal(7, 2)), N'Watercolour style painting of a home in the wilderness.', N'catherine-kay-greenup-17Q8cyAFyVg-unsplash242941408.jpg')
INSERT INTO [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [ProductPrice], [ProductDesc], [ImageName]) VALUES (5, 4, N'Marble Painting', CAST(49.99 AS Decimal(7, 2)), N'Grey, white and black marble style artwork.', N'Mockup 1243240145.jpeg')
INSERT INTO [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [ProductPrice], [ProductDesc], [ImageName]) VALUES (6, 4, N'Dark Knight Painting', CAST(14.99 AS Decimal(7, 2)), N'Dark mountains lit up by the light of a moon.', N'painting-3995999_1280243333976.jpg')
INSERT INTO [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [ProductPrice], [ProductDesc], [ImageName]) VALUES (7, 3, N'Lemon Painting', CAST(29.99 AS Decimal(7, 2)), N'Lemons on a tree - pencil style.', N'fruit-2310212_1280243418929.jpg')
INSERT INTO [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [ProductPrice], [ProductDesc], [ImageName]) VALUES (8, 3, N'Graffiti Painting', CAST(99.99 AS Decimal(7, 2)), N'Red, Yellow and blue graffiti on a wall.', N'graffiti-569265_1280243515092.jpg')
INSERT INTO [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [ProductPrice], [ProductDesc], [ImageName]) VALUES (9, 1, N'Sand Dunes', CAST(9.99 AS Decimal(7, 2)), N'Sand dunes drawn in white.', N'images243557628.jfif')
SET IDENTITY_INSERT [dbo].[Product] OFF


SET IDENTITY_INSERT [dbo].[Payment] ON
INSERT INTO [dbo].[Payment] ([PaymentId], [OrderId], [PaymentAmount], [PaymentMethod], [PaymentDate]) VALUES (1, 3, CAST(79.99 AS Decimal(7, 2)), 2, N'2024-10-13 19:38:24')
INSERT INTO [dbo].[Payment] ([PaymentId], [OrderId], [PaymentAmount], [PaymentMethod], [PaymentDate]) VALUES (2, 5, CAST(14.99 AS Decimal(7, 2)), 0, N'2024-10-13 19:38:37')
INSERT INTO [dbo].[Payment] ([PaymentId], [OrderId], [PaymentAmount], [PaymentMethod], [PaymentDate]) VALUES (3, 4, CAST(49.99 AS Decimal(7, 2)), 1, N'2024-10-13 19:38:51')
INSERT INTO [dbo].[Payment] ([PaymentId], [OrderId], [PaymentAmount], [PaymentMethod], [PaymentDate]) VALUES (4, 12, CAST(149.99 AS Decimal(7, 2)), 0, N'2024-10-13 19:40:30')
INSERT INTO [dbo].[Payment] ([PaymentId], [OrderId], [PaymentAmount], [PaymentMethod], [PaymentDate]) VALUES (5, 7, CAST(189.99 AS Decimal(7, 2)), 0, N'2024-10-13 19:40:38')
INSERT INTO [dbo].[Payment] ([PaymentId], [OrderId], [PaymentAmount], [PaymentMethod], [PaymentDate]) VALUES (6, 8, CAST(14.99 AS Decimal(7, 2)), 2, N'2024-10-13 19:40:47')
INSERT INTO [dbo].[Payment] ([PaymentId], [OrderId], [PaymentAmount], [PaymentMethod], [PaymentDate]) VALUES (7, 10, CAST(99.99 AS Decimal(7, 2)), 1, N'2024-10-13 19:41:01')
SET IDENTITY_INSERT [dbo].[Payment] OFF

SET IDENTITY_INSERT [dbo].[Order] ON
INSERT INTO [dbo].[Order] ([OrderId], [FullName], [OrderDate]) VALUES (1, N'Ahmad Mahmoud', N'2024-10-13 13:14:57')
INSERT INTO [dbo].[Order] ([OrderId], [FullName], [OrderDate]) VALUES (2, N'John Doe', N'2024-10-13 19:37:29')
INSERT INTO [dbo].[Order] ([OrderId], [FullName], [OrderDate]) VALUES (3, N'Jane Smith', N'2024-10-13 19:37:36')
INSERT INTO [dbo].[Order] ([OrderId], [FullName], [OrderDate]) VALUES (4, N'Liam Beckham', N'2024-10-13 19:37:56')
INSERT INTO [dbo].[Order] ([OrderId], [FullName], [OrderDate]) VALUES (5, N'Anna Doe', N'2024-10-13 19:38:11')
INSERT INTO [dbo].[Order] ([OrderId], [FullName], [OrderDate]) VALUES (6, N'Olivia Johnson', N'2024-10-13 19:39:22')
INSERT INTO [dbo].[Order] ([OrderId], [FullName], [OrderDate]) VALUES (7, N'Isabella Garcia', N'2024-10-13 19:39:32')
INSERT INTO [dbo].[Order] ([OrderId], [FullName], [OrderDate]) VALUES (8, N'William Wilson', N'2024-10-13 19:39:41')
INSERT INTO [dbo].[Order] ([OrderId], [FullName], [OrderDate]) VALUES (9, N'James Taylor', N'2024-10-13 19:39:50')
INSERT INTO [dbo].[Order] ([OrderId], [FullName], [OrderDate]) VALUES (10, N'Lucas White', N'2024-10-13 19:39:56')
INSERT INTO [dbo].[Order] ([OrderId], [FullName], [OrderDate]) VALUES (11, N'Alexander Clark', N'2024-10-13 19:40:06')
INSERT INTO [dbo].[Order] ([OrderId], [FullName], [OrderDate]) VALUES (12, N'Grace Walker', N'2024-10-13 19:40:19')
SET IDENTITY_INSERT [dbo].[Order] OFF

SET IDENTITY_INSERT [dbo].[Category] ON
INSERT INTO [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (1, N'Small')
INSERT INTO [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (3, N'Medium')
INSERT INTO [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (4, N'Large')
SET IDENTITY_INSERT [dbo].[Category] OFF

SET IDENTITY_INSERT [dbo].[Cart] ON
INSERT INTO [dbo].[Cart] ([CartId], [Order_Id], [FullName], [quantity]) VALUES (1, 1, N'Ahmad', 2)
INSERT INTO [dbo].[Cart] ([CartId], [Order_Id], [FullName], [quantity]) VALUES (2, 4, N'Liam Beckham', 3)
INSERT INTO [dbo].[Cart] ([CartId], [Order_Id], [FullName], [quantity]) VALUES (3, 12, N'Walker', 2)
INSERT INTO [dbo].[Cart] ([CartId], [Order_Id], [FullName], [quantity]) VALUES (4, 5, N'Anna Doe', 6)
INSERT INTO [dbo].[Cart] ([CartId], [Order_Id], [FullName], [quantity]) VALUES (5, 10, N'Lucas W', 6)
INSERT INTO [dbo].[Cart] ([CartId], [Order_Id], [FullName], [quantity]) VALUES (6, 6, N'Olivia', 1)
INSERT INTO [dbo].[Cart] ([CartId], [Order_Id], [FullName], [quantity]) VALUES (7, 11, N'Alex Clark', 4)
SET IDENTITY_INSERT [dbo].[Cart] OFF

INSERT INTO [dbo].[AspNetUsers] ([Id], [CustomerId], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'1', 0, N'Ahmad', N'Mahmoud', N'admin@abstraxartstore.com', N'ADMIN@ABSTRAXARTSTORE.COM', N'admin@example.com', N'ADMIN@EXAMPLE.COM', 1, N'AQAAAAIAAYagAAAAEH9UY2wYhWZmfY8HlTIy7FbnfotKrcFz+QOWINJtd+zZcHpFcE7M3qjFSBoYYyZD2g==', N'cae46cd4-89e8-425e-8270-0485b594db3b', N'b95ac998-b7cd-409f-ad13-c30325e8f47d', NULL, 0, 0, NULL, 0, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [CustomerId], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'247294a4-ff5c-49fb-a434-dc73e39023f1', 0, N'John', N'Doe', N'Johndoe@gmail.com', N'JOHNDOE@GMAIL.COM', N'Johndoe@gmail.com', N'JOHNDOE@GMAIL.COM', 0, N'AQAAAAIAAYagAAAAEAw84Q6EjZ0s1jciAhMTWM7tkF/zNrKxxWIFcX0hgqv7+221/1uDceMSir05fLWlWg==', N'VF4ULM7N6B4E6NQHCY2ZQUW4726FCKWN', N'af2d927c-4b31-4655-9b1b-37aba129b903', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [CustomerId], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'7d5e8adb-2162-45d3-bdd6-4042fbfeb7a3', 0, N'William', N'Wilson', N'Williamwilson@hotmail.com', N'WILLIAMWILSON@HOTMAIL.COM', N'Williamwilson@hotmail.com', N'WILLIAMWILSON@HOTMAIL.COM', 0, N'AQAAAAIAAYagAAAAECeV/Qibnupt0NkoEOSAzVeNOL5sVPF0X1wB7HgavSOLcYxsO51CLw/v99Qa9+Sytw==', N'5BQZ6DU7CKVBEB5B5QF4WQOG26WHDSCZ', N'ee9241e8-94db-4372-9277-b7ba58f8d9f7', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [CustomerId], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'a8038548-bd39-4df3-a698-e02aaee69af9', 0, N'Anna ', N'Smith', N'Annasmith@gmail.com', N'ANNASMITH@GMAIL.COM', N'Annasmith@gmail.com', N'ANNASMITH@GMAIL.COM', 0, N'AQAAAAIAAYagAAAAEKdDgyOq+IG/AwUX5pd6HR7hM2OwNEjXn3LCafh6ofzazbz4dTt2x55UwUohs/wlKA==', N'RFTGABNFDFPT6KFCSHHITSRLMOTCPT6C', N'b4654a2a-6be4-4d16-8b65-8ce795f918a0', NULL, 0, 0, NULL, 1, 0)

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1', N'1')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7d5e8adb-2162-45d3-bdd6-4042fbfeb7a3', N'1')