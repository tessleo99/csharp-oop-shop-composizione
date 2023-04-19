using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composizione_Shop
{
    public class Shop
    {
        //ATTRUBUTI
        private string shopName;
        private string shopCity;
        private string addressShop;
        private int numberAddressShop;
        private List<Product> products; 
       
        //COSTRUTTORE
        public Shop(string shopName, string shopCity, string addressShop, int numberAddressShop)
        {
            this.shopName = shopName;
            this.shopCity = shopCity;
            this.addressShop = addressShop;
            this.numberAddressShop = numberAddressShop;
            this.products = new List<Product>();
        }

        //GETTERS
        public string GetShopName()
        {
            return shopName;
        }

        public string GetShopCity()
        {
            return shopCity;
        }

        public string GetAddressShop()
        {
            return addressShop;
        }

        public int GetNumberAddressShop()
        {
            return numberAddressShop;
        }

        public List<Product> GetListProduct()
        {
            return this.products;
        }
        //SETTERS
        public void SetAddressShop(string addressShop)
        {
            this.addressShop = addressShop;
        }

        public void SetNumberAddresShop(int numberAddresShop)
        {
            this.numberAddressShop = numberAddresShop;
        }

        //METODI

        //INSERISCO UN SINGOLO PRODOTTO
        public void AddProduct(Product newProduct)
        {
            this.products.Add(newProduct);
        }

        //INSERISCO UNA LISTA DI PRODOTTI
        public void AddListProduct(List<Product> newListProducts)
        {
            foreach (Product newProducts in newListProducts) 
            {
                 this.products.Add(newProducts);
            }
        }

        //STAMPIAMO IN CONSOLE


    }
}
