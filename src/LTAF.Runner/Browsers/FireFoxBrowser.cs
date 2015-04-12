﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LTAF.Runner
{
    public class FireFoxBrowser: Browser
    {


        public override void Open(IOperatingSystem operatingSystem, string url)
        {
            operatingSystem.CreateProcess("firefox.exe", url);
        }

        public override void Close(IOperatingSystem operatingSystem)
        {
            operatingSystem.KillProcess("firefox");
        }
    }
}
