   M S B A M L   `   `   `  ����  WPFToastMessage,    &Se.Creotec.WPFToastMessage.ToastWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  Toast��5   	   $��117.5��6   $	��331��6&    � 
ResizeMode$ NoResize=�62    � ShowInTaskbar .   � Topmost .  � WindowStyle$
 None=�6m   $��1q�6�   ���	#FFC3C3C3.��5      � .+�5   
   �� -   5         ��Name$ labelToastTitle��5      $��Toast Title��6)   $��
10,10,46,0q�6?   $	��Top=�6S   $��20(�6k   $��0,5,5,5q�6y   �� 5   
   -   5         ��Name$ textToastMessage��5      $��10,46,11,9.5q�6,    �� TextWrapping$
 Wrap=�6B   $��Toast message��6V   ��.   �� 
IsReadOnly . $��0q�6�   ��6�   Z� 	 �� SelectionBrush	 6�   Z� 6�   �� 5   
   -   5        
 ��Name$
 buttonToastClose��5      $��r��6+   $��Right=�67   $	��Top=�6S   $��35��6k   $��30��6�   $��16(�6�    � ToolTip$ Close��6�   $��Webdings)�6�   $��0q�6�   ��6v   Z� ��5	      �� 5
       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value 63   Z� �� 5       � ��
 �����63   �� 5       � �� 5      �� 5       �� 
TargetType" ��6.   .R�5   "   �� #��z��6)   ._�5   &   �� $��Center=�67   $��Center=�6T   5   #   5      5       �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value . . �5      ��  � �� �	#FFFF54546;   �� 5       � ��
 �����6;   5      5      5      5      5       