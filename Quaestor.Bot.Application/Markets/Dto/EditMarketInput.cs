﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quaestor.Bot.Markets.Dto
{
    [AutoMapTo(typeof(Market))]
    public class EditMarketInput:EntityDto
    {
        public int Id { get; set; }
        public int ExchangeId { get; set; }
        public string Name { get; set; }
    }
}
