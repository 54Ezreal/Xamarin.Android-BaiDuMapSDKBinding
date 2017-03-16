package mono.com.baidu.mapapi.map;


public class BaiduMap_OnMyLocationClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baidu.mapapi.map.BaiduMap.OnMyLocationClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMyLocationClick:()Z:GetOnMyLocationClickHandler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMyLocationClickListenerInvoker, BaiDuMapBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Baidu.Mapapi.Map.BaiduMap+IOnMyLocationClickListenerImplementor, BaiDuMapBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BaiduMap_OnMyLocationClickListenerImplementor.class, __md_methods);
	}


	public BaiduMap_OnMyLocationClickListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BaiduMap_OnMyLocationClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Baidu.Mapapi.Map.BaiduMap+IOnMyLocationClickListenerImplementor, BaiDuMapBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onMyLocationClick ()
	{
		return n_onMyLocationClick ();
	}

	private native boolean n_onMyLocationClick ();

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
