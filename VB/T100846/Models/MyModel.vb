Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace MVCxGridViewDataBinding.Models
	Public Class MyModel
		Public Sub New()
			Me.New(0)

		End Sub
		Public Sub New(ByVal index As Integer)
			ModelID = index
			ModelName = "Name" & index
			ModelState = index Mod 2 = 0
			ModelDate = DateTime.Now
			If index < 25 Then
				Quantity = index + 5 + index \2
			Else
				Quantity = index + 5 - index\2
			End If
		End Sub
		' Fields...
		Private _Quantity As Integer
		Private _ModelID As Integer
		Private _ModelName As String
		Private _ModelState? As Boolean
		Private _ModelDate As DateTime

		Public Property ModelID() As Integer
			Get
				Return _ModelID
			End Get
			Set(ByVal value As Integer)
				_ModelID = value
			End Set
		End Property
		Public Property ModelName() As String
			Get
				Return _ModelName
			End Get
			Set(ByVal value As String)
				_ModelName = value
			End Set
		End Property
		Public Property ModelState() As Boolean?
			Get
				Return _ModelState
			End Get
			Set(ByVal value? As Boolean)
				_ModelState = value
			End Set
		End Property
		Public Property ModelDate() As DateTime
			Get
				Return _ModelDate
			End Get
			Set(ByVal value As DateTime)
				_ModelDate = value
			End Set
		End Property

		Public Property Quantity() As Integer
			Get
				Return _Quantity
			End Get
			Set(ByVal value As Integer)
				_Quantity = value
			End Set
		End Property
		Public Shared Function GetModelList() As List(Of MyModel)
			Dim l As New List(Of MyModel)()
			For i As Integer = 0 To 49
				l.Add(New MyModel(i))
			Next i
			Return l
		End Function
		Public Shared Sub UpdateModel(ByVal l As List(Of MyModel), ByVal m As MyModel)

			Dim editedModel As MyModel = l.Where(Function(x) x.ModelID = m.ModelID).First()
			editedModel.ModelName = m.ModelName
			editedModel.ModelDate = m.ModelDate
			editedModel.ModelState = m.ModelState
		End Sub
		Public Shared Sub DeleteModel(ByVal l As List(Of MyModel), ByVal mID As Integer)
			l.Remove(l.Where(Function(x) x.ModelID = mID).First())
		End Sub
		Public Shared Sub InsertModel(ByVal l As List(Of MyModel), ByVal m As MyModel)
			m.ModelID = l.Count + 1
			l.Add(m)
		End Sub
	End Class
End Namespace