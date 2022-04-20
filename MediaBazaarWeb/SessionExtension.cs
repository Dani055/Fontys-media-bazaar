using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using MBazaarClassLibrary.models;
using Microsoft.AspNetCore.Http;

namespace MediaBazaarWeb
{
    public static class SessionExtension
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T GetObject<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonSerializer.Deserialize<T>(value);
        }
        public static Employee GetLoggedEmp(this ISession session)
        {
            return session.GetObject<Employee>("loggedEmp");
        }

    }
}
