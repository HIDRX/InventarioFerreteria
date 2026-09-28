''' <summary>Representa una fila de la tabla productos.
''' Cada propiedad corresponde a una columna.</summary>
Public Class Producto

    Public Property IdProducto As Integer
    Public Property Codigo As String = ""
    Public Property Nombre As String = ""
    Public Property IdCategoria As Integer
    Public Property Unidad As String = "Unidad"
    Public Property Precio As Decimal
    Public Property Existencia As Integer
    Public Property Activo As Boolean = True

End Class