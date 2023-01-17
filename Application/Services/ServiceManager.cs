﻿using Application.Interfaces.Common;
using Application.Interfaces.DataShaping;
using Application.Interfaces.Repository;
using Application.Interfaces.Services;
using Application.Interfaces.Utility;
using AutoMapper;
using Domain.ConfigurationModels;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Shared.DataTransferObjects;

namespace Application.Services;
public class ServiceManager : IServiceManager
{
    private readonly Lazy<ICompanyService> _companyService;
    private readonly Lazy<IEmployeeService> _employeeService;
    private readonly Lazy<IAuthenticationService> _authenticationService;

    public ServiceManager(IRepositoryManager repository, ILoggerManager logger, IMapper mapper, IEmployeeLinks employeeLinks, UserManager<User> userManager, IOptions<JwtConfiguration> configuration)
    {
        _companyService = new Lazy<ICompanyService>(() => new CompanyService(repository, logger, mapper));
        _employeeService = new Lazy<IEmployeeService>(() => new EmployeeService(repository, logger, mapper, employeeLinks));
        _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(logger, mapper, userManager, configuration));
    }
    public ICompanyService CompanyService => _companyService.Value;
    public IEmployeeService EmployeeService => _employeeService.Value;

    public IAuthenticationService AuthenticationService => _authenticationService.Value;
}
