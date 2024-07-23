# ComboBox
Para los que migran del desarrollo web este control ser�a lo mismo que se logra al usar la etiqueta "select" y "option".
```html 
<select>
	<option value="">1</option>
</select>
```

En el elemento ComboBox, las opciones para seleccionar se les denomina ***items***  y son definidos en la propiedad del mismo nombre.

En esta ocasi�n los atributos se han defininido de forma manual en el panel de propiedades.

![Propiedad collection desde el panel de propiedades](../res/img/props_combobox.png)
<br>
*Propiedad item en el panel de propiedades.*

<br>

![colecci�n de items del comboBox](../res/img/items_combobox.png)
<br>
*Items del comboBox, **se definen l�nea por l�nea**.*

***

Este es el m�todo que se ejecuta al cambiar de opci�n en el comboBox:
```csharp
	//CmbNumberMonth => Es el nombre del control.
	//_SelectedIndexChanged => Es el evento que se ejecuta al cambiar de opci�n.

	private void CmbNumberMonth_SelectedIndexChanged(object sender, EventArgs e)
    {
		//Acci�n que se realiza al cambiar de  opci�n .		
    }
```
