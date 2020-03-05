using System;
using System.Collections.Generic;
using System.Text;

namespace Nekretnine.Mobile.Models
{
    public enum MenuItemType
    {
        Nekretnine,
        Poruke,
        UpitZaSastanak,
        MojeNekretnine,
        Odjava
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
