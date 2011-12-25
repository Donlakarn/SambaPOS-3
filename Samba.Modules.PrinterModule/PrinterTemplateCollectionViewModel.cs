﻿using Samba.Domain.Models.Settings;
using Samba.Localization.Properties;
using Samba.Persistance.Data;
using Samba.Presentation.Common.ModelBase;

namespace Samba.Modules.PrinterModule
{
    public class PrinterTemplateCollectionViewModel : EntityCollectionViewModelBase<PrinterTemplateViewModel, PrinterTemplate>
    {
        protected override string CanDeleteItem(PrinterTemplate model)
        {
            var count = Dao.Count<PrinterMap>(x => x.PrinterTemplate.Id == model.Id);
            if (count > 0) return Resources.DeleteErrorTemplateUsedInPrintJob;
            return base.CanDeleteItem(model);
        }
    }
}