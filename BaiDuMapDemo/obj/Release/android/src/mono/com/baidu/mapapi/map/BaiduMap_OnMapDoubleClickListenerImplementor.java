package mono.com.baidu.mapapi.map;


public class BaiduMap_OnMapDoubleClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baidu.mapapi.map.BaiduMap.OnMapDoubleClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMapDoubleClick:(Lcom/baidu/mapapi/model/LatLng;)V:GetOnMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapDoubleClickListenerInvoker, BaiDuMapBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Baidu.Mapapi.Map.BaiduMap+IOnMapDoubleClickListenerImplementor, BaiDuMapBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BaiduMap_OnMapDoubleClickListenerImplementor.class, __md_methods);
	}


	public BaiduMap_OnMapDoubleClickListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BaiduMap_OnMapDoubleClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Baidu.Mapapi.Map.BaiduMap+IOnMapDoubleClickListenerImplementor, BaiDuMapBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onMapDoubleClick (com.baidu.mapapi.model.LatLng p0)
	{
		n_onMapDoubleClick (p0);
	}

	private native void n_onMapDoubleClick (com.baidu.mapapi.model.LatLng p0);

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
