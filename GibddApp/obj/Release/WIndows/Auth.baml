   M S B A M L   `   `   `  ���� C  ?GibddApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:GibddApp.WIndowsGibddApp.WIndows      GibddApp.WIndows.Auth   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:GibddApp.WIndows       � Title$)  #ГИБДД | Авторизация��$	��350��$	��450�� � WindowStartupLocation$ CenterScreen=�$	��350��$	��450�� � 
ResizeMode$ NoResize=� � Icon$- '/GibddApp;component/Logo/gibdd_logo.png��.��� ���	#FFB5D5CA � RowDefinitions �� $
��0.2* ��� �� $
��0.3* �.+�� ���	#FFD1EEFC.+���  �� Orientation$ 
Horizontal=�$��Center=�.+��� $-��'/GibddApp;component/Logo/gibdd_logo.png��$��0, 5, 10, 5q��� $&�� Госавтоинспекция��$��18(�$��Center=��� -   $��Right=�$��
Выйти��$��0, 0, 10, 0q�$��30��$��65��$��16(�� $��1�� �� ��  � ColumnDefinitions �� $
��0.6* ��� �� $
��0.6* �.+��� $��Авторизация��$��1��$��Center=�$��18(�$��20q��� $��1��$��Bottom=�$��
0, 0, 0, 5q�.+��� $��
Логин��$��18(��� -    ��Name$ LoginTB���� $��1��$��1��$��Center=�$��
0, 0, 0, 5q�.+��� $��Пароль��$��18(��� -   $ 
PasswordTB��� $��2��.+��� -   $&�� Авторизироваться��$��18(�$��35��$	��200��