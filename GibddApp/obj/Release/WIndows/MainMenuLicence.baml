   M S B A M L   `   `   `  ���� C  ?GibddApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:GibddApp.WIndowsGibddApp.WIndows  &     GibddApp.WIndows.MainMenuLicence   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:GibddApp.WIndows       � Title$F  @ГИБДД | Водительские удостоверения��$	��450��$	��800��$	��450��$	��800�� � Icon$ \Logo\gibdd_logo.png��.��� ���	#FFD1EEFC � RowDefinitions �� $
��0.2* ��� �� $
��0.2* �.+�� ���	#FFD1EEFC.+���  �� Orientation$ 
Horizontal=�$��Center=�.+��� $��\Logo\gibdd_logo.png��$��0, 5, 10, 5q��� $&�� Госавтоинспекция��$��18(�$��Center=��� -   $��Right=�$��
Выйти��$��0, 0, 10, 0q�$��30��$��65��$��16(�� $��1��.+��� -    ��Name$ LicenceList�� � 	Resources  �� 
TargetType �� Property �� Value��%2   '��       �� " ��.���  � ��$ Stretch=����� .R�� ���	#FFB5D5CA	 � ColumnDefinitions	 �� $��0.35* ��� �� �� $
��0.8* �.+��� $��83��$��5q����� *image+�� $ Vertical=�$��1��.+��� $ 
Horizontal=�.+��� $��18(�$��0, 10, 0, 0q����� *Driver.DriverFirstName+�� $��18(�$��5, 10, 0, 0q����� *Driver.DriverSecondName+�� $ 
Horizontal=�.+��� $��11(����� *LicenceDate+
 �� StringFormat$
 d���� $��-��$��
2, 0, 2, 0q�$��11(��� $��11(����� *LicenceExpireDate+$
 d���� $ 
Horizontal=�.+��� $��11(����� *LicenceSeries+�� $��11(�$��
5, 0, 0, 0q����� *LicenceNumber+�� ���� *LicenceAdditionalInfo+�� $��2��$��Center=�$��18(����� *#!CategoryStatus.CategoryStatusName+���� *Color+��Z� �� -   $��3��$��55��$��
5, 0, 5, 0q�$!��Распечатать ВУ��$��18(��� $��2��$��35��$	��300��$&�� Добавить новое ВУ��$��18(�