   M S B A M L   `   `   `  ����C  ?GibddApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:GibddAppGibddApp  5   	       GibddApp.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:GibddApp     5   	     � Title$)  #ГИБДД | Авторизация��5   	   $	��350��6%   $	��450��65    � WindowStartupLocation$ CenterScreen=�6D   $	��350��6i   $	��450��6v    � 
ResizeMode$ NoResize=�6�    � Icon$ \Logo\gibdd_logo.png��6�   .��5	      � ���	#FFB5D5CA � RowDefinitions 5
   
   �� 5      $
��0.2* �6   �� 5      �� 5      $
��0.3* �6   .+�5   
   � ���	#FFD1EEFC.+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5      �� $��\Logo\gibdd_logo.png��6   $��0, 5, 10, 5q�66   �� 5      $&�� Госавтоинспекция��6   $��18(�64   $��Center=�6B   5      �� 5      -   5        $��Right=�5      $��
Выйти��61   $��0, 0, 10, 0q�6A   $��30��6V   $��65��6b   $��16(�6m   6{   5      � 5   
   $��1��6    5      �� 5      �� 5       � ColumnDefinitions 5      �� 5      $
��0.6* �6#   �� 5      �� 5       $
��0.6* �6#   .+�5#      �� $��Авторизация��6   $��1��6+   $��Center=�6;   $��18(�6X   $��20q�6f   �� 5%      $��1��6   $��Bottom=�6)   $��
0, 0, 0, 5q�6D   .+�5&      �� $��
Логин��6   $��18(�6)   �� 5'      -   5         ��Name$ LoginTB��5'      5(      �� 5*      $��1��6   $��1��6)   $��Center=�66   $��
0, 0, 0, 5q�6Q   .+�5+      �� $��Пароль��6   $��18(�6*   �� 5,      -   5        $ 
PasswordTB��5,      5-      5.      � 50   
   $��2��6   .+�51      �� -   5        $&�� Авторизироваться��51      $��18(�60   $��35��6>   $	��200��6J   6V   52      53      54      