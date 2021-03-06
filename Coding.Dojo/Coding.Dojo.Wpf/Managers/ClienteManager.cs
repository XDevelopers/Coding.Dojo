﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Coding.Dojo.Wpf.Managers
{
    public class ClienteManager //<T> where T : class
    {
        public T Deserialize<T>(string json)
        {
            T obj = Activator.CreateInstance<T>();

            if (string.IsNullOrWhiteSpace(json))
                return obj;

            var format = "dd/MM/yyyy"; // your datetime format
            var dateTimeConverter = new IsoDateTimeConverter { DateTimeFormat = format };

            return JsonConvert.DeserializeObject<T>(json, dateTimeConverter);
        }
    }
}