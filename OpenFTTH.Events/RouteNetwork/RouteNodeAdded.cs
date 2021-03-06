﻿using OpenFTTH.Events.Core.Infos;
using OpenFTTH.Events.RouteNetwork.Infos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFTTH.Events.RouteNetwork
{
    public class RouteNodeAdded : RouteElementAddedEvent
    {
        private readonly Guid _nodeId;
        public Guid NodeId => _nodeId;

        private readonly string _geometry;
        public string Geometry => _geometry;

        private readonly RouteNodeInfo? _routeNodeInfo;
        public RouteNodeInfo? RouteNodeInfo => _routeNodeInfo;

        public RouteNodeAdded(string eventType, Guid eventId, DateTime eventTimestamp, string? applicationName, string? applicationInfo, NamingInfo? namingInfo, LifecycleInfo? lifecyleInfo, MappingInfo? mappingInfo, SafetyInfo? safetyInfo, Guid nodeId, string geometry, RouteNodeInfo? routeNodeInfo) 
            : base(eventType, eventId, eventTimestamp, applicationName, applicationInfo, namingInfo, lifecyleInfo, mappingInfo, safetyInfo)
        {
            _nodeId = nodeId;
            _geometry = geometry;
            _routeNodeInfo = routeNodeInfo;
        }
    }
}
