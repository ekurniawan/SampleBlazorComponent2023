namespace BethanysPieShopHRM.App.Components.Widgets
{
    public partial class InboxWidget
    {
        public ApplicationState? ApplicationState { get; set; }

        public int MessageCount { get; set; } = 0;
        protected override void OnInitialized()
        {
            if(ApplicationState!=null)
                MessageCount = ApplicationState.NumberOfMessages;
        }
    }
}
