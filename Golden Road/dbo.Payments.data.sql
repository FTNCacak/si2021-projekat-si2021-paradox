
SET IDENTITY_INSERT [dbo].[Payments] ON
INSERT INTO [dbo].[Payments] ([Id], [Naziv], [Broj_Racuna_Primaoca], [Model], [Poziv_Na_Broj], [Iznos], [Svrha_Uplate], [Datum], [Broj_Racuna_Uplatioca]) VALUES (1, N'Ana Jevic', 840111222555745145, 97, 45612378, CAST(5000.00 AS Decimal(18, 2)), N'Pozajmica', N'2021-10-12', 840222111365421478)
INSERT INTO [dbo].[Payments] ([Id], [Naziv], [Broj_Racuna_Primaoca], [Model], [Poziv_Na_Broj], [Iznos], [Svrha_Uplate], [Datum], [Broj_Racuna_Uplatioca]) VALUES (2, N'Veljko Loncarevic', 840546852347154968, 97, 54722358, CAST(2000.00 AS Decimal(18, 2)), N'Izrada ispita', N'2021-07-15', 840111222441236547)
INSERT INTO [dbo].[Payments] ([Id], [Naziv], [Broj_Racuna_Primaoca], [Model], [Poziv_Na_Broj], [Iznos], [Svrha_Uplate], [Datum], [Broj_Racuna_Uplatioca]) VALUES (3, N'FTN Cacak', 840123321452165785, 97, 74512352, CAST(700.00 AS Decimal(18, 2)), N'Prijava ispita', N'2022-01-15', 840555456987145236)
SET IDENTITY_INSERT [dbo].[Payments] OFF

