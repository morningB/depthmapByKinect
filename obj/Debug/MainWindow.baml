   M S B A M L   `   `   `  ����M  IKinectExplorer-WPF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Microsoft.Samples.Kinect.KinectExplorer'Microsoft.Samples.Kinect.KinectExplorer  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   8    2Microsoft.Samples.Kinect.KinectExplorer.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Cl5clr-namespace:Microsoft.Samples.Kinect.KinectExplorer     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   -   5          � Title$  Kinect Explorer - Console��5   <   
 � Top$ 0��5   	    � Left$ 0��6   $	��600��5   	   $	��400��6   $	��600��5   	    � 	Resources 5
         NormalBrandBrush �� Color  HoverBrandBrush  SecondaryBrandBrush  LightNeutralBrush  MediumNeutralBrush  DarkNeutralBrush  
KinectFont �� 
TargetType �� Property �� Value  HeaderFontSize  LabelFontSize 	 ItemFontSize �� DataType>   8Microsoft.Samples.Kinect.KinectExplorer.KinectSensorItem>   8Microsoft.Samples.Kinect.KinectExplorer.KinectStatusItem	 � ColumnDefinitions
 �� Path �� StringFormatA   ;Microsoft.Samples.Kinect.KinectExplorer.VisibilityConverter 
 VisibilityConverter��%�  &	        &	 !     &	 B     &	 c     &	 �     &	 �     &	 �     '�� �     &	 >    &	 Z    &		 v    (�� �    5      *, +)7  7  7  7  7 	 7  (�� '    51      *, +)7  7 	 7  7  7 	 7  7  7 	 7  &	
 �    �� 5   
   $ #52318F��63   �� 5   
   $ #322350��62   �� 5   
   $ #00BCF2��66   �� 5   
   $ #D2D2D2��64   �� 5   
   $ #969696��65   ��5   
   #505050��6<   *�5   
   Segoe UI)�62   �� 5   
   " ��6   .�5      ��  �@J�SnapsToDevicePixels . 64   5      X�5   
   24.0Q�62   X�5   
   18.0Q�61   X�5   
   12.0Q�60   �� 5   
   "  6   .R�5      �� -   5        
������ $��	0 10 0 10q�5   Y   ��5      �� 5      .R�5       ]� #��z��6$   .+�5!      �� $��Right=�6$   $��Images\KinectSensor.png��6;   $	��100��6\   �� 5"      .+�5#   "   �� 8��  8�� 8�� ��5&   ,   �� *Status+�� 5'   "   8�� 8�� 8�� ��5*   ,   �� *Id+5+      5,      5-      5/      50      �� 51   
   "  6   .R�52      � 	 53      �� 54      $��* �6'   �� 55      $	��140 �6'   �� 56      $	��100 �6'   .+�58      �� $��0��6   8��  8�� 8�� ��5<      �� *Id+�� 5=      $��1��6   8�� 8�� $
��Bold"�5@      8�� ��5B      �� *Status+�� 5C      $��2��6   8�� 8�� 8�� ��5G      �� $
 DateTime�$ {0:t}��5H      5I        5J   
   6    5K      .��5L      � .+�5M   
   � 
������ $��20q�6(    � RowDefinitions 5N      �� 5O      $
��Auto �6    �� 5P      $
��Auto �6    �� 5Q      $
��Auto �6    �� 5R      $
��Auto �6    �� 5S      $��* �6    .+�5U      ]� $��0��6   $��2��6%   $��0 0 0 10q�69   .+�5V      �� $
��Left=�6   $��Images\Logo.png��6.   $
��Fill=�6G   $��32��6V   $��81��6b   $
��Left=�6m   $��0 10 0 0q�6�   �� 5W      $��Right=�6   $��Right=�5X      $��Bottom=�5Y      $��0 0 -1 0q�5Z      #��[ 5[      #��[ 6G   Explorer Connected Devices6�   5\      �� 5]      -   5        $��kinectSensors��5]   .   
�������$��1��6C   �� 5^      $��2��6   $��0 5 0 5q�6    	 �� X1$ 0��61   	 �� X2$ 1��68   #��[ 6?    �� Stretch$
 Fill=�6j    J� SnapsToDevicePixels . 6y   �� 5_      $��3��6   #��[ 6&   #��[ 6U   #��[ 6   Status6�   �� 5`      $��4��6   $
��Auto=�6(   .��5a      �� -   5        $��kinectStatus��5a      5b      �� 5c      $��1��5d      $��4��6   
�������y�5f      ��  �� ElementName$ kinectSensors��$
 Items.Count� �� 	Converter# [
 .+�5i      �� #��[ 6   #��[ 6K   #��[ 6u   $��-1 0 0 0q�6�   Kinect Sensor Required6�   �� 5j      #��[ 6   #��[	 6K   #��[ 6u   $
��Wrap=�6�   �� 5k      hfThere are current no Kinect Sensors connected. Please plug in a sensor to begin using this application�� 5m      �� 5n      �� 5p      -   5        $3��-http://go.microsoft.com/fwlink/?LinkID=239809?�5p       #��[ 5r       .�6R   
More info.6^   5s      5t      5v      5w      5x      