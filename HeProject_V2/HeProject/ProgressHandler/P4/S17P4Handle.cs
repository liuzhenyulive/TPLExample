﻿using System;
using System.Collections.Generic;
using System.Text;
using HeProject.Model;
using HeProject.ProgressHandler.Common;
using HeProject.ProgressHandler.P3;

namespace HeProject.ProgressHandler.P4
{
    public class S17P4Handle:IP4Handler
    {
        public string Hnalder(int row, ProcessContext context)
        {
            new P4HandleCommon().GetOrder(17, row, context);
            return null;
        }
    }
}
