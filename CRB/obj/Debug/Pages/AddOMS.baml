   M S B A M L   `   `   `  ����>  :CRB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:CRB.Pages	CRB.Pages  5          CRB.Pages.AddOMS   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:CRB.Pages     5      -   5          N� Title$  AddOMS��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��53 �6   �� 5      $��* �6   �� 5      $��53 �6   .+�5   
   �� $��0��6   ���#02b66a6!   �� 5   
   $��2��6   ���#02b66a6!   �� 5   
   $��0��6   $��5q�6"   $��Right=�6-   $��Center=�6I   .+�5      �� -   5         ��Name$ ExitBtn��5      $��5q�6&   $��30��61   $��80��6=   $��
Назад��6H   6X   5      �� 5   
   $��2��6   $��5q�6"   $��Center=�6-   $��Center=�6J   .+�5      �� -   5        $��5q�5      $��30��6    $	��180��6,   $!��Добавить полис��68   6Q   5      �� 5   
   -   5         ��Name$ AddOMSLV��5      $��1��6%   $��Stretch=�62   
������ ��5      �� 5      .R�5      �  �Name$ OMSGrid��6    � ColumnDefinitions 5      �� 5      $��* �6/   �� 5      $��* �6/   �� 5       $	��200 �6/   .+�5"      �� $��0��6%   .+�5#      ��  �� Orientation$ 
Horizontal=�6)   .+�5$   "   �� $��ФИО:��6,   �� 5%   "   $�� ��6,   �� 5&   "   ��6,   �� *	Surname+�� 5'   "   $�� ��6,   �� 5(   "   ��6,   �� *
First_name+�� 5)   "   $�� ��6,   �� 5*   "   ��6,   �� *
Patronymic+5+      �� 5,      $ 
Horizontal=�6)   .+�5-   "   �� $��Пол:��6,   �� 5.   "   $�� ��6,   �� 5/   "   ��6,   �� *gender+50      �� 51      $ 
Horizontal=�6)   .+�52   "   �� $ ��Дата рождения:��6,   �� 53   "   $�� ��6,   �� 54   "   ��6,   �� *date_of_birth+ �� StringFormat$ 
dd.MM.yyyy��55      �� 56      $ 
Horizontal=�6)   .+�57   "   �� $&�� Адрес нахождения:��6,   �� 58   "   $�� ��6,   �� 59   "   ��6,   �� *actual_address+5:      �� 5;      $ 
Horizontal=�6)   .+�5<   "   �� $"��Адрес прописки:��6,   �� 5=   "   $�� ��6,   �� 5>   "   ��6,   �� *registered_address+5?      5@      �� 5A      $��1��6%   $��0 0 15 0q�65   .+�5B      �� ��6'   �� *
OMS_policy+��5C   "   �� 5D   &   .R�5E   *   �  5F   .   �� 5G   2   �� 5H   2   �� 5I   2   �� 5J   2   �� 5K   2   .+�5M   .   �� $ 
Horizontal=�69   $��0��6R   .+�5N   2   �� $��Номер полиса: ��6<   �� 5O   2   ��6<   �� *policy_number+5P   /   �� 5Q   .   $ 
Horizontal=�69   $��1��6R   .+�5R   2   �� $��Регион: ��6<   �� 5S   2   ��6<   �� *region+5T   /   �� 5U   .   $ 
Horizontal=�69   $��2��6R   .+�5V   2   �� $+��%Страховая компания: ��6<   �� 5W   2   ��6<   �� *insurance_company+5X   /   �� 5Y   .   $ 
Horizontal=�69   $��3��6R   .+�5Z   2   �� $.��(Дата начала действия: ��6<   �� 5[   2   ��6<   �� *
start_date+$ 
dd-MM-yyyy��5\   /   �� 5]   .   $ 
Horizontal=�69   $��4��6R   .+�5^   2   �� $4��.Дата окончания действия: ��6<   �� 5_   2   ��6<   �� *
end_date+$ 
dd-MM-yyyy��5`   /   5a   +   5b   '   5d      5e      �� 5f      -   5        $��2��5f   !   $��50��61   $ ��Редактировать��6=   6U   5g      5h      5j      5k      5l      