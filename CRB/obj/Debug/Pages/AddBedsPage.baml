   M S B A M L   `   `   `  ����>  :CRB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:CRB.Pages	CRB.Pages  5          CRB.Pages.AddBedsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:CRB.Pages     5        N� Title$  AddBedsPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      .+�5   
   �� $��Палата: ��6   $��Center=�6$   $
��Left=�6?   $��16��6Z   $��44��6f   $��15q�6q   �� 5   
   $��Тип палаты: ��6   $��Center=�6(   $
��Left=�6C   $��1��6^   $��16��6k   $��68��6w   $��15q�6�   �� 5   
   $��Кол-во коек: ��6   $��Center=�6)   $
��Left=�6D   $��2��6_   $��16��6l   $	��100��6x   $��15q�6�   �� 5   
   -   5         ��Name$ RoomCmb��5   j    �� 
IsEditable .  �� DisplayMemberPath$ id_room��6M   $��25��6{   $	��670��6�   $��	90,0,40,0q�6�   $
��Left=�6�    �� SelectedItem 6%   �� *hospital_rooms+6�   �� 5   
   -   5        $ 	GendreCmb��5   %    �� SelectedIndex$ 0��6   $��1��68   $��25��6E   $	��670��6Q   $��	90,0,40,0q�6]   $
��Left=�6p   �� 5   
   -   5        $��CountBedsTxt��5      $��2��6&   $��25��63   $	��670��6?   $��90,44,40,44q�6K   $
��Left=�6`   �� 5   
   $��1��6   $��3��6%    �� Orientation$ 
Horizontal=�62   $
��Left=�6K   $��Center=�6f   $��42��6�   $	��420��6�   $��160 10 10 10q�6�   .+�5      �� -   5        $��	AddBedBtn��5      $	��200��6>   $.��(Добавить палату/койки��6J   $��5q�6j   �� 5      -   5        	 ��Name$	 cancel��5      $	��200��6:   $��Отмена��6F   $��5q�6W   5      5       5!      