package mono.com.baidu.mapapi.map;


public class InfoWindow_OnInfoWindowClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baidu.mapapi.map.InfoWindow.OnInfoWindowClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onInfoWindowClick:()V:GetOnInfoWindowClickHandler:Com.Baidu.Mapapi.Map.InfoWindow/IOnInfoWindowClickListenerInvoker, BaiDuMapBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Baidu.Mapapi.Map.InfoWindow+IOnInfoWindowClickListenerImplementor, BaiDuMapBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", InfoWindow_OnInfoWindowClickListenerImplementor.class, __md_methods);
	}


	public InfoWindow_OnInfoWindowClickListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == InfoWindow_OnInfoWindowClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Baidu.Mapapi.Map.InfoWindow+IOnInfoWindowClickListenerImplementor, BaiDuMapBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onInfoWindowClick ()
	{
		n_onInfoWindowClick ();
	}

	private native void n_onInfoWindowClick ();

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
