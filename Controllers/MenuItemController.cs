using MenuItemListing.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        [HttpGet]
        public List<MenuItem> GetItem()
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {   new MenuItem() {Id=1, Name="Ferrari", Active=false, DateOfLaunch=new DateTime(2022,06,09), freeDelivery=false,Price=500000},
                new MenuItem() {Id=2, Name="BMW", Active=true, DateOfLaunch=new DateTime(2022,10,03), freeDelivery=false,Price=600000}
                
            };
            return MenuList;
        }

        [HttpGet("{id}")]
        public MenuItem GetItemById(int id)
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {   new MenuItem() {Id=1, Name="Ferrari", Active=false, DateOfLaunch=new DateTime(2022,06,09), freeDelivery=false,Price=500000},
                new MenuItem() {Id=2, Name="BMW", Active=true, DateOfLaunch=new DateTime(2022,10,03), freeDelivery=false,Price=600000}

            };
            MenuItem obj = MenuList.SingleOrDefault(item => item.Id == id);
            return obj;

        }
    }
}
