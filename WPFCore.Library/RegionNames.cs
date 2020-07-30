using System;
using System.Collections.Generic;
using System.Text;

namespace WPFCore.Library
{
    // regionen unterteilen die applikatipn verschiedene bereiche für die visualisierung
    // das wäre im fall einer wägeapplikation zB das Systemband oben, content mit weightwindow mitte und buttons unten
    public static class RegionNames
    {
        public static string ContentRegion = "ContentRegion";
        public static string SettingsRegion = "SettingsRegion";
        public static string ButtonRegion = "ButtonRegion";
    }
}
