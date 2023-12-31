﻿using CodeMazeShop.DataContracts.ProductCatalog;

namespace CodeMazeShop.WebClient.Models;

public class ProductListModel
{
    public IEnumerable<Product>? Products { get; set; }

    public Guid SelectedCategory { get; set; }
    
    public IEnumerable<Category> Categories { get; set; }
    
    public int NumberOfItems { get; set; }
}