   M S B A M L   `   `   `  ���� C  ?GibddApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:GibddApp.WIndowsGibddApp.WIndows      GibddApp.WIndows.MainMenu   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:GibddApp.WIndows       � Title$,  &ГИБДД | Основное меню��$	��450��$	��800��$	��450��$	��800�� � Icon$ \Logo\gibdd_logo.png��.��� ���	#FFD1EEFC � RowDefinitions �� $
��0.2* ��� �� $
��0.2* �.+�� ���	#FFD1EEFC.+���  �� Orientation$ 
Horizontal=�$��Center=�.+��� $��\Logo\gibdd_logo.png��$��0, 5, 10, 5q��� $&�� Госавтоинспекция��$��18(�$��Center=��� -   $��Right=�$��
Выйти��$��0, 0, 10, 0q�$��30��$��65��$��16(�� $��1��.+��� -    ��Name$ 
DriverList�� � 	Resources  �� 
TargetType �� Property �� Value��%2   '��       �� " ��.���  � ��$ Stretch=����� .R�� ���	#FFB5D5CA	 � ColumnDefinitions	 �� $��0.35* ��� �� $
��0.7* �.+��� $��93��$��10, 5, 0, 5q�$��0������ *image+�� $ Vertical=�$��1��.+��� $ 
Horizontal=�$��1��.+��� $��5, 10, 0, 0q�$��18(����� *DriverFirstName+�� $��5, 10, 0, 0q�$��18(����� *DriverMiddleName+�� $��5, 10, 0, 0q�$��18(����� *DriverSecondName+�� $��GUID: #��$��12(�$��5, 16, 0, 0q��� $��
DriverIdTB��$��12(�$��0, 16, 0, 0q����� *
DriverId+�� $ 
Horizontal=�$��1��.+��� $��11(�$��
5, 0, 0, 0q����� *JobList.JobName+�� $��+7��$��11(�$��
5, 0, 0, 0q��� $��11(����� *DriverPhone+�� $��2��.+��� $��
OpenDriver��-   $%��Открыть водителя��$��30��$��10, 10q����	#FFFFFCD6�� $��DeleteDriver��-   $%��Удалить водителя��$��30��$��10, 10q�� $��2��	 �� �� �� .+��� -   $��16(�$'��!Добавить водителя��$��35��$	��215���� -   $��1��$��16(�$��Список ВУ��$��35��$	��215���� -   $��2��$��16(�$1��+Выйти из учётной записи��$��35��$	��215��