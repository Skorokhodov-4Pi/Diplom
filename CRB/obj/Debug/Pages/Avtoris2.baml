   M S B A M L   `   `   `  ����>  :CRB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:CRB.Pages	CRB.Pages  5          CRB.Pages.Avtoris2   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:CRB.Pages     5        N� Title$  Avtoris2��5	       N� 
Background
 ���� .��5      ��  �� CornerRadius$ 0��6   ��5   
   �� 5       �� ImageSource$ /Resources/backgr.jpg��6   ._�5   
   �� $ 0��6   $��5q�5   	    J� Opacity$
 0.85Q�5   	   ��5      �� 5       �� 
StartPoint$	 0,1&�6&    �� EndPoint$	 1,0&�67   .��5      �  � Color$ #057ab8��6#    � Offset$ 0Q�63   � 5      $ #02b66a��6#   $
 0.75Q�63   5      ��5      �� 5      $	 0,0&�6&   $	 1,1&�67   .��5      � $ #057ab8��6#   $ 0Q�63   � 5      $ #02b66a��6#   $
 0.75Q�63   5      ._�5!      �� $��Center=�6   .+�5"      � 	 � RowDefinitions	 5$      �� 5%      $��* �6$   �� 5&      
 � ColumnDefinitions
 5)      �� 5*      .+�5-      �� $	��250��6   $��2��5.       �� Orientation$ Vertical=�5/      .+�51      �� $��/Resources/CRB.png��6   $	��100��68   $	��100��6D   �� 52      $��ВХОД��6    
�������$��25(�54      $��Alegreya)�55      $��Center=�56      �� 57      -   5         ��Name$ TxtBlockMessage��57   $   $.��(Неверный логин/пароль��6=   
���  ��$��Alegreya)�6k    �� TextAlignment$ Center=�6�   $��5q�6�   $y�	Collapsed=�6�   �� 58      $��
Логин��6$   
�������$��12(�5:      $��Medium"�5;      $��Alegreya)�5<      $��0,35,0,0q�5=      �� 5?      -   5         ��Name$ 	LoginUser��5?      $��13(�5@      $��Medium"�5A      $��Alegreya)�5B      
������ 
������� �� 
CaretBrush
 ��������	#FF04804C$��0,0,0,1q�5G      $��28��5H      $��Center=�5I      $��0,5,0,0q�5J      �� 5L      $��Пароль��6    
�������$��12(�5N      $��Medium"�5O      $��Alegreya)�5P      $��0,35,0,0q�5Q      G� 5S      -   5         G�Name$ PasswordUser��5S   "   $��13(�5T      $��Medium"�5U      $��Alegreya)�5V      
������ 
������� G� 
CaretBrush
 ��������	#FF04804C$��0,0,0,1q�5[      $��28��5\      $��Center=�5]      $��0,5,0,0q�5^      �� 5_      -   5         ��Name$ CaptchaStack��5_   %   $y�	Collapsed=�6;   .+�5`      �� $ 
Horizontal=�6)   $��50��6B   $��Center=�6N   $��Center=�6i   .+�5a   "   �� -   5        $ CaptchaTxt1��5a   ,   $��25(�6A   $��Strikethrough{�6O   
���  ��$��Heavy"�6�   $��UltraCondensed&�6�   6�   �� 5b   "   -   5        $ CaptchaTxt2��5b   ,   $��25(�6A   $��Strikethrough{�6O   
���  ��$��Heavy"�6�   $��UltraCondensed&�6�   6�   �� 5c   "   -   5        $ CaptchaTxt3��5c   ,   $��25(�6A   $��Strikethrough{�6O   
���  ��$��Heavy"�6�   $��UltraCondensed&�6�   6�   �� 5d   "   -   5        $ CaptchaTxt4��5d   ,   $��25(�6A   $��Strikethrough{�6O   
���  ��$��Heavy"�6�   $��UltraCondensed&�6�   6�   5e      �� 5f      -	   5        $ EnterCapTxt��5f   &   $��5q�6;   5g      �� 5h      -
   5         ��Name$ btnVhod��5h   2    �� 	IsDefault . $��Вход��5i       � Cursor$
 Hand��5j      $��2��5k      $��0,50,0,0q�5m      $��40��5n      $	��150��5o      5p      5s      5t      5u      5v      5w      