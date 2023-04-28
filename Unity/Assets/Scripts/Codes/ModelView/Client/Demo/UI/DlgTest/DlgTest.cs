namespace ET.Client
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgTest :Entity,IAwake,IUILogic
	{

		public DlgTestViewComponent View { get => this.GetComponent<DlgTestViewComponent>();} 

		 

	}
}
