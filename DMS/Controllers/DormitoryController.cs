using DMS.Core.Exceptions;
using DMS.Core.Objects.Dormitory;
using DMS.Core.Objects.ServiceInterfaces;
using DMS.Data.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DMS.Controllers;

[ApiController]
[Route("/api/stats")]
[Authorize]
public class DormitoryController : DmsControllerBase
{
    private readonly IDormitoryService _service;
    private readonly IResidentService _residentService;

    public DormitoryController(IDormitoryService service,
        IResidentService residentService)
    {
        _service = service;
        _residentService = residentService;
    }

    [HttpGet]
    public IResult GetDormitoryCapacity()
    {
        return Results.Ok(_service.GetDormitorySettlementData());
    }

    [HttpGet]
    [Route("/api/stats/resettlement")]
    public IResult GetResettlementLists()
    {
        var residents = _service.GetResettlementList();

        return Results.Ok(residents);
    }

    // [HttpPost]
    // [Route("/api/stats/accruals")]
    // public IResult AccrualAllResidents()
    // {
    //     try
    //     {
    //         var commercialCost = -1 * int.Parse(_service.GetConstant(
    //             "CommercialCost"));
    //         var nonCommercialCost = -1 * int.Parse(_service.GetConstant(
    //             "NonCommercialCost"));
    //
    //         _residentService.AccrualAll(commercialCost, nonCommercialCost);
    //         return Results.Ok("Transactions complete");
    //     }
    //     catch (FormatException)
    //     {
    //         return Results.BadRequest(
    //             "Dormitory constants not set or have bad value");
    //     }
    //     catch (DbUpdateException e)
    //     {
    //         return Results.Conflict(e.Message);
    //     }
    // }

    [HttpGet]
    [Route("/api/stats/constants")]
    public IResult GetConstants()
    {
        return Results.Ok(_service.GetConstants());
    }

    // [HttpGet]
    // [Route("/api/stats/constants/{name}")]
    // public IResult GetConstant(string name)
    // {
    //     return Results.Ok(_service.GetConstant(name));
    // }

    // [HttpPost]
    // [Route("/api/stats/constants")]
    // public async Task<IResult> SetConstants()
    // {
    //     try
    //     {
    //         var data = await ParseRequestBody();
    //         var res = _service.SetSafeConstants(data);
    //         
    //         return Results.Ok(
    //             "Setting completed." + res == ""
    //                 ? ""
    //                 : $"The following keys were not added: {res}");
    //     }
    //     catch (InvalidRequestDataException e)
    //     {
    //         return Results.BadRequest(e.Message);
    //     }
    //     catch (Exception e)
    //     {
    //         return Results.Conflict(e.Message);
    //     }
    // }

    // [HttpPost]
    // [Route("/api/stats/reset")]
    // public async Task<IResult> ResetDormitory()
    // {
    //     try
    //     {
    //         var data = await ParseRequestBody();
    //
    //         _service.SetHardResetConstants(data);
    //         _residentService.ResetAll();
    //         _service.ResetDormitoryResidentsAndRooms();
    //
    //         return Results.Ok("Reset complete");
    //     }
    //     catch (InvalidRequestDataException e)
    //     {
    //         return Results.BadRequest(e.Message);
    //     }
    //     catch (Exception e)
    //     {
    //         return Results.Conflict(e.Message);
    //     }
    // }
}