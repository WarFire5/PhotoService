﻿using PhotoService.DAL.DTO;

namespace PhotoService.BLL.Models.OutputModels;

public class UsersOutputModel
{
    public int Id { get; set; }
    public RolesDto Role { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public string Mail { get; set; }
    public string? Phone { get; set; }
    public TypesDto? Specialization { get; set; }
    public int TypeSpecialization { get; set; }
    public string? Dossier { get; set; }
    public int? Rating { get; set; }
    public bool IsBlocked { get; set; }
    public bool IsDeleted { get; set; }    
    public string? URL { get; set; }
    public string? ExecutorType { get; set; }
    public string? CompanyTitle { get; set; }
    public string? INN { get; set; }
    public string? OGRN { get; set; }
    public bool IsDenied { get; set; }
    public string? ReasonDenied { get; set; }
}