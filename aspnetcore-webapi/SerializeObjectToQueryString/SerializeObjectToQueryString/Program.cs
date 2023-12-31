﻿using SerializeObjectToQueryString;

const string baseApiUrl = "https://test.com";

Console.WriteLine("\n***************** Serialize the object to query string using reflection ***************\n");
Console.WriteLine(QueryStringSerializer.CreateURLWithBookAsQueryParamsUsingReflection(baseApiUrl, new Book()));

Console.WriteLine("\n***************** Serialize the object to query string using Newtonsoft Json ***************\n");
Console.WriteLine(QueryStringSerializer.CreateURLWithBookAsQueryParamsUsingNewtonsoftJson(baseApiUrl, new Book()));

Console.WriteLine("\n***************** Serialize the nested object to query string ***************\n");
Console.WriteLine(QueryStringSerializer.CreateURLWithProductAsQueryParams(baseApiUrl, new Product()));

Console.WriteLine(
    "\n***************** Serialize the object that contains array and nested objects property to query string ***************\n");
Console.WriteLine(QueryStringSerializer.CreateURLWithPersonAsQueryParams(baseApiUrl, new Person()));