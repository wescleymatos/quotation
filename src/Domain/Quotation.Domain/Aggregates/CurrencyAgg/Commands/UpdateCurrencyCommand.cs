﻿using Quotation.Domain.Seedwork;
using System;

namespace Quotation.Domain.Aggregates.CurrencyAgg.Commands {
    public class UpdateCurrencyCommand : Command<CommandResult<Currency>> {

        public string Name { get; set; }
        public string CurrencyIso { get; set; }
        
    }
}
