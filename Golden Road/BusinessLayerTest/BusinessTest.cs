using DataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared.Models;
using System;
using Moq;
using Shared.Interfaces;
using System.Collections.Generic;
using BusinessLayer;

namespace BusinessLayerTest
{
    [TestClass]
    public class BusinessTest
    {
       
        public User user;
        public Payment payment;
        private GoldenRoadBusiness goldenRoad ;

        private Mock<GoldenRoadBusiness> mockRepository = new Mock<GoldenRoadBusiness>();
        private User user1 = new User
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
        private User user2 = new User
        {
           
            Korisnicki_Id = "perke00",
            Lozinka = "lm1154",
         

        };

        private List<User> listOfUsers = new List<User>();
        public GoldenRoadBusiness UserBusiness;


        [TestMethod]
        public void Login() {
            UserBusiness.InsertUser(user2);

            string res = UserBusiness.LogIn(user2.Korisnicki_Id, user2.Lozinka) ;
            string x = "perke00" + "" + "lm1154";
            Assert.AreEqual(res, x);
        }
        [TestMethod]
        public void Stanje()
        {
            UserBusiness.InsertUser(user1);
            decimal v = 500;
            Assert.IsTrue( goldenRoad.Uplata(user1.Stanje_Na_Racunu,v));
        }



    }
}
