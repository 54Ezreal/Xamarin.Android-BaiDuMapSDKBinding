package mono.com.baidu.mapapi.map;


public class BaiduMap_OnMapClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baidu.mapapi.map.BaiduMap.OnMapClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMapClick:(Lcom/baidu/mapapi/model/LatLng;)V:GetOnMapClick_Lcom_baidu_mapapi_model_LatLng_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapClickListenerInvoker, XamarinBaiDuMapSDKBinding\n" +
			"n_onMapPoiClick:(Lcom/baidu/mapapi/map/MapPoi;)Z:GetOnMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapClickListenerInvoker, XamarinBaiDuMapSDKBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Baidu.Mapapi.Map.BaiduMap+IOnMapClickListenerImplementor, XamarinBaiDuMapSDKBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BaiduMap_OnMapClickListenerImplementor.class, __md_methods);
	}


	public BaiduMap_OnMapClickListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BaiduMap_OnMapClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Baidu.Mapapi.Map.BaiduMap+IOnMapClickListenerImplementor, XamarinBaiDuMapSDKBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onMapClick (com.baidu.mapapi.model.LatLng p0)
	{
		n_onMapClick (p0);
	}

	private native void n_onMapClick (com.baidu.mapapi.model.LatLng p0);


	public boolean onMapPoiClick (com.baidu.mapapi.map.MapPoi p0)
	{
		return n_onMapPoiClick (p0);
	}

	private native boolean n_onMapPoiClick (com.baidu.mapapi.map.MapPoi p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
