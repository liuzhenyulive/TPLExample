﻿using HeProject.Model;
using System.Collections.Generic;
using System.Linq;

namespace HeProject.ProgressHandler.P3
{
    public class S3P3Handler : IP3Handler
    {
        public string Hnalder(int row, ProcessContext context)
        {
            new P3HandleCommon().Hnalder(3, row, context);
            return null;
        }
    }
}