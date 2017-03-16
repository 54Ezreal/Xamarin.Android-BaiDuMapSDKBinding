package mono.com.baidu.mapapi.map;


public class BaiduMap_OnPolylineClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baidu.mapapi.map.BaiduMap.OnPolylineClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPolylineClick:(Lcom/baidu/mapapi/map/Polyline;)Z:GetOnPolylineClick_Lcom_baidu_mapapi_map_Polyline_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnPolylineClickListenerInvoker, XamarinBaiDuMapSDKBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Baidu.Mapapi.Map.BaiduMap+IOnPolylineClickListenerImplementor, XamarinBaiDuMapSDKBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BaiduMap_OnPolylineClickListenerImplementor.class, __md_methods);
	}


	public BaiduMap_OnPolylineClickListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BaiduMap_OnPolylineClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Baidu.Mapapi.Map.BaiduMap+IOnPolylineClickListenerImplementor, XamarinBaiDuMapSDKBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onPolylineClick (com.baidu.mapapi.map.Polyline p0)
	{
		return n_onPolylineClick (p0);
	}

	private native boolean n_onPolylineClick (com.baidu.mapapi.map.Polyline p0);

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
