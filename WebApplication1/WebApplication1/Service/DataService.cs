using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Service
{
    public class DataService
    {
        public List<Models.Album> LoadAllAlbum()
        {
            List<Models.Album> list = new List<Models.Album>();


            var item = new Models.Album();

            item.image = "https://media2.popsugar-assets.com/files/2016/02/08/898/n/1922398/4c2124bfd07afeca_heart-shaped-pizza-2016.xxxlarge_2x.jpg";
            item.name = "蔡松霖";
            item.number = 1103105329;
            item.link = "課表";
            list.Add(item);

            var item2 = new Models.Album();

            item2.image = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcQ3Bdu409rOMbmEKqHneDWkj-UuKVkM82SFAkDYG6zHNjwpqe-C";
            item2.name = "黃柏翔";
            item2.number = 1103105321;
            item2.link = "課表";
            list.Add(item2);

            var item3 = new Models.Album();

            item3.image = "http://images.vectorhq.com/images/previews/cc6/domo-kun-psd-454972.png";
            item3.name = "謝翔羽";
            item3.number = 1103105313;
            item3.link = "可愛的課表";
            list.Add(item3);

            var item4 = new Models.Album();

            item4.image = "http://www.geeky-gadgets.com/wp-content/uploads/2010/06/android-robot1.jpg";
            item4.name = "蔡承翰";
            item4.number = 1103105312;
            item4.link = "課表";
            list.Add(item4);

            return list;
        }

    }
}