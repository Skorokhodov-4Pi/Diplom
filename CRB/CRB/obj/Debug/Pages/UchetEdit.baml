   M S B A M L   `   `   `  ����>  :CRB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:CRB.Pages	CRB.Pages  5          CRB.Pages.UchetEdit   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:CRB.Pages     5      -   5          N� Title$  	UchetEdit��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      .+�5   
   �� $��Фамилия��6   $��5q�6#   $��Center=�6.   $��Right=�6I   $��0��6e   �� 5   
   $��5q�65   $��Center=�6@   $
��Left=�6[   $��0��6v   $��1��6�   ��6   �� *Patient.Surname+6�   �� 5   
   $��Имя��6   $��5q�6   $��Center=�6*   $��Right=�6E   $��1��6a   �� 5   
   $��5q�68   $��Center=�6C   $
��Left=�6^   $��1��6y   $��1��6�   ��6   �� *Patient.First_name+6�   �� 5    
   $��Отчество��6   $��5q�6$   $��Center=�6/   $��Right=�6J   $��2��6f   �� 5!   
   $��5q�68   $��Center=�6C   $
��Left=�6^   $��2��6y   $��1��6�   ��6   �� *Patient.Patronymic+6�   �� 5"   
   $��Дата рождения��6   $��5q�6)   $��Center=�64   $��Right=�6O   $��3��6k   �� 5#   
   $��5q�6;   $��Center=�6F   $
��Left=�6a   $��3��6|   $��1��6�   ��6   �� *Patient.date_of_birth+6�   �� 5$   
   $%��Дата поступления��6   $��5q�6,   $��Center=�67   $��Right=�6R   $��4��6n   �� 5%   
   $��5q�62   $��Center=�6=   $
��Left=�6X   $��4��6s   $��1��6�   ��6   �� *date_receipt+6�   �� 5&   
   $��Заболевания��6   $��5q�6'   $��Center=�62   $��Right=�6M   $��5��6i   �� 5'   
   -   5         ��Name$ MKBLV��5'      $��1��6>   $��5��6N   ��6"   �� *MKB+��5(      �� 5)      .R�5*      ��  �� Orientation$ 
Horizontal=�6!   .+�5+      �� ��6$   �� *kod_diagnosis+�� 5,      $�� ��6$   �� 5-      ��6$   �� *name_diagnosis+5.      5/      51      �� 52   
   $��6��6   $��1��6"   $ 
Horizontal=�62   $
��Left=�6K   $��
10,10,0,10q�6f   .+�53      �� -   5         ��Name$ AddBtn��53      $��Добавить��6%      Mbtn#��[  68   $	��5 0q�6V   $	��100��6c   6o   �� 54      -   5        $ DelBtn��54      $��Удалить��6%   #��[  67   $	��5 0q�6U   $	��100��6b   6n   55      �� 56   
   $��7��6   $��1��6"   $ 
Horizontal=�62   $��5q�6K   $
��Left=�6V   $��Center=�6q   �� 57   
   $��8��6   $��1��6"   $ 
Horizontal=�62   $
��Left=�6K   $��
10,10,0,10q�6f   .+�58      �� -   5        $ EditBtn��58      $��Изменить��6&   #��[  69   $	��5 0q�6W   $	��100��6d   6p   �� 59      -   5        $ 	CancelBtn��59      $��Отменить��6(   #��[  6;   $	��5 0q�6Y   $	��100��6f   6r   5:      5<      5=      