using Challenge_1_Take_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Challenge_1_Tests
{ 
    [TestClass]
    public class MenuRepositoryTests
    {
        private MenuRepository _repo;
        private Menu _menu;

        [TestInitialize]

        public void Arrange()
        {
            _repo = new MenuRepository();
            _menu = new Menu(1, "Steak & Eggs", "Medium Rare Steak Served with Eggs Sunny Side Up.", "Steak, Eggs", 12.50);

            _repo.AddFoodToMenu(_menu);
        }


        //Add Method
        [TestMethod]
        public void AddToMenu_ShouldGetNotNull()
        {
            Menu menu = new Menu();
            menu.Name = "Steak & Eggs";
            MenuRepository repository = new MenuRepository();

            repository.AddFoodToMenu(menu);
            Menu foodFromMenu = repository.GetFoodByName("Steak & Eggs");

            Assert.IsNotNull(foodFromMenu);
        }

        //Update
        [TestMethod]
        public void UpdateExistingFood_ShouldReturnTrue()
        {
            //Arrange
            //Initialize
            Menu newmenu = new Menu(1, "Steak & Eggs", "Medium Rare Steak Served with Eggs Sunny Side Up.", "Steak, Eggs", 12.50);

            //Act
            bool updateResult = _repo.UpdateExistingFood("Steak & Eggs", newmenu)

            //Assert
            Assert.IsTrue(updateResult);
        }

        [TestMethod]
        public void MyTestMethod()
        {

        }
    }
}
