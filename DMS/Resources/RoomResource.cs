﻿using DMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DMS.Resources;

public class RoomResource
{
    private readonly ApplicationContext _context;

    public RoomResource(ApplicationContext context)
    {
        _context = context;
    }

    public Room? GetRoomById(int id)
    {
        var room = _context.Rooms.FirstOrDefault(r => r.RoomId == id);
        var roomResidents = _context.Residents.Where(r => r.RoomId == id);
        roomResidents.Load();
        foreach (var resident in roomResidents.ToArray())
        {
            _context.Transactions.Where(t => t.ResidentId == resident.ResidentId).Load();
            _context.RatingOperations.Where(t => t.ResidentId == resident.ResidentId).Load();
            _context.RatingChangeCategories.Load();
        }
        return room;
    }

    public IEnumerable<int> GetFloorsCount()
    {
        return _context.Rooms.Select(r => r.FloorNumber).Distinct();
    }

    public IEnumerable<Room> GetAllRoomsOnFloor(int roomNumber)
    {
        return _context.Rooms.Where(r => r.FloorNumber == roomNumber);
    }

    public IEnumerable<Room> GetAllRooms()
    {
        return _context.Rooms;
    }
}