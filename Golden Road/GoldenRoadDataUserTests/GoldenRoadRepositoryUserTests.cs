using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shared.Models;
using DataLayer;
using System.Linq;

namespace GoldenRoadDataTests
{
    [TestClass]
    public class GoldenRoadRepositoryUserTests
    {
        public User user;
        public Payment payment;
        public GoldenRoadRepository goldenRoadRepository;

        [TestInitialize]
        public void init()
        {
            user = new User
            {
                Ime = "Petar",
                Prezime = "Petrovic",
                Korisnicki_Id = "perke00",
                Lozinka = "lm1154",
                JMBG = "1906040737288",
                Mail_Adresa = "peric00@gmail.com",
                Broj_Telefona = "0615234651",
                Adresa = "Takovska 10",
                Broj_Racuna = 5894645612302541,
                Stanje_Na_Racunu = 45650

            };

           
            goldenRoadRepository = new GoldenRoadRepository();

        }

        [TestMethod]
        public void GetAllUsersTest()
        {
            goldenRoadRepository.InsertUser(user);
            Assert.IsNotNull(goldenRoadRepository.GetAllUsers());
        }

        [TestMethod]
        public void UpdateUserTest()
        {
            //Arrange
            goldenRoadRepository.InsertUser(user);
            User newUser = goldenRoadRepository.GetAllUsers().Where(x => x.Ime == user.Ime).ToList()[0];

            //Act
            int result = goldenRoadRepository.UpdateUser(newUser);

            //Assert
            Assert.IsTrue(result > 0);
        }


        [TestMethod]
        public void DeleteUserTest()
        {
            goldenRoadRepository.InsertUser(user);
            User newUser = goldenRoadRepository.GetAllUsers().Where(x => x.Ime == user.Ime).ToList()[0];
            Assert.IsTrue(goldenRoadRepository.DeleteUser(newUser.Id) > 0);
            goldenRoadRepository.InsertUser(user);

        }



        [TestCleanup]
        public void clean()
        {
            User newUser = goldenRoadRepository.GetAllUsers().Where(x => x.Ime == user.Ime).ToList()[0];
            goldenRoadRepository.DeleteUser(newUser.Id);


        }


    }
}
