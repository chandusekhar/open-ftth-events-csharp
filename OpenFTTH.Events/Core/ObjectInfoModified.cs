﻿using OpenFTTH.Events.Core.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.Core
{
    public class ObjectInfoModified : DomainEvent
    {
        private readonly Guid _aggregateId;
        public Guid AggregateId => _aggregateId;

        private readonly string _aggregateType;
        public string AggregateType => _aggregateType;

        public ObjectInfoModified(string eventType, Guid eventId, DateTime eventTimestamp, Guid aggregateId, string aggregateType)
          : base(eventType, eventId, eventTimestamp)
        {
            _aggregateId = aggregateId;
            _aggregateType = aggregateType;
        }
    }
}
