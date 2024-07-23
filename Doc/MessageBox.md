# MessageBox
Para los desarrolladores web, con este controlse lograr�a lo equivalente a abrir un modal, con la diferencia que se puede configurar los botones e �conos que se quiere mostrar.

Este control se compone de cuatro partes:
- El cuerpo del mensaje.
- El t�tulo.
- Los botones.
- El �cono

Ejemplo:
```csharp
	Message.Show("Cuerpo de mensaje","T�tulo",MessageBoxButtons.Ok, MessageBoxIcon.Information);
```

M�todo usado para crear mensajes personalizados.
```csharp
    private void ShowMessage(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }
```

## Opciones para los botones del control MessageBox
![Ociones para los botones del control MessageBox](../res/img/MessageBox_optionsButtons.png)
<br>
*Cada opci�n indica los botones que mostrr� el conntrol.*
## Opciones para los �conos del control MessageBox
![Opciones para los �conos del control MessageBox](../res/img/MessageBox_optionsIcons.png)

