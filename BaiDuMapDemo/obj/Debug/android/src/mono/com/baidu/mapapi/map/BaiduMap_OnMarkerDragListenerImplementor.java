package mono.com.baidu.mapapi.map;


public class BaiduMap_OnMarkerDragListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baidu.mapapi.map.BaiduMap.OnMarkerDragListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMarkerDrag:(Lcom/baidu/mapapi/map/Marker;)V:GetOnMarkerDrag_Lcom_baidu_mapapi_map_Marker_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMarkerDragListenerInvoker, XamarinBaiDuMapSDKBinding\n" +
			"n_onMarkerDragEnd:(Lcom/baidu/mapapi/map/Marker;)V:GetOnMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMarkerDragListenerInvoker, XamarinBaiDuMapSDKBinding\n" +
			"n_onMarkerDragStart:(Lcom/baidu/mapapi/map/Marker;)V:GetOnMarkerDragStart_Lcom_baidu_mapapi_map_Marker_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMarkerDragListenerInvoker, XamarinBaiDuMapSDKBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Baidu.Mapapi.Map.BaiduMap+IOnMarkerDragListenerImplementor, XamarinBaiDuMapSDKBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BaiduMap_OnMarkerDragListenerImplementor.class, __md_methods);
	}


	public BaiduMap_OnMarkerDragListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BaiduMap_OnMarkerDragListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Baidu.Mapapi.Map.BaiduMap+IOnMarkerDragListenerImplementor, XamarinBaiDuMapSDKBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onMarkerDrag (com.baidu.mapapi.map.Marker p0)
	{
		n_onMarkerDrag (p0);
	}

	private native void n_onMarkerDrag (com.baidu.mapapi.map.Marker p0);


	public void onMarkerDragEnd (com.baidu.mapapi.map.Marker p0)
	{
		n_onMarkerDragEnd (p0);
	}

	private native void n_onMarkerDragEnd (com.baidu.mapapi.map.Marker p0);


	public void onMarkerDragStart (com.baidu.mapapi.map.Marker p0)
	{
		n_onMarkerDragStart (p0);
	}

	private native void n_onMarkerDragStart (com.baidu.mapapi.map.Marker p0);

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
