SET IDENTITY_INSERT [dbo].[Users] ON
INSERT INTO [dbo].[Users] ([Id], [Ime], [Prezime], [Korisnicki_Id], [Lozinka], [JMBG], [Mail_Adresa], [Broj_Telefona], [Adresa], [Broj_Racuna], [Stanje_Na_Racunu]) VALUES (1, N'Petar', N'Petrovic', N'perke00', N'lm1154', 1906040737288, N'peric00@gmail.com', N'0615234651', N'Takovska 10', 5894645612302541, CAST(45650.000 AS Decimal(18, 3)))
SET IDENTITY_INSERT [dbo].[Users] OFF
