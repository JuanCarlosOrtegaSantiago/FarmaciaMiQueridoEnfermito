   M S B A M L   `   `   `  ����D  @Principal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Principal	Principal  5   	       Principal.Empleados   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Principal     5   	     � Title$  	Empleados��5   	   $	��400��6   $	��400��6(   .��5	      �  � RowDefinitions 5
   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��10 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��1��6.   $��2��6;   .+�5      �� $��80��6   $��80��6   $��enfermitico.jpg��6+   6F   �� 5      $��Center=�6   $��15(�6/   $��10,10q�6=   .��6L   REGUISTRO DE EMPLEADOS6d   �� 5      -   5         ��Name$ btnRegresar��5      $��90��6*   $��25��65   .��6[   
Regresar6e   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtgEmpleados��5         
IsReadOnly . $��0��6;   $��2��6K   6Z   �� 5   
   -   5         ��Name$ campos��5   X   $��2��6   $��1��6"   $ Vertical=�62   $��15,10q�6I   .+�5      �� $ 
Horizontal=�6   $��Right=�62   .+�5      �� $��10(�6   $
��Thin"�6&   $��5q�68   .��6C   
*Nombre:6M   �� 5      -   5         ��Name$ tbxNombreEmpleado��5   2   $	��100��6   $��20��6&   6O   5       �� 5!      $ 
Horizontal=�6   $��Right=�62   .+�5"      �� $��10(�6   $
��Thin"�6&   $��5q�68   .��6C   
*Puesto:6M   �� 5#      -   5        $ tbxPuestoEmpleado��5#   2   $	��100��6   $��20��6&   6O   5$      �� 5%      $ 
Horizontal=�6   $��Right=�62   .+�5&      �� $��10(�6   $
��Thin"�6&   $��5q�68   .��6C   *Dirección:6P   �� 5'      -   5        $ tbxDireccionEmpleado��5'   2   $	��100��6   $��20��6&   6S   5(      �� 5)      $ 
Horizontal=�6   $��Right=�62   .+�5*      �� $��10(�6   $
��Thin"�6&   $��5q�68   .��6C   *Teléfono:6O   �� 5+      -   5        $ tbxTelefonoEmpleado��5+   2   $	��100��6   $��20��6&   6R   5,      �� 5-      $
��Left=�6   .+�5.      �� $��7(�6   $
��Bold"�6%   $��10,60q�67   $
��Left=�6F   .��6a   *Campos Obligatorios6w   5/      50      �� 52   
   $��3��6   $ 
Horizontal=�6"   $��Center=�6;   $��2��6X   .+�53      �� $
��Left=�6   $ 
Horizontal=�64   .+�54      �� -   5        $ btnAgregarEmpleado��54      $��5q�65   $��90��6A   $��25��6L   .��6y   	Agregar6�   �� 55      -	   5        $ btnEditarEmpleado��55      $��90��64   $��25��6?   .��6k   Editar6s   �� 56      -
   5        $ btnEliminarEmpleado��56      $��5q�66   $��90��6A   $��25��6L   .��6z   
Eliminar6�   �� 57      -   5        $ 
btnGuardar��57      $��5q�6-   $��90��68   $��25��6C   .��6h   	Guardar6q   58      5:      5<      5>      