   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   @ <AppDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AppDB.ViewsAppDB.Views 5   	      AppDB.Views.MainWindow   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   +localclr-namespace:AppDB.Views     5   	     � Title$  ConnectionApp��5	   	   $	��450��6   $	��800��6,    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� $��0��6    �� SelectedItem 6"   �� *SelectedTabItem+.@�5      �� -   5        $��PcTab��5      ��5      �� 5      $	��Pcs��6     � ContextMenu 5      �� 5      .@�5      m� $ ��Редактировать��6#    m� Command 6:   �� *OpenEditItemWnd+m� 5      $��Удалить��6#    64   �� *
DeleteItem+5      .��5      �� -   5         ��Name$ 
ViewAllPcs��5      ��6/   �� *AllPcs+ 5      �� *
SelectedPc+ �� View 5      �� 5      .P�5       �� $
��Code��6-   	 �� DisplayMemberBinding	 5!   -   �� 
 �� Path$

 Code��� 5"      $��Model��6-   	 5#   -   �� $
 Model��� 5$      $��Speed��6-   	 5%   -   �� $
 Speed��� 5&      $	��Ram��6-   	 5'   -   �� $	
 Ram��� 5(      $��Hd��6-   	 5)   -   �� $
 Hd��� 5*      $��Cd��6-   	 5+   -   �� $
 Cd��� 5,      $��Price��6-   	 5-   -   �� $
 Price�5/      51      52      �� 53      -   5        $��
LaptopsTab��53      ��54      �� 55      $��Laptops��6     57      �� 58      .@�59      m� $ ��Редактировать��6#    6:   �� *OpenEditItemWnd+m� 5:      $��Удалить��6#    64   �� *
DeleteItem+5;      .��5=      �� -   5        $ ViewAllLaptops��5=      ��63   �� *
AllLaptops+ 5>      �� *SelectedLaptop+ 5?      �� 5@      .P�5A      �� $
��Code��6-   	 5B   -   �� $

 Code��� 5C      $��Model��6-   	 5D   -   �� $
 Model��� 5E      $��Speed��6-   	 5F   -   �� $
 Speed��� 5G      $	��Ram��6-   	 5H   -   �� $	
 Ram��� 5I      $��Hd��6-   	 5J   -   �� $
 Hd��� 5K      $��Price��6-   	 5L   -   �� $
 Price��� 5M      $��Screen��6-   	 5N   -   �� $
 Screen�5P      5R      5S      �� 5T      -   5        $��PrintersTab��5T      ��5U      �� 5V      $��Printers��6     5X      �� 5Y      .@�5Z      m� $ ��Редактировать��6#    6:   �� *OpenEditItemWnd+m� 5[      $��Удалить��6#    64   �� *
DeleteItem+5\      .��5^      �� -   5        $ ViewAllPrinters��5^      ��64   �� *AllPrinters+ 5_      �� *SelectedPrinter+ 5`      �� 5a      .P�5b      �� $
��Code��6-   	 5c   -   �� $

 Code��� 5d      $��Model��6-   	 5e   -   �� $
 Model��� 5f      $��Color��6-   	 5g   -   �� $
 Color��� 5h      $
��Type��6-   	 5i   -   �� $

 Type��� 5j      $��Price��6-   	 5k   -   �� $
 Price�5l      5n      5o      �� 5p      -   5        $��ProductsTab��5p      ��5q      �� 5r      $��Products��6     5t      �� 5u      .@�5v      m� $ ��Редактировать��6#    6:   �� *OpenEditItemWnd+m� 5w      $��Удалить��6#    64   �� *
DeleteItem+5x      .��5z      �� -   5        $ ViewAllProducts��5z      ��64   �� *AllProducts+ 5{      �� *SelectedProduct+ 5|      �� 5}      .P�5~      �� $��Maker��6-   	 5   -   �� $
 Maker��� 5�      $��Model��6-   	 5�   -   �� $
 Model��� 5�      $
��Type��6-   	 5�   -   �� $

 Type�5�      5�      5�      5�      �� 5�   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Right=�5�      .+�5�      �� $��  Новый PC  ��6   ��6,   �� *OpenViewPCWnd+�� 5�      $��  Новый Laptop  ��6   ��60   �� *OpenViewLaptopWnd+�� 5�      $��  Новый Printer  ��6   ��61   �� *OpenViewPrinterWnd+�� 5�      $��  Новый Product  ��6   ��61   �� *OpenViewProductWnd+5�      5�      5�      