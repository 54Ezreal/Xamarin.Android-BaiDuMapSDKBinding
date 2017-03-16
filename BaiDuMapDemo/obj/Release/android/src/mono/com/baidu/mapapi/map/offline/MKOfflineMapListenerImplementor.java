package mono.com.baidu.mapapi.map.offline;


public class MKOfflineMapListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baidu.mapapi.map.offline.MKOfflineMapListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onGetOfflineMapState:(II)V:GetOnGetOfflineMapState_IIHandler:Com.Baidu.Mapapi.Map.Offline.IMKOfflineMapListenerInvoker, BaiDuMapBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Baidu.Mapapi.Map.Offline.IMKOfflineMapListenerImplementor, BaiDuMapBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MKOfflineMapListenerImplementor.class, __md_methods);
	}


	public MKOfflineMapListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MKOfflineMapListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Baidu.Mapapi.Map.Offline.IMKOfflineMapListenerImplementor, BaiDuMapBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onGetOfflineMapState (int p0, int p1)
	{
		n_onGetOfflineMapState (p0, p1);
	}

	private native void n_onGetOfflineMapState (int p0, int p1);

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
