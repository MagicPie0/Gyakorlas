   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  Könyvtárkatalógus��5   	   $	��450��5	   	   $	��800��5
   	   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
KonyvLista��5      $��	0,0,0,142q�6R   �� 5   
   -   5         ��Name$ save_button��5      $��Mentés��6&   $��Center=�67   $��	0,335,0,0q�6T   $	��Top=�6g   $��54��6   $	��122��6�   6�   �� 5   
   -   5        $ 
add_button��5      $��Hozzáadás��6%   $
��Left=�69   $��
88,335,0,0q�6T   $	��Top=�6h   $��54��6�   $	��122��6�   6�   �� 5   
   -   5        $ delete_button��5      $��Törlés��6(   $
��Left=�69   $��625,303,0,0q�6T   $	��Top=�6i   $��54��6�   $	��122��6�   �� 5   
   -   5        $ filtration_button��5      $��Szűrés��6,   $
��Left=�6=   $��625,362,0,0q�6X   $	��Top=�6m   $��54��6�   $	��122��6�   � 5   
   -   5         �Name$ urlap��5      $y�Hidden=�6   .+�5      �� 
�������$��Center=�6%   $	��303��6B   
���   �$��Center=�6^   $	��506��6y   �� 5      -   5        $ urlap_ok��5      $��Hozzáadás��6'   $��Center=�6;   $��	0,316,0,0q�6X   $	��Top=�6k   $��41��6�   $	��132��6�   6�   �� 5      -   5        $ urlap_bezaras��5      $��	Bezárás��6,   $
��Left=�6>   $��
510,78,0,0q�6Y   $	��Top=�6m   $��41��6�   $	��132��6�   6�   �� 5      -	   5         ��Name$ urlap_bevitel_cim��5      $��Center=�61   $��	0,139,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��200��6�   $��21��6�   �� 5      -
   5        $ urlap_bevitel_oldalSzam��5      $��Center=�67   $��	0,191,0,0q�6T   $
 Wrap=�6g   $�� ��6{   $	��Top=�6�   $	��200��6�   $��21��6�   �� 5      -   5        $ urlap_bevitel_szerzo��5      $��Center=�64   $��	0,165,0,0q�6Q   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��200��6�   $��21��6�   �� 5      $��Cím:��6   $
��Left=�6#   $��232,137,0,0q�6>   $	��Top=�6S   �� 5      $��Szerző:��6   $
��Left=�6&   $��232,165,0,0q�6A   $	��Top=�6V   �� 5      $��Oldalszám:��6   $
��Left=�6)   $��232,191,0,0q�6D   $	��Top=�6Y   	� 5      -   5         	�Name$ urlap_bevitel_elolvasva��5      $��Elolvastad?��6;   $��Center=�6Q   $��	0,226,0,0q�6n   $	��Top=�6�   5      5      5      