@CODE
    Dim grid = Html.DevExpress().GridView(Sub(settings)
        settings.Name = "GridView"
        settings.CallbackRouteValues = New With{Key .Controller = "Home", Key .Action = "GridViewPartial" }
        settings.KeyFieldName = "ModelID"
        settings.CommandColumn.Visible = True
        settings.CommandColumn.ShowSelectCheckbox = True
        settings.SettingsPager.Visible = True
        settings.Settings.ShowGroupPanel = True
        settings.Settings.ShowFilterRow = False
        settings.SettingsBehavior.AllowSelectByRowClick = True
        settings.CustomSummaryCalculate = Sub (s, e) 
            
           	Dim summary As ASPxSummaryItem = TryCast(e.Item, ASPxSummaryItem)
			If summary.FieldName <> "Quantity" Then
				Return
			End If
			If e.IsTotalSummary Then
				Dim totalValue As Integer = 0
				For Each value As Object In (CType(s, MVCxGridView)).GetSelectedFieldValues("Quantity")
					totalValue += Convert.ToInt32(value)
				Next value
				e.TotalValue = totalValue
				e.TotalValueReady = True
			End If
        End Sub
        settings.Settings.ShowFooter = True
		settings.TotalSummary.Add(New ASPxSummaryItem() With {.SummaryType = DevExpress.Data.SummaryItemType.Custom, .FieldName = "Quantity", .ShowInColumn = "Quantity"})
		settings.ClientSideEvents.SelectionChanged = "function(s,e){ GridView.PerformCallback();  }"
		settings.Columns.Add("ModelID")
		settings.Columns.Add("ModelName")
		settings.Columns.Add("Quantity")
		settings.Columns.Add("ModelState")
    End Sub)
End Code
@grid.Bind(Model).GetHtml()