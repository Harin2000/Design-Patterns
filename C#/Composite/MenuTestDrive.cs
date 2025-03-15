﻿using Composite.Menus;

namespace Composite
{
    internal class MenuTestDrive
    {
        static void Main(string[] args)
        {
            var pcHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();
            var waitress = new Waitress(pcHouseMenu, dinerMenu);
            waitress.PrintMenu();
        }
    }
}
