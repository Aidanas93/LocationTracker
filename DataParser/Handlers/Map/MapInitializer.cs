﻿using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System.Net;

namespace DataParser.Handlers.Map
{
    public class MapInitializer
    {
        private GMapControl _gmapControl;
        private GMapControl GetGMapControlInstance()
        {
            if (_gmapControl == null)
            {
                _gmapControl = new GMapControl();
            }
            return _gmapControl;
        }

        public GMapControl GetGMapControl()
        {
            GMapProvider.UserAgent = "cferreira GMap tool 1.0";
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            GMapControl gmap = GetGMapControlInstance();
            gmap.MapProvider = GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Zoom = 13;
            gmap.MinZoom = 2;
            gmap.MaxZoom = 35;
            gmap.Zoom = 2;
            gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gmap.CanDragMap = true;
            gmap.DragButton = System.Windows.Forms.MouseButtons.Left;

            return gmap;
        }
    }
}
