package mono.com.baidu.mapapi.map;


public class BaiduMap_OnMapLongClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baidu.mapapi.map.BaiduMap.OnMapLongClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMapLongClick:(Lcom/baidu/mapapi/model/LatLng;)V:GetOnMapLongClick_Lcom_baidu_mapapi_model_LatLng_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapLongClickListenerInvoker, XamarinBaiDuMapSDKBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Baidu.Mapapi.Map.BaiduMap+IOnMapLongClickListenerImplementor, XamarinBaiDuMapSDKBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BaiduMap_OnMapLongClickListenerImplementor.class, __md_methods);
	}


	public BaiduMap_OnMapLongClickListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BaiduMap_OnMapLongClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Baidu.Mapapi.Map.BaiduMap+IOnMapLongClickListenerImplementor, XamarinBaiDuMapSDKBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onMapLongClick (com.baidu.mapapi.model.LatLng p0)
	{
		n_onMapLongClick (p0);
	}

	private native void n_onMapLongClick (com.baidu.mapapi.model.LatLng p0);

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
