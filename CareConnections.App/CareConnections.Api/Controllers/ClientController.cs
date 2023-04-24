﻿using CareConnections.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace CareConnections.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly IClientRepository _clientRepository;

        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpGet]
        public IActionResult GetAllClients()
        {
            return Ok(_clientRepository.GetAllClients());
        }

        [HttpGet("{id}")]
        public IActionResult GetClientById(string id)
        {
            return Ok(_clientRepository.GetClientById(id));
        }
    }
}
