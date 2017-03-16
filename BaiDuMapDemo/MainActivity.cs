using Android.App;
using Android.Widget;
using Android.OS;
using Com.Baidu.Mapapi.Map;
using Com.Baidu.Mapapi;
using Com.Baidu.Mapapi.Model;
using Com.Baidu.Location;
using System;
using static Com.Baidu.Mapapi.Map.MyLocationConfiguration;
using BMap = Com.Baidu.Mapapi.Map.BaiduMap;
using static Android.Widget.RadioGroup;
using static Android.Views.View;
using Android.Views;
using XamarinBaiDuMapDemo.Droid;

namespace BaiDuMapDemo
{
    [Activity(Label = "Xamarin百度地图", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        IBDLocationListener myListener = new XamarinLocationListener();
        LocationMode currentLocationMode;
        MapView mapView = null;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SDKInitializer.Initialize(ApplicationContext);
            SetContentView(Resource.Layout.Main);
            mapView = FindViewById<MapView>(Resource.Id.mapView);
            currentLocationMode = LocationMode.Normal;
            var baiduMap = mapView.Map;
            //定义Maker坐标点  
            LatLng point = new LatLng(30.691359, 104.052236);
            //构建Marker图标  
            BitmapDescriptor bitmap = BitmapDescriptorFactory.FromResource(Resource.Drawable.marker);
            //构建MarkerOption，用于在地图上添加Marker  
            OverlayOptions option = new MarkerOptions().InvokePosition(point).InvokeIcon(bitmap);
            //在地图上添加Marker，并显示  
            baiduMap.AddOverlay(option);
            baiduMap.MyLocationEnabled = true;
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            mapView.OnDestroy();
        }

        protected override void OnResume()
        {
            base.OnResume();
            mapView.OnResume();
        }

        protected override void OnPause()
        {
            base.OnPause();
            mapView.OnPause();
        }


        public class XamarinLocationListener : IBDLocationListener
        {
            public IntPtr Handle
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public void OnReceiveLocation(BDLocation p0)
            {

            }

            #region IDisposable Support
            private bool disposedValue = false; // To detect redundant calls

            protected virtual void Dispose(bool disposing)
            {
                if (!disposedValue)
                {
                    if (disposing)
                    {
                        // TODO: dispose managed state (managed objects).
                    }

                    // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                    // TODO: set large fields to null.

                    disposedValue = true;
                }
            }

            // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
            // ~XamarinLocationListener() {
            //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            //   Dispose(false);
            // }

            // This code added to correctly implement the disposable pattern.
            public void Dispose()
            {
                // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
                Dispose(true);
                // TODO: uncomment the following line if the finalizer is overridden above.
                // GC.SuppressFinalize(this);
            }

            public void OnConnectHotSpotMessage(string p0, int p1)
            {
               
            }
            #endregion
        }
    }
}

