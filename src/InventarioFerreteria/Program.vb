Imports System.Windows.Forms

' Punto de entrada de la aplicación (MyType = WindowsFormsWithCustomSubMain)
Module Program

    <STAThread>
    Sub Main()
        Application.SetHighDpiMode(HighDpiMode.SystemAware)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New FrmProductos())
    End Sub

End Module
