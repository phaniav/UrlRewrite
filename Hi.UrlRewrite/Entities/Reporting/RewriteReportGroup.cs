﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hi.UrlRewrite.Entities.Rules;

namespace Hi.UrlRewrite.Entities.Reporting
{
    public class RewriteReportGroup
    {
        public string Name { get; set; }
        public int Count { get { return Reports.Count(); } }
        public InboundRule Rule { get; set; }
        public IEnumerable<RewriteReport> Reports { get; set; }

        public RewriteReportGroup()
        {
            Reports = new List<RewriteReport>();
        }

    }
}