package mono.com.baidu.lbsapi.auth;


public class LBSAuthManagerListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.baidu.lbsapi.auth.LBSAuthManagerListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAuthResult:(ILjava/lang/String;)V:GetOnAuthResult_ILjava_lang_String_Handler:Com.Baidu.Lbsapi.Auth.ILBSAuthManagerListenerInvoker, XamarinBaiDuMapSDKBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Baidu.Lbsapi.Auth.ILBSAuthManagerListenerImplementor, XamarinBaiDuMapSDKBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LBSAuthManagerListenerImplementor.class, __md_methods);
	}


	public LBSAuthManagerListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == LBSAuthManagerListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Baidu.Lbsapi.Auth.ILBSAuthManagerListenerImplementor, XamarinBaiDuMapSDKBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAuthResult (int p0, java.lang.String p1)
	{
		n_onAuthResult (p0, p1);
	}

	private native void n_onAuthResult (int p0, java.lang.String p1);

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
