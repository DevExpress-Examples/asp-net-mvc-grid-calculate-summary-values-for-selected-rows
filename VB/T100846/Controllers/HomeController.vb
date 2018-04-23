Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc
Imports MVCxGridViewDataBinding.Models

Namespace T100846.Controllers
	Public Class HomeController
		Inherits Controller
		'
		' GET: /Home/

		Public Function Index() As ActionResult
			Return View()
		End Function


		<ValidateInput(False)> _
		Public Function GridViewPartial() As ActionResult
			Dim model = MyModel.GetModelList()
			Return PartialView("_GridViewPartial", model)
		End Function
	End Class
End Namespace
