﻿using System.Collections.Generic;
using System.Linq;

namespace StoreBagSystem
{
    public class HighestVacancyRateSelector : ICabinetSelector
    {
        private readonly IList<Cabinet> cabinets;

        public HighestVacancyRateSelector(IList<Cabinet> cabinets)
        {
            this.cabinets = cabinets;
        }

        public Cabinet SelectCabinet()
        {
            return cabinets.OrderByDescending(cabinet => cabinet.VacancyRate()).First();
        }

        public string GetName()
        {
            return "Super";
        }
    }
}
