   M S B A M L   `   `   `  ����>  :CRB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:CRB.Pages	CRB.Pages  5          CRB.Pages.Uchet   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:CRB.Pages     5      -   5          N� Title$  Uchet��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��53 �6   �� 5      $��* �6   �� 5      $��53 �6   .+�5   
   �� $��0��6   ���#02b66a6!   �� 5   
   $��2��6   ���#02b66a6!   �� 5   
   $��2��6   $��Center=�6"   $��Center=�6=    �� Orientation$ 
Horizontal=�6Z   .+�5      (  "System.Windows.Controls.DatePicker  -   5          Name$ OtchetDP��5      $	��100��6+   $��5q�67     5      -   5        $ 	OtchetDP2��5      $	��100��6,   $��5q�68   �� 5      -   5         ��Name$ 	OtchetBtn��5   9   $��35��6   $��5q�6"   $	��240��6-   $D��>Отчет поступивших пациентов за 2024��6d   �� 5      -   5        $#��Добавить случай��5      $��5q�6/   6:   5      �� 5   
   $��2��6   $��Right=�6"   $��Center=�6>   $��5q�6Y   .+�5      �� $%��Фильтр по исходу:��6   $��Center=�61   $��Alegreya)�6N   
�������6d   �� 5      -   5         ��Name$ 	CmbFilter��5       �� SelectedIndex$ 0��6*   $��5q�6<   $	��150��6G   6S   5      �� 5   
   $��0��6   $ 
Horizontal=�6"   $��Center=�6;   $��Center=�6X   .+�5      �� $%��Поиск по фамилии:��6   $��Alegreya)�61   $��5q�6G   $��Center=�6R   
�������6m   �� 5      -   5         ��Name$ 	SearchTxt��5   1   $��Center=�6   $	��200��6D   $��30��6P   6\   5       �� 5"   
   -   5         ��Name$ PacLV��5"      $��1��6"   $��Stretch=�6/   $��Stretch=�6T   
������ ��5#      �� 5$      .R�5%      � 	 �Name$	 MGrid��6   
 � ColumnDefinitions
 5&      �� 5'      $	��300 �6/   �� 5(      $��* �6/   �� 5)      $	��240 �6/   �� 5*      $	��200 �6/   �� 5+      $	��200 �6/   .+�5.      �� $��0��6%   .+�5/      �� $ 
Horizontal=�6)   .+�50      �� $��ФИО:��6(   �� 51      $�� ��6(   �� 52   "   ��6,   �� *Patient.Surname+�� 53      $�� ��6(   �� 54   "   ��6,   �� *Patient.First_name+�� 55      $�� ��6(   �� 56   "   ��6,   �� *Patient.Patronymic+57      �� 58      $ 
Horizontal=�6)   .+�59   "   �� $��Пол:��6,   �� 5:   "   $�� ��6,   �� 5;   "   ��6,   �� *Patient.gender+5<      �� 5=      $ 
Horizontal=�6)   .+�5>   "   �� $ ��Дата рождения:��6,   �� 5?   "   $�� ��6,   �� 5@   "   ��6,   �� *Patient.date_of_birth+ �� StringFormat$ 
dd.MM.yyyy��5A      �� 5B      $ 
Horizontal=�6)   .+�5C   "   �� $&�� Дата поступления:��6,   �� 5D   "   $�� ��6,   �� 5E   "   ��6,   �� *date_receipt+$ 
dd.MM.yyyy��5F      5G      �� 5I      $��1��6%   $��0 0 15 0q�65   .+�5J      �� ��6'   �� *MKB+��5K   "   �� 5L   &   .R�5M   *   �� $ 
Horizontal=�65   .+�5N   .   �� ��68   �� *kod_diagnosis+�� 5O   .   $�� ��68   �� 5P   .   ��68   �� *name_diagnosis+5Q   +   5R   '   5T      5V      �� 5W      $��2��6%   .+�5X      �� ��6(   �� *Outcomes.name+5Y      �� 5Z      $��3��6%   $ 
Horizontal=�65   .+�5[      �� $��Палата № ��6(   �� 5\      ��6(   �� *beds.id_room+�� 5]      $��; ��6(   �� 5^      $��Койка № ��6(   �� 5_      ��6(   �� *beds.num_bed+5`      �� 5a      $��4��6%   .+�5b      �� $
 edit��6&   -	   5        $%��Изменить диагноз��5b   4   $��10q�6O   $��45��6[   $y�	Collapsed=�6z   5c      5d       �� Triggers 5e      �� 5f       �� Value$
 true��6D    �� Binding 6&   �� *	CheckUser+.a�5g      ��  �� 
TargetName$
 edit��6%    �� Property � y� �� Value$ Visible=�6M   5h      5j      5l      �� 5m   
   $��0��6   $��5q�6"   $��Right=�6-   $��Center=�6I   .+�5n      �� -
   5        $ ExitBtn��5n      $��5q�6'   $��30��62   $��80��6>   $��
Назад��6I   6Y   5o      5p      5q      