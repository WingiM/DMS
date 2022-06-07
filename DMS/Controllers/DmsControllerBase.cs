﻿using System.Globalization;
using DMS.Core.Exceptions;
using DMS.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Controllers;

public abstract class DmsControllerBase : ControllerBase
{
    private static readonly DateTime DefaultDocumentStartDate =
        DateTime.Now.Month >= 9
            ? new DateTime(DateTime.Now.Year, 9, 1)
            : new DateTime(DateTime.Now.Year - 1, 9, 1);

    protected static DateTime ParseDate(string date)
    {
        DateTime.TryParseExact(date, "d", null, DateTimeStyles.None,
            out var result);
        return (result == DateTime.MinValue ? DefaultDocumentStartDate : result)
            .ToUniversalTime().Date;
    }

    protected async Task<string> ParseRequestBody()
    {
        using StreamReader reader = new StreamReader(Request.Body);
        try
        {
            return await reader.ReadToEndAsync();
        }
        catch (ArgumentOutOfRangeException e)
        {
            throw new InvalidRequestDataException("Could not read request body", e);
        }
    }
}