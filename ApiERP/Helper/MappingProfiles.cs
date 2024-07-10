﻿using AutoMapper;
using DAL.Dtos;
using DAL.Models;

namespace ApiERP.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<HrEmployeeDto, HrEmployee>();
            CreateMap<CalAccountChartDto,CalAccountChart>();
            CreateMap<CalCostCenterDto, CalCostCenter>();
            CreateMap<CalCostCenter, CalCostCenterDto>();
            CreateMap<SysAnalyticalCodeDto, SysAnalyticalCode>();
            CreateMap<SysAnalyticalCode, SysAnalyticalCodeDto>();
            CreateMap<MsItemUnitDto, MsItemUnit>();
            CreateMap<MsItemUnit,MsItemUnitDto>();
            CreateMap<MsItemcardDto,MsItemCard>();

        }
    }
}
