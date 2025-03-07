﻿using Serenity.Demo.Northwind;
using Serenity.Data;
using Serenity.Navigation;
using System.Collections.Generic;
using System;

namespace Serenity.Demo.BasicSamples
{
    public class DynamicNavigationSample : INavigationItemSource
    {
        public DynamicNavigationSample(ISqlConnections sqlConnections)
        {
            SqlConnections = sqlConnections ?? 
                throw new ArgumentNullException(nameof(sqlConnections));
        }

        public ISqlConnections SqlConnections { get; }

        public List<NavigationItemAttribute> GetItems()
        {
            var items = new List<NavigationItemAttribute>
            {
                new NavigationMenuAttribute(7970, "Basic Samples/Dynamic Navigation")
            };

            // Add product categories as dynamic navigation items for demo purpose
            using (var connection = SqlConnections.NewByKey("Northwind"))
            {
                var categories = connection.List<CategoryRow>();
                foreach (var category in categories)
                    items.Add(new NavigationLinkAttribute(7970,
                        path: "Basic Samples/Dynamic Navigation/" + 
                            category.CategoryName.Replace("/", "//", StringComparison.Ordinal),
                        url: "~/Northwind/Product?cat=" + category.CategoryID,
                        permission: Northwind.PermissionKeys.General,
                        icon: "icon-folder-alt"));
            }

            return items;
        }
    }
}