   M S B A M L   `   `   `  ����M  IFluent, Version=9.0.0.0, Culture=neutral, PublicKeyToken=3e436e32a8c5546f/$clr-namespace:Fluent;assembly=FluentFluent  5   	   @ <Paint, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PaintPaint 5   	      Paint.MainWindow   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   7Fluent$clr-namespace:Fluent;assembly=Fluent     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Paint     5   	   -   5        $	��450��5	   *   $	��800��67     � Title  6	   ��  �� Path$ 	TitleName� � 	Resources 5         	MenuShape��%u   &	        �� 5   
   .@�5      m� $��BtnDeleteShape��6'   -   5        $��Delete��5      6=   5      5      .��5      ]� $
��True��6   .+�5   
      Fluent.Ribbon  $	��Top=�6      Tabs. 5         Fluent.RibbonTabItem     Header$
 Home��6#      Groups. 5         Fluent.RibbonGroupBox  $��Project��6(   .@�5         Fluent.Button  -   5        $��BtnNew��5   1      Header$	 New��6$      Icon$ /Icons/create-new.png��6T   $��50��6q      	LargeIcon 5      �� 5      $��/Icons/create-new.png��6$   	 �� BitmapScalingMode$	 HighQuality=�6C   5         Fluent.DropDownButton  5      
   Header$	
 Add��6,      Icon$ /Icons/add.png��69   $��50��6O   .@�5        -   5        $��BtnOpenBinaryFile��5   =   $ Binary File��6(   $ /Icons/open-bin-file.png��6v   $	��100��6�    5      �� 5   "   $��/Icons/open-bin-file.png��6(   $	 HighQuality=�6J   5        5!      -   5        $��BtnOpenImageFile��5!   <   $ 
Image File��6(   $ /Icons/add-image.png��6s   $	��100��6�    5"      �� 5#   "   $��/Icons/add-image.png��6(   $	 HighQuality=�6F   5%      5&        5(      $

 Save��6,   $ /Icons/save-as.png��6:   $��50��6T   .@�5)        -   5        $��BtnSaveAsBinary��5)   @   $ Save as Binary��6(      SizeDefinition/   )Fluent.Converters.SizeDefinitionConverter$ Middle 6u   $	��120��6�     5*      -   5        $��BtnSaveAsPng��5*   =   $ Save as PNG��6(   $ Middle 6l   $	��120��6�   5+      5,        5.      $��Tools��6(   .@�5/        -   5        $��BtnUndo��5/   ;   $ /Icons/undo.png��6$   ${�False��6`   $��50��6r    50      �� 51      $��/Icons/undo.png��6$   $	 HighQuality=�6=   53        55      -	   5        $��BtnRedo��55   $   $ /Icons/redo.png��63   ${�False��6`   $��50��6r    56      �� 57      $��/Icons/redo.png��6$   $	 HighQuality=�6=   59      5:        5<      $��Brush��6(   .@�5=        -
   5        $��DropdownBtnSize��5=   ,   $

 Size��6C   $ /Icons/line-width.png��6Q   $��50��6n   .@�5>      �� -   5        $��SizeList��5>   #   ��5?      �� 5@   "   .R�5A   &   �� $��BtnSize��6-   -   5        
�������$	��150��5A   n   $��30��6z   
�������$��10q�6�    � ToolTip 6<   �� *
brushWidth+.��5B   *   �� 
���   �	 �� X1$ 0��6e   	 �� Y1$ 0��6l   	 �� X2$	 100��6s   	 �� Y2$ 0��6|   ��6/   �� *
brushWidth+6|   5C   '   5D   #   5F      5G        5I      -   5        $��DropdownBtnStyle��5I   ,   $
 Style��6D   $ /Icons/line-style.png��6S   $��50��6p   .@�5J      �� -   5        $��	StyleList��5J   #   ��5K      �� 5L   "   .R�5M   &   �� $��BtnStyle��6-   -   5        
�������$	��150��5M   P   $��30��6\   
�������$��10q�6|   
 � Tag 6�   �� *
brushStyle+.��5N   *   �� 
���   �$ 0��6e   $ 0��6l   $	 100��6s   $ 0��6|   $��2��6�    �� StrokeDashArray 6/   �� *
brushStyle+6�   5O   '   5P   #   5R      5S      5T        5V      $��Shapes��6(   .@�5W      �� -   5        $��	ShapeList��5W      $	��200��60   $��10, 0, 10, 0q�6<   ��5X      �� 5Y      .R�5Z   "   � 5[      ��5^      �� 5_      .R�5`   "     $��BtnShape��60   -   5        $ Small 5`   �    6@   �� *Icon+ 6V   �� *Name+ 5a   &   �� 5b   *   $	 HighQuality=�6H   ��60   �� *Icon+6H   5d   #   5e      5g      5h        5j      $��Colors��6(   .@�5k        -   5        $��BtnBrushColor��5k   $   $ Small 69   $��15, 20, 15, 0q�6P   
���   �6g   �� 5m      -   5        $��	ColorList��5m      $	��330��60   $��Disabled=�6<   
���������5n      �� 5o      .R�5p   "   � 5q      ��5t      �� 5u      .R�5v   "   �� $��BtnColor��6)   -   5        $��20��5v   |   $��20��6�   ��69   �� $ HexColor� 6^   �� *	ColorName+6�   5w      5y        5{      -   5        $��BtnColorPicker��5{   $   $ /Icons/paint-palette.png��6:   $��50��6w    5|      �� 5}      $��/Icons/paint-palette.png��6$   $	 HighQuality=�6F   5      5�      5�        5�      $
 View��6#   . 5�        $
��Zoom��6(   .@�5�        -   5        $��	BtnZoomIn��5�   $   $ Zoom in��65   $ /Icons/zoom-in.png��6F   $��50��6x    5�      �� 5�      $��/Icons/zoom-in.png��6$   $	 HighQuality=�6@   5�        5�      -   5        $��
BtnZoomOut��5�   $   $ Zoom out��66   $ /Icons/zoom-out.png��6H   $��50��6|    5�      �� 5�      $��/Icons/zoom-out.png��6$   $	 HighQuality=�6A   5�      5�      5�        5�      $
 Help��6#   . 5�        $
��Info��6(   .@�5�        -   5        $��BtnInfo��5�   $   $
 Info��63   $ /Icons/info.png��6A   $��50��6n    5�      �� 5�      $��/Icons/info.png��6$   $	 HighQuality=�6=   5�      5�      5�      5�      �� 5�   
   -   5        $��	ScrollBar��5�      $
��Auto=�6(   $
��Auto=�6M   .��5�      � 
�������.+�5�      �� -   5        $��canvas��5�      
�������$
��Left=�6:   $	��Top=�6U   �� 5�      -   5        $��border��5�      
������ $
��Left=�5�      $	��Top=�60   $��1q�6H   
�������6\   5�      5�      5�      5�      