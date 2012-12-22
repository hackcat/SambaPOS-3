﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samba.Domain.Models.Inventory;
using Samba.Domain.Models.Tickets;

namespace Samba.Persistance.DaoClasses
{
    
    public interface IInventoryDao
    {
        IEnumerable<InventoryTransactionItem> GetTransactionItems(DateTime workperiodStartDate);
        IEnumerable<InventoryTransactionItem> GetTransactionItems(DateTime workPeriodStartDate, InventoryItem inventoryItem);
        IEnumerable<InventoryTransactionData> GetTransactionItems(DateTime workPeriodStartDate, int inventoryItemId, int warehouseId);
        IEnumerable<Order> GetOrdersFromRecipes(DateTime startDate);
        IEnumerable<Order> GetOrdersFromRecipesByInventoryItem(DateTime startDate, InventoryItem inventoryItem);
        IEnumerable<Order> GetOrdersFromRecipesByInventoryItem(DateTime startDate, InventoryItem inventoryItem, Warehouse warehouse);
        Recipe GetRecipe(string portionName, int menuItemId);
        IEnumerable<string> GetGroupCodes();
        IEnumerable<string> GetInventoryItemNames();
        bool RecipeExists();
        IEnumerable<InventoryItem> GetInventoryItems();
        PeriodicConsumption GetPeriodicConsumptionByWorkPeriodId(int workPeriodId);
        PeriodicConsumptionItem GetPeriodConsumptionItem(int workPeriodId, int inventoryItemId, int warehouseId);
    }

    public class InventoryTransactionData
    {
        public InventoryTransactionItem InventoryTransactionItem { get; set; }
        public int SourceWarehouseId { get; set; }
        public int TargetWarehouseId { get; set; }
    }
}
