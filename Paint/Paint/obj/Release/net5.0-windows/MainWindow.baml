   M S B A M L   `   `   `  ���� M  IFluent, Version=9.0.0.0, Culture=neutral, PublicKeyToken=3e436e32a8c5546f/$clr-namespace:Fluent;assembly=FluentFluent  @ <Paint, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PaintPaint    Paint.MainWindow   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     7Fluent$clr-namespace:Fluent;assembly=Fluent     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Paint     -   $	��450��$	��800��  � Title  ��  �� Path$ 	TitleName� � 	Resources    	MenuShape��%>   &	        �� .@�m� $��BtnDeleteShape��-   $��Delete��.��]� $
��True��.+�   Fluent.Ribbon  $	��Top=�   Tabs.    Fluent.RibbonTabItem     Header$
 Home��   Groups.    Fluent.RibbonGroupBox  $��Project��.@�   Fluent.Button  -   $��BtnNew��   Header$	 New��   Icon$ /Icons/create-new.png��$��50��   	LargeIcon �� $��/Icons/create-new.png��	 �� BitmapScalingMode$	 HighQuality=�   Fluent.DropDownButton  
   Header$	
 Add��   Icon$ /Icons/add.png��$��50��.@�  -   $��BtnOpenBinaryFile��$ Binary File��$ /Icons/open-bin-file.png��$	��100�� �� $��/Icons/open-bin-file.png��$	 HighQuality=�  -   $��BtnOpenImageFile��$ 
Image File��$ /Icons/add-image.png��$	��100�� �� $��/Icons/add-image.png��$	 HighQuality=�  $

 Save��$ /Icons/save-as.png��$��50��.@�  -   $��BtnSaveAsBinary��$ Save as Binary��   SizeDefinition/   )Fluent.Converters.SizeDefinitionConverter$ Middle $	��120��  -   $��BtnSaveAsPng��$ Save as PNG��$ Middle $	��120��  $��Tools��.@�  -   $��BtnUndo��$ /Icons/undo.png��${�False��$��50�� �� $��/Icons/undo.png��$	 HighQuality=�  -	   $��BtnRedo��$ /Icons/redo.png��${�False��$��50�� �� $��/Icons/redo.png��$	 HighQuality=�  $��Brush��.@�  -
   $��DropdownBtnSize��$

 Size��$ /Icons/line-width.png��$��50��.@��� -   $��SizeList������ .R��� $��BtnSize��-   
�������$	��150��$��30��
�������$��10q� � ToolTip �� *
brushWidth+.���� 
���   �	 �� X1$ 0��	 �� Y1$ 0��	 �� X2$	 100��	 �� Y2$ 0������ *
brushWidth+  -   $��DropdownBtnStyle��$
 Style��$ /Icons/line-style.png��$��50��.@��� -   $��	StyleList������ .R��� $��BtnStyle��-   
�������$	��150��$��30��
�������$��10q�
 � Tag �� *
brushStyle+.���� 
���   �$ 0��$ 0��$	 100��$ 0��$��2�� �� StrokeDashArray �� *
brushStyle+  $��Shapes��.@��� -   $��	ShapeList��$	��200��$��10, 0, 10, 0q����� .R�� ���� .R�  $��BtnShape��-   $ Small  �� *Icon+ �� *Name+ �� $	 HighQuality=����� *Icon+  $��Colors��.@�  -   $��BtnBrushColor��$ Small $��15, 20, 15, 0q�
���   ��� -   $��	ColorList��$	��330��$��Disabled=�
����������� .R�� ���� .R��� $��BtnColor��-   $��20��$��20������ $ HexColor� �� *	ColorName+  -   $��BtnColorPicker��$ /Icons/paint-palette.png��$��50�� �� $��/Icons/paint-palette.png��$	 HighQuality=�  $
 View��.   $
��Zoom��.@�  -   $��	BtnZoomIn��$ Zoom in��$ /Icons/zoom-in.png��$��50�� �� $��/Icons/zoom-in.png��$	 HighQuality=�  -   $��
BtnZoomOut��$ Zoom out��$ /Icons/zoom-out.png��$��50�� �� $��/Icons/zoom-out.png��$	 HighQuality=�  $
 Help��.   $
��Info��.@�  -   $��BtnInfo��$
 Info��$ /Icons/info.png��$��50�� �� $��/Icons/info.png��$	 HighQuality=��� -   $��	ScrollBar��$
��Auto=�$
��Auto=�.��� 
�������.+��� -   $��canvas��
�������$
��Left=�$	��Top=��� -   $��border��
������ $
��Left=�$	��Top=�$��1q�
�������