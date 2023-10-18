﻿namespace Skyline.PollingManager.Interfaces
{
	using System;
	using System.Collections.Generic;

	using Skyline.PollingManager.Enums;

	public interface IPollable
	{
        string Name { get; set; }

        int Period { get; set; }

        int DefaultPeriod { get; set; }

        PeriodType PeriodType { get; set; }

        DateTime LastPoll { get; set; }

        Status Status { get; set; }

        List<IPollable> Parents { get; set; }

        List<IPollable> Children { get; set; }

        bool Poll();

        void AddParent(IPollable parent);

        void AddParents(params IPollable[] parents);

        void AddChild(IPollable child);

        void AddChildren(params IPollable[] children);
    }
}