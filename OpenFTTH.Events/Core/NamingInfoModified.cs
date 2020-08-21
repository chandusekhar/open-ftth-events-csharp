﻿using OpenFTTH.Events.Core.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.Core
{
    public class NamingInfoModified : ObjectInfoModified
    {
        private readonly NamingInfo? _namingInfo;
        public NamingInfo? NamingInfo => _namingInfo;

        public NamingInfoModified(string eventType, Guid eventId, DateTime eventTimestamp, string cmdType, Guid cmdId, bool isLastEventInCmd, Guid workTaskMrid, string userName, string? applicationName, string? applicationInfo, Guid aggregateId, string aggregateType, NamingInfo? namingInfo)
          : base(eventType, eventId, eventTimestamp, cmdType, cmdId, isLastEventInCmd, workTaskMrid, userName, applicationName, applicationInfo, aggregateId, aggregateType)
        {
            _namingInfo = namingInfo;
        }
    }
}
