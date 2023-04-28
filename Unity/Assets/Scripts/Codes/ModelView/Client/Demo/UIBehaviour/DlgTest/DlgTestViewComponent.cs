
using UnityEngine;
using UnityEngine.UI;
namespace ET.Client
{
	[ComponentOf(typeof(DlgTest))]
	[EnableMethod]
	public  class DlgTestViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.Button E_LoginButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_LoginButton == null )
     			{
		    		this.m_E_LoginButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Sprite_BackGround/E_Login");
     			}
     			return this.m_E_LoginButton;
     		}
     	}

		public UnityEngine.UI.Image E_LoginImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_LoginImage == null )
     			{
		    		this.m_E_LoginImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Sprite_BackGround/E_Login");
     			}
     			return this.m_E_LoginImage;
     		}
     	}

		public UnityEngine.UI.Image E_IconImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_IconImage == null )
     			{
		    		this.m_E_IconImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Sprite_BackGround/E_Icon");
     			}
     			return this.m_E_IconImage;
     		}
     	}

		public TMPro.TextMeshProUGUI E_TxtTextMeshProUGUI
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TxtTextMeshProUGUI == null )
     			{
		    		this.m_E_TxtTextMeshProUGUI = UIFindHelper.FindDeepChild<TMPro.TextMeshProUGUI>(this.uiTransform.gameObject,"Sprite_BackGround/E_Txt");
     			}
     			return this.m_E_TxtTextMeshProUGUI;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_LoginButton = null;
			this.m_E_LoginImage = null;
			this.m_E_IconImage = null;
			this.m_E_TxtTextMeshProUGUI = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Button m_E_LoginButton = null;
		private UnityEngine.UI.Image m_E_LoginImage = null;
		private UnityEngine.UI.Image m_E_IconImage = null;
		private TMPro.TextMeshProUGUI m_E_TxtTextMeshProUGUI = null;
		public Transform uiTransform = null;
	}
}
