   M S B A M L   `   `   `  ����C  ?GibddApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:GibddApp.WIndowsGibddApp.WIndows  5   	   &     GibddApp.WIndows.MainMenuLicence   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:GibddApp.WIndows     5   	     � Title$F  @ГИБДД | Водительские удостоверения��5   	   $	��450��64   $	��800��6D   $	��450��6S   $	��800��6`    � Icon$ \Logo\gibdd_logo.png��6l   .��5	      � ���	#FFD1EEFC � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      �� 5      $
��0.2* �6   .+�5   
   � ���	#FFD1EEFC.+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5      �� $��\Logo\gibdd_logo.png��6   $��0, 5, 10, 5q�66   �� 5      $&�� Госавтоинспекция��6   $��18(�64   $��Center=�6B   5      �� 5      -   5        $��Right=�5      $��
Выйти��61   $��0, 0, 10, 0q�6A   $��30��6V   $��65��6b   $��16(�6m   6{   5      � 5   
   $��1��6   .+�5      �� -   5         ��Name$ LicenceList��5       � 	Resources 5       �� 
TargetType �� Property �� Value��%W   '��       �� 5      " ��6   .�5      ��  � ��$ Stretch=�6G   5      5      ��5       �� 5!      .R�5"      � ���	#FFB5D5CA	 � ColumnDefinitions	 5#      �� 5$   "   $��0.35* �63   �� 5%   "   �� 5&   "   �� 5'   "   $
��0.8* �63   .+�5)      �� $��83��6=   $��5q�6I   ��6$   �� *image+6I   �� 5*      $ Vertical=�6)   $��1��6@   .+�5+   "   �� $ 
Horizontal=�6-   .+�5,   &   �� $��18(�6X   $��0, 10, 0, 0q�6f   ��60   �� *Driver.DriverFirstName+6f   �� 5-   &   $��18(�6Y   $��5, 10, 0, 0q�6g   ��60   �� *Driver.DriverSecondName+6g   5.   #   �� 5/   "   $ 
Horizontal=�6-   .+�50   &   �� $��11(�6]   ��60   �� *LicenceDate+
 �� StringFormat$
 d��6]   �� 51   &   $��-��60   $��
2, 0, 2, 0q�69   $��11(�6M   �� 52   &   $��11(�6c   ��60   �� *LicenceExpireDate+$
 d��6c   53   #   �� 54   "   $ 
Horizontal=�6-   .+�55   &   �� $��11(�6O   ��60   �� *LicenceSeries+6O   �� 56   &   $��11(�6O   $��
5, 0, 0, 0q�6]   ��60   �� *LicenceNumber+6]   57   #   �� 58   "   ��6,   �� *LicenceAdditionalInfo+59      �� 5:      $��2��6(   $��Center=�6�   $��18(�6�   ��68   �� *#!CategoryStatus.CategoryStatusName+��6k   �� *Color+��6�   Z� �� 5;      -   5        $��3��5;   %   $��55��65   $��
5, 0, 5, 0q�6A   $!��Распечатать ВУ��6U   $��18(�6n   6|   5<      5=      5?      5@      �� 5A   
   $��2��6   $��35��6   $	��300��6*   $&�� Добавить новое ВУ��66   $��18(�6R   5B      5C      