﻿using PowerSwitcher.TrayApp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerSwitcher.TrayApp.Configuration
{
    [Serializable]
    public class PowerSwitcherSettings : ObservableObject
    {
        //I know that everything should be observable but it's not neccessary so let's leave it as it is for now

        public bool AutomaticFlyoutHideAfterClick { get; set; } = true;
        public bool AutomaticOnACSwitch { get; set; } = false;
        public Guid AutomaticPlanGuidOnAC { get; set; } = new Guid("8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c");
        public Guid AutomaticPlanGuidOffAC { get; set; } = new Guid("a1841308-3541-4fab-bc81-f71556f20b4a");

        bool showOnlyDefaultSchemas = false;
        public bool ShowOnlyDefaultSchemas { get { return showOnlyDefaultSchemas; } set { showOnlyDefaultSchemas = value; RaisePropertyChangedEvent(nameof(ShowOnlyDefaultSchemas)); } }

    }
}