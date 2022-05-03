﻿using System.Collections;
using DMS.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace DMS.Resources;

public class ResidentResource
{
    private readonly ApplicationContext _context;
    private readonly ILogger<ResidentResource> _logger;

    public ResidentResource(ApplicationContext context,
        ILogger<ResidentResource> logger)
    {
        _context = context;
        _logger = logger;
    }

    public IEnumerable<Resident> GetAllResidents()
    {
        return _context.Residents
            .Include(r => r.Transactions)
            .Include(r => r.RatingOperations)
            .AsSplitQuery();
    }

    public Resident? GetResidentById(int id)
    {
        return _context.Residents
            .Include(r => r.Transactions)
            .Include(r => r.RatingOperations)
            .Include(r => r.Room)
            .AsSplitQuery()
            .FirstOrDefault(res => res.ResidentId == id);
    }

    public Tuple<bool, string?> AddResident(Resident resident)
    {
        string? errorMessage;
        try
        {
            _context.Residents.Add(resident);
            _context.SaveChanges();
            return new Tuple<bool, string?>(true, null);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Information,
                "Failed to insert resident:\n " + e);
            errorMessage = GetErrorMessage(e);
            _logger.Log(LogLevel.Information, errorMessage);
        }

        return new Tuple<bool, string?>(false, errorMessage);
    }

    public Tuple<bool, string?> UpdateResident(Resident resident)
    {
        string? errorMessage;
        try
        {
            _context.Residents.Update(resident);
            _context.SaveChanges();
            return new Tuple<bool, string?>(true, null);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Information,
                "Failed to update resident\n " + e);
            errorMessage = GetErrorMessage(e);
        }

        return new Tuple<bool, string?>(false, errorMessage);
    }

    private string GetErrorMessage(Exception e)
    {
        switch (e.InnerException)
        {
            case PostgresException pe:
                return pe.MessageText;
            case InvalidCastException ice:
                return ice.Message;
            default:
                return "Unknown error";
        }
    }

    public bool DeleteResident(int id)
    {
        var resident =
            _context.Residents.FirstOrDefault(r => r.ResidentId == id);

        if (resident is null)
            return false;
        _context.Residents.Remove(resident);
        _context.SaveChanges();
        return true;
    }
}