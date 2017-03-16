package mono.com.baidu.mapapi.map;


public class BaiduMap_OnBaseIndoorMapListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baidu.mapapi.map.BaiduMap.OnBaseIndoorMapListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBaseIndoorMapMode:(ZLcom/baidu/mapapi/map/MapBaseIndoorMapInfo;)V:GetOnBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnBaseIndoorMapListenerInvoker, BaiDuMapBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Baidu.Mapapi.Map.BaiduMap+IOnBaseIndoorMapListenerImplementor, BaiDuMapBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BaiduMap_OnBaseIndoorMapListenerImplementor.class, __md_methods);
	}


	public BaiduMap_OnBaseIndoorMapListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BaiduMap_OnBaseIndoorMapListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Baidu.Mapapi.Map.BaiduMap+IOnBaseIndoorMapListenerImplementor, BaiDuMapBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onBaseIndoorMapMode (boolean p0, com.baidu.mapapi.map.MapBaseIndoorMapInfo p1)
	{
		n_onBaseIndoorMapMode (p0, p1);
	}

	private native void n_onBaseIndoorMapMode (boolean p0, com.baidu.mapapi.map.MapBaseIndoorMapInfo p1);

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
