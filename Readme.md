# GridView - How to calculate a summary value for selected rows only


<p>This example is created based on the <a href="http://www.devexpress.com/Support/Center/Example/Details/E2935">How to get a summary value for selected rows only</a> example and demonstrates how to accomplish this task in MVC.<br />Since the <a href="https://documentation.devexpress.com/AspNet/DevExpressWebMvcMVCxGridViewBehaviorSettings_ProcessSelectionChangedOnServertopic.aspx">ProcessSelectionChangedOnServer</a>  property is not in effect for MVCxGridView, I handled the client-side <a href="https://documentation.devexpress.com/AspNet/DevExpressWebASPxGridViewScriptsASPxClientGridView_SelectionChangedtopic.aspx">SelectionChanged</a> event and perform a callback to update the summary.</p>

<br/>


