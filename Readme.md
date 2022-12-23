<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T103170)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# GridView - How to calculate a summary value for selected rows only
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t103170/)**
<!-- run online end -->


<p>This example is created based on the <a href="http://www.devexpress.com/Support/Center/Example/Details/E2935">How to get a summary value for selected rows only</a> example and demonstrates how to accomplish this task in MVC.<br />Since the <a href="https://documentation.devexpress.com/AspNet/DevExpressWebMvcMVCxGridViewBehaviorSettings_ProcessSelectionChangedOnServertopic.aspx">ProcessSelectionChangedOnServer</a>  property is not in effect for MVCxGridView, I handled the client-side <a href="https://documentation.devexpress.com/AspNet/DevExpressWebASPxGridViewScriptsASPxClientGridView_SelectionChangedtopic.aspx">SelectionChanged</a> event and perform a callback to update the summary.</p>

<br/>


