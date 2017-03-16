package mono.com.baidu.location;


public class BDLocationListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baidu.location.BDLocationListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onConnectHotSpotMessage:(Ljava/lang/String;I)V:GetOnConnectHotSpotMessage_Ljava_lang_String_IHandler:Com.Baidu.Location.IBDLocationListenerInvoker, BaiDuMapBinding\n" +
			"n_onReceiveLocation:(Lcom/baidu/location/BDLocation;)V:GetOnReceiveLocation_Lcom_baidu_location_BDLocation_Handler:Com.Baidu.Location.IBDLocationListenerInvoker, BaiDuMapBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Baidu.Location.IBDLocationListenerImplementor, BaiDuMapBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BDLocationListenerImplementor.class, __md_methods);
	}


	public BDLocationListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BDLocationListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Baidu.Location.IBDLocationListenerImplementor, BaiDuMapBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onConnectHotSpotMessage (java.lang.String p0, int p1)
	{
		n_onConnectHotSpotMessage (p0, p1);
	}

	private native void n_onConnectHotSpotMessage (java.lang.String p0, int p1);


	public void onReceiveLocation (com.baidu.location.BDLocation p0)
	{
		n_onReceiveLocation (p0);
	}

	private native void n_onReceiveLocation (com.baidu.location.BDLocation p0);

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
