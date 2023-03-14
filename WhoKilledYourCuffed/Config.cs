using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace WhoKilledYourCuffed
{
    public class Config : IConfig
    {
        [Description("Sets the plugin enabled or not")]
        public bool IsEnabled { get; set; } = true;

        [Description("No need to touch this :3")]
        public bool Debug { get; set; } = false;
    }
}
