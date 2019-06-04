﻿#region Author Information
// LoggerExtensions.cs
// 
// (c) 2016 Apexol Technologies. All Rights Reserved.
// 
#endregion

using System;
using EvenCart.Data.Entity.Users;
using EvenCart.Data.Enum;
using EvenCart.Services.Logger;

namespace EvenCart.Services.Extensions
{
    public static class LoggerExtensions
    {
        public static void LogTrace<T>(this ILogger logger, Exception ex, string message, User user = null, params object[] parameters)
        {
            logger.Log<T>(LogLevel.Trace, string.Format(message, parameters), ex, user);
        }

        public static void LogInfo<T>(this ILogger logger, Exception ex, string message, User user = null, params object[] parameters)
        {
            logger.Log<T>(LogLevel.Information, string.Format(message, parameters), ex, user);
        }

        public static void LogWarning<T>(this ILogger logger, Exception ex, string message, User user = null, params object[] parameters)
        {
            logger.Log<T>(LogLevel.Warning, string.Format(message, parameters), ex, user);
        }

        public static void LogError<T>(this ILogger logger, Exception ex, string message, User user = null, params object[] parameters)
        {
            logger.Log<T>(LogLevel.Error, string.Format(message, parameters), ex, user);
        }

        public static void LogFatal<T>(this ILogger logger, Exception ex, string message, User user = null, params object[] parameters)
        {
            logger.Log<T>(LogLevel.Fatal, string.Format(message, parameters), ex, user);
        }

        public static void LogDebug<T>(this ILogger logger, Exception ex, string message, User user = null, params object[] parameters)
        {
            logger.Log<T>(LogLevel.Debug, string.Format(message, parameters), ex, user);
        }
    }
}