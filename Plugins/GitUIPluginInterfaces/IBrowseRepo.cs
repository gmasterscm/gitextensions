﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitUIPluginInterfaces
{
    public interface IBrowseRepo
    {
        void GoToRevision(string revision);
    }
}
