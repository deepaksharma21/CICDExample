   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   5clr-namespace:WpfApp1.ConverterWpfApp1.Converter  5   	       WpfApp1.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   5	converterclr-namespace:WpfApp1.Converter     5   	     � Title$  Window1��5	   	   $	��450��6   $	��800��6&    � 	Resources 5
      )   #WpfApp1.Converter.FullNameConverter   FullNameConverter �� 
TargetType  SwitchButtonStyle �� Property �� Value �� 
TargetType ��Name �� CornerRadius �� Triggers	 P� Property
 P� Value �� 
TargetName��%1  &	        &	        5   
   6B   �� 5   
   " d�6   .�5      ��  � ��$	 100��6&   �� 5       � ��$ 40��6'   �� 5       � ��
 �����6+   �� 5       � ��
 �����6+   �� 5       � �� 5      �� 5      " d�6&   .R�5      �� $ border��6!   #��z��5   !   #��z��5   !   $��2q�5   !   $ 20��5   !   ._�5      �� $��Center=�6/   $��Center=�5   /   #��z��5   /   5       5       P� 5!      	 �@d�	IsChecked$

 TrueY�6;   . �5"   "   �� $ border��6)    � ��
 � � �6S   �� 5#   "   $ border��6)    � ��
 � d �6T   �� 5$   "    � ��
 �����6?   5%      P� 5&      	 �@J�IsMouseOver
 . . �5'   "   �� $ border��6)    � ��
 ��  �6T   5(      5*      5,      5-      52      .��53      � .+�54   
   �� $��18(�6   $
��Bold"�6"   ��55      `� 56       `� 	Converter# [  6    .1�57      ��  �� Path$ 	FirstName�6   �� 58      $ LastName�6   59      5;      �� 5e   
   $
��Save��6   $	��100��6    $��30��6,    � ToolTip 68   ��  �� RelativeSource �� *Self+$ Content�5g      5t      5u      