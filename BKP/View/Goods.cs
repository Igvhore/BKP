using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKP.View
{
    public class Goods
    {
        public Goods() { }
        public Goods(int id, string name, string brand, string article, int amount, string status)
        {
            good_id = id;
            good_name = name;
            good_brand = brand;
            good_article = article;
            good_amount = amount;
            good_status = status;
            stock = good_amount > 0;

        }
        public Goods(int id, string name, string brand, string article, int amount)
        {
            good_id = id;
            good_name = name;
            good_brand = brand;
            good_article = article;
            good_amount = amount;

        }

        public Goods(int id, string name, string brand, int reserve_number)
        {
            good_id = id;
            good_name = name;
            good_brand = brand;
            good_reserve = reserve_number;

        }

        public int good_id { get; set; }
        public string good_name { get; set; }
        public string good_brand { get; set; }
        public string good_article { get; set; }
        public int good_amount { get; set; }
        public string good_status { get; set; }
        public bool stock {get; set;}
        public int good_reserve { get; set; }

    }
}
