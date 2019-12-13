using I.C.E.Enums.Security;
using I.C.E.Messages.Security;
using I.C.E.Models.Security;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using MenuItem = I.C.E.Models.Security.MenuItem;

namespace I.C.E.Services.Interfaces
{
    public class SecurityService : ISecurityService
    {
        private IEventAggregator _eventAggregator;
        public IList<MenuItem> _allMenuItems;
        public bool LoggedIn { get; set; }
        public SecurityService(IEventAggregator eventAggregator)
        {
           // CreateMenuItems();
            _eventAggregator = eventAggregator;
        }

        public SecurityService()
        {
        }

        public IList<MenuItem> GetAllowedAccessItems()
        {
            if (LoggedIn)
            {
                var accessItems = new List<MenuItem>();
                foreach (var item in _allMenuItems)
                {
                    if (item.MenuType == MenuTypeEnum.Secured || item.MenuType == MenuTypeEnum.UnSecured || item.MenuType == MenuTypeEnum.LogOut)
                    {
                        accessItems.Add(item);
                    }
                }
                return accessItems.OrderBy(x => x.MenuOrder).ToList();
            }
            else
            {
                var accessItems = new List<MenuItem>();
                foreach (var item in _allMenuItems)
                {
                    if (item.MenuType == MenuTypeEnum.UnSecured || item.MenuType == MenuTypeEnum.Login)
                    {
                        accessItems.Add(item);
                    }
                }
                return accessItems.OrderBy(x => x.MenuOrder).ToList();
            }
        }
        public bool LogIn(string userName, string password)
        {
            // Do Your Stuff to Check if Legit (ie API Calls)
            LoggedIn = true;
            return true;
        }
        public void LogOut()
        {
            LoggedIn = false;
            _eventAggregator.GetEvent<LogOutMessage>().Publish();
        }
    }
}
