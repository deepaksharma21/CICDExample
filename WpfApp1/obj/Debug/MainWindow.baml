   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   5clr-namespace:WpfApp1.ConverterWpfApp1.Converter  5   	   -clr-namespace:WpfApp1.EventWpfApp1.Event  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   5	converterclr-namespace:WpfApp1.Converter     5   	   -eventclr-namespace:WpfApp1.Event     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5	        � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5         ButtonTemplate �� 
TargetType �� Triggers P� Property P� Value �� 
TargetName �� Property �� Value   WpfApp1.Event.MyControl	 �� 
TargetType
 �� Padding   Title   WpfApp1.Person  NameAgeConverter1   +WpfApp1.Converter.BoolToVisibilityConverter  BoolToVisibilityConverter+   %WpfApp1.Converter.AndBooleanConverter  AndBooleanConverter��%P  &	        '  %    &	 �    &	 �    &	     �� 5   
   " ��61   .R�5      � .+�5      A� $��ellipse��6   
���  ��5      �� 5      $��Center=�6#   $��Center=�6@   6]   5       5      P� 5       �@J�IsMouseOver . . �5      �� $ ellipse��6-    � ��
 � � �6R   5      5      �� 5   
   "	  6   .�5      ��  � �� 5       �� 5!      "  6&   .R�5"      �� 
�������$
 5q�68   ._�5#      �� #��z 6(   5$      5%      5'      5(        5*   
   6     5+   
   6.     5,   
   6(   5-      .��5/      �  � RowDefinitions 50   
   �� 51      $��30 �6   6*   �� 52      $��30 �6   6*   �� 53      $��30 �6   6*   .+�56   
   �� $��1��6:   $	��200��6G   ��6   �� *PersonObj.FirstName+��5?      �� 5@      "	 ��6   .�5A      ��  � {� .  6B    �� Triggers 5B      �� 5C       �� Binding 6&   �� *PersonObj.IsSelected+ �� Value True6O   .a�5D      ��  � {� . 6I   5E      5G      5J      �� 5L   
   $��2��6   $��Submit��6   5U      5\      5]      