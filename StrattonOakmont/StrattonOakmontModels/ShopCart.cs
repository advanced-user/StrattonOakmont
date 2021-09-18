using System;
using System.Collections.Generic;
using System.Text;

namespace StrattonOakmontModels
{
    class ShopCart
    {
        
        public List<ShopCartItem> shopCartItems { get; set; }
        public string ShopCartId { get; set; }
        public List<ShopCartItem> listShopItems { get; set; }
        //public static ShopCart GetCart(IServiceProvider services)
        //{
        //    ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
        //    var context = services.GetService<ApplicationContext>();
        //    string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
        //    session.SetString("CartId", shopCartId);
        //    return new ShopCart(context) { ShopCartId = shopCartId };
        //}
        //public void AddToCart(Album album)
        //{
        //    appDBContent.ShopCartItem.Add(new ShopCartItem
        //    {
        //        ShopCartId = ShopCartId,
        //        album = album,
        //        price = album.Price
        //    });
        //    appDBContent.SaveChanges();
        //}
        
    }
}
