   M S B A M L   `   `   `  ���� C  ?GibddApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:GibddApp.WIndowsGibddApp.WIndows       GibddApp.WIndows.DriverAdd   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:GibddApp.WIndows       � Title$8  2ГИБДД | Добавление водителя��$	��450��$	��600��.��� ���	#FFB5D5CA � RowDefinitions �� $��0.15* ��� �� $��0.15* �.+�� ���	#FFD1EEFC.+���  �� Orientation$ 
Horizontal=�$��Center=�.+��� $��\Logo\gibdd_logo.png��$��0, 5, 10, 5q��� $&�� Госавтоинспекция��$��18(�$��Center=��� -   $
��Left=�$��
Назад��$��10, 0, 0, 0q�$��30��$��65��$��16(�� $��1�� � ColumnDefinitions �� �� .+��� $ Vertical=�$��0, 10, 5, 0q�.+��� $'��!Идентификатор(GUID):��$��16(�$��Right=��� $��Имя:��$��Right=�$��16(��� $��Фамилия:��$��Right=�$��16(��� $!��Паспорт(серия):��$��Right=�$��16(��� $!��Паспорт(номер):��$��Right=�$��16(��� $(��"Город регистрации:��$��Right=�$��16(��� $(��"Адрес регистрации:��$��Right=�$��16(��� $?��9Город фактического проживания:��$��Right=�$��16(��� $?��9Адрес фактического проживания:��$��Right=�$��16(��� $��Место работы:��$��Right=�$��16(��� $��Должность:��$��Right=�$��16(��� $(��"Мобильный телефон:��$��Right=�$��16(��� $��Email:��$��Right=�$��16(��� $��Фотография:��$��Right=�$��16(��� $��Замечания:��$��Right=�$��16(��� $ Vertical=�$��5, 10, 0, 0q�$��1��.+��� -    ��Name$ IdCounterTB��$��16(�$
��Left=�$	��250��$��20��{�.  �� -   $ 
DriverFNTB��$��16(�$
��Left=�$	��250��$��20���� -   $��
DriverSNTB��$��16(�$
��Left=�$	��250��$��20���� -   $��DriverPassSerialTB��$��16(�$
��Left=�$	��250��$��20���� -   $��DriverPassNumberTB��$��16(�$
��Left=�$	��250��$��20���� -   $��
TownListCB�� �� DisplayMemberPath$ TownName��$��16(�$
��Left=�$	��250��$��20�� �� 
IsEditable . �� -   $��DriverAddressTB��$��16(�$
��Left=�$	��250��$��20���� -	   $��TownLifeListCB��$ TownName��$��16(�$
��Left=�$	��250��$��20�� . �� -
   $��DriverAddressLifeTB��$��16(�$
��Left=�$	��250��$��20���� -   $��	CompanyCB��$ CompanyName��$��16(�$
��Left=�$	��250��$��20�� . �� -   $��JobCB��$ JobName��$��16(�$
��Left=�$	��250��$��20�� . �� -   $��DriverPhoneTB��$��16(�$
��Left=�$	��250��$��20���� -   $��DriverEmailTB��$��16(�$
��Left=�$	��250��$��20���� -   $��ChoosePhotoBTN��$��Выбрать фото��$
��Left=�$	��250��$��20���� -   $��DriverDescriptionTB��$��16(�$
��Left=�$	��250��$��20���� -   $��2��$��35��$	��250��$'��!Добавить водителя��$��18(�