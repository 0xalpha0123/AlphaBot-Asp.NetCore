﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quaestor.Bot.PurchaseOrderRecords.Dto
{
    [AutoMapFrom(typeof(PurchaseOrderRecordDto))]
    public  class PurchaseOrderRecordDto:EntityDto<int>
    {
        public decimal? FirstBuyWith { get; set; }
        public decimal FirstBuyRate { get; set; }
        public decimal? FirstBuyValue { get; set; }
        public int UserSessionDetailId { get; set; }
        public long OrderId { get; set; }
        public string MarketName { get; set; }               
        public List<PurchaseOrderRecordDetail> PurchaseOrderRecordDetail { get; set; }
    }
}
