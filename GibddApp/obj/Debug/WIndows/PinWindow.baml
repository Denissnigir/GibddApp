   M S B A M L   `   `   `  ����C  ?GibddApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:GibddApp.WIndowsGibddApp.WIndows  5   	        GibddApp.WIndows.PinWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:GibddApp.WIndows     5   	     � Title$(  "ГИБДД | Ввод PIN-кода��5   	    � WindowStartupLocation$ CenterScreen=�6'   $	��200��6L   $	��300��6\   $	��200��6k   $	��300��6x    � WindowStyle$
 None=�6�   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��0.5* �6   �� 5      �� 5      $
��0.5* �6   .+�5   
   � ���	#FFD1EEFC.+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5      �� $��\Logo\gibdd_logo.png��6   $��0, 5, 10, 5q�66   �� 5      $&�� Госавтоинспекция��6   $��11(�64   $��Center=�6B   5      �� 5      -   5        $��Right=�5      $��
Выйти��61   $��0, 0, 10, 0q�6A   $��20��6V   $��45��6b   $��11(�6m   6{   5      � 5   
   $��1��6   .+�5      �� $ 
Horizontal=�6   .+�5      �� $ ��Введите PIN-код:��6   $��16(�64   $
��Left=�6B   $��Center=�6]   $��10, 0, 0, 0q�6x   �� 5      -   5         ��Name$ PinTB��5      $	��130��6)   $��20��65   $��10, 0, 0, 0q�6A   $��Center=�6V   5      5      �� 5   
   -   5        $��2��5      $��Ввести��6   $	��150��6/   $��30��6;   6G   5       5!      